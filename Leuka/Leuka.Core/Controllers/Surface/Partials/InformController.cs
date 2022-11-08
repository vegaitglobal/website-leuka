using Leuka.Core.Caching;
using Leuka.Core.Models;
using Leuka.Models.Generated;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Umbraco.Core.Composing;
using Umbraco.Web;

namespace Leuka.Core.Controllers.Surface.Partials
{
    public class InformController : BaseSurfaceController
    {
        [HttpPost]
        public HttpStatusCodeResult Contact(string firstName, string lastName, string email, string messageText, bool involveInActions, IEnumerable<HttpPostedFileBase> files)
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
                SmtpHelper.SendEmail(emailSettings, firstName, lastName, email, messageText, involveInActions, files);
                return new HttpStatusCodeResult(HttpStatusCode.OK, "Message sent successfully");
            }
            catch (Exception ex)
            {
                return new HttpStatusCodeResult(HttpStatusCode.InternalServerError, "Something went wrong");
            }
        }

        [HttpPost]
        public HttpStatusCodeResult Donate(string donor, string amount, string company, string email)
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
                SmtpHelper.SendDonationEmail(emailSettings, donor, amount, company, email);
                return new HttpStatusCodeResult(HttpStatusCode.OK, "Message sent successfully");
            }
            catch (Exception ex)
            {
                return new HttpStatusCodeResult(HttpStatusCode.InternalServerError, "Something went wrong");
            }
        }
    }
}
