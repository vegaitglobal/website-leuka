using Leuka.Core.Caching;
using Leuka.Core.Models;
using Leuka.Models.Generated;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Net;
using Umbraco.Cms.Core.Cache;
using Umbraco.Cms.Core.Logging;
using Umbraco.Cms.Core.Routing;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Infrastructure.Persistence;

namespace Leuka.Core.Controllers.Surface.Partials
{
    public class InformController : BaseSurfaceController
    {
        public InformController(IUmbracoContextAccessor umbracoContextAccessor, IUmbracoDatabaseFactory databaseFactory,
            ServiceContext services, AppCaches appCaches, IProfilingLogger profilingLogger, IPublishedUrlProvider publishedUrlProvider,
            IHttpContextAccessor httpContextAccessor)
            : base(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger, publishedUrlProvider, httpContextAccessor)
        {
        }

        [HttpPost]
        [IgnoreAntiforgeryToken]
        public HttpStatusCode Contact(string firstName, string lastName, string email, string messageText, bool involveInActions, IEnumerable<IFormFile> files)
        {
            if (string.IsNullOrWhiteSpace(firstName) ||
                string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(email))
            {
                return HttpStatusCode.BadRequest;
            }

            var settings = UmbracoContext.Content.GetAtRoot().FirstOrDefault() as ISiteSettings;
            var emailSettings = new EmailSettings(settings);
            
            try
            {
                SmtpHelper.SendEmail(emailSettings, firstName, lastName, email, messageText, involveInActions, files);
                return HttpStatusCode.OK;
            }
            catch (Exception ex)
            {
                return HttpStatusCode.InternalServerError;
            }
        }

        [HttpPost]
        [IgnoreAntiforgeryToken]
        public HttpStatusCode Donate(string donor, string amount, string company, string email)
        {
            if (string.IsNullOrWhiteSpace(donor) ||
                string.IsNullOrWhiteSpace(amount) ||
                string.IsNullOrWhiteSpace(email))
            {
                return HttpStatusCode.BadRequest;
            }

            var settings = UmbracoContext.Content.GetAtRoot().FirstOrDefault() as ISiteSettings;
            var emailSettings = new EmailSettings(settings);

            try
            {
                SmtpHelper.SendDonationEmail(emailSettings, donor, amount, company, email);
                return HttpStatusCode.OK;
            }
            catch (Exception ex)
            {
                return HttpStatusCode.InternalServerError;
            }
        }
    }
}
