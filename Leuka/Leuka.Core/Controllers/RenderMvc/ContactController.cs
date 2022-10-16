using Leuka.Core.Caching;
using Leuka.Core.Models;
using Leuka.Core.ViewModels.Pages;
using Leuka.Models.Generated;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Umbraco.Core.Composing;
using Umbraco.Web;

namespace Leuka.Core.Controllers.RenderMvc
{
    public class ContactController : BasePageController<Contact>
    {
        public ActionResult Index(Contact model)
            => CurrentTemplate(new ContactViewModel(CreatePageContext(model)));

        [System.Web.Mvc.HttpPost]
        public ActionResult Contact(string firstName, string lastName, string email, string messageText, bool involveInActions, string formDescription, IEnumerable<HttpPostedFileBase> files, string donor, string amount, string company, string mode)
        {
            switch (mode)
            {
                case "contact": return SubmitContactForm(firstName, lastName, email, messageText, involveInActions, formDescription, files);
                case "donate": return SubmitDonateForm(donor, amount, company, email);
                default: return new HttpStatusCodeResult(HttpStatusCode.BadRequest, "Invalid mode");
            }
        }

        private static ActionResult SubmitContactForm(string firstName, string lastName, string email, string messageText, bool involveInActions, string formDescription, IEnumerable<HttpPostedFileBase> files)
        {
            if (string.IsNullOrWhiteSpace(firstName) ||
                string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(email))
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest, "Missing required fields");
            }
            if (!(CacheHelper.Instance.TryRead("siteSettings") is ISiteSettings settings))
            {
                var umbracoContextFactory = Current.Factory.GetInstance(typeof(IUmbracoContextFactory)) as IUmbracoContextFactory;
                using (var contextReference = umbracoContextFactory.EnsureUmbracoContext())
                {
                    var umbracoContext = contextReference.UmbracoContext;
                    settings = umbracoContext
                            .Content
                            .GetAtRoot()
                            .FirstOrDefault()
                        as ISiteSettings;
                }
                CacheHelper.Instance.Write("siteSettings", settings);
            }

            var emailSettings = new EmailSettings(settings);
            try
            {
                SmtpHelper.SendEmail(emailSettings, firstName, lastName, email, messageText, involveInActions, formDescription, files);
                return new HttpStatusCodeResult(HttpStatusCode.OK, "Message sent successfully");
            }
            catch (Exception ex)
            {
                return new HttpStatusCodeResult(HttpStatusCode.InternalServerError, "Something went wrong");
            }
        }

        private static ActionResult SubmitDonateForm(string donor, string amount, string company, string email)
        {
            if (string.IsNullOrWhiteSpace(donor) ||
                string.IsNullOrWhiteSpace(amount) ||
                string.IsNullOrWhiteSpace(email))
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest, "Missing required fields");
            }
            
            if (!(CacheHelper.Instance.TryRead("siteSettings") is ISiteSettings settings))
            {
                var umbracoContextFactory = Current.Factory.GetInstance(typeof(IUmbracoContextFactory)) as IUmbracoContextFactory;
                using (var contextReference = umbracoContextFactory.EnsureUmbracoContext())
                {
                    var umbracoContext = contextReference.UmbracoContext;
                    settings = umbracoContext
                            .Content
                            .GetAtRoot()
                            .FirstOrDefault()
                        as ISiteSettings;
                }
                CacheHelper.Instance.Write("siteSettings", settings);
            }

            var emailSettings = new EmailSettings(settings);
            try
            {
                SmtpHelper.PerformSending(emailSettings, $"{donor} donira {amount}", $"Kompanija: {company}",  null);
                return new HttpStatusCodeResult(HttpStatusCode.OK, "Message sent successfully");
            }
            catch (Exception ex)
            {
                return new HttpStatusCodeResult(HttpStatusCode.InternalServerError, "Something went wrong");
            }
        }

    }
}
