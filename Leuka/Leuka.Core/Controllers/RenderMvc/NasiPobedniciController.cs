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
    public class NasiPobedniciController : BasePageController<NasiPobednici>
    {
        public ActionResult Index(NasiPobednici model)
            => CurrentTemplate(new NasiPobedniciViewModel(CreatePageContext(model)));

        [System.Web.Mvc.HttpPost]
        public ActionResult NasiPobednici(string firstName, string lastName, string email, string messageText, IEnumerable<HttpPostedFileBase> files)
        {
            
                return SubmitBlogForm(firstName, lastName, email, messageText, files);
           
        }

        private static ActionResult SubmitBlogForm(string firstName, string lastName, string email, string messageText, IEnumerable<HttpPostedFileBase> files)
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
                SmtpHelper.SendEmail(emailSettings, firstName, lastName, email, messageText, false, "", files);
                return new HttpStatusCodeResult(HttpStatusCode.OK, "Message sent successfully");
            }
            catch (Exception ex)
            {
                return new HttpStatusCodeResult(HttpStatusCode.InternalServerError, "Something went wrong");
            }
        }
    }
}
