using AdminWeb.Dtos.ApiResponse;
using AdminWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AdminWeb.Areas.Category.Controllers
{
    [Area("Category")]
    public class SmtpConfigController : Controller
    {
        private readonly IApiService _apiService;

        public SmtpConfigController(IApiService apiService)
        {
            _apiService = apiService;
        }

        public IActionResult Index()
        {
            return RedirectToAction("List");
        }

        public IActionResult List()
        {
            try
            {
                return View();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpGet]
        public object GetSmtpConfigList(DataSourceLoadOptions loadOptions)
        {
            var _response = smtpConfigList;

            return DataSourceLoader.Load(_response, loadOptions);
        }

        public static List<SmtpConfigResponseModel> smtpConfigList = new List<SmtpConfigResponseModel>()
        {
            new SmtpConfigResponseModel()
            {
                SmtpConfigId = 24,
                NetworkCredentialUsername = "Limepro@hanwhalife.com.vn",
                NetworkCredentialPassword = "LIME@2021!",
                FromAddress = "Limepro@hanwhalife.com.vn",
                FromDisplayName = "Sales Force Automation",
                EnableSSL = true,
                SmtpClientPort = "25",
                SmtpClientHost = "mail.hanwhalife.com.vn",
                Active = false,
                GroupCode = null,
                ListMailCC = "agency.admin@hanwhalife.com",
                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
            new SmtpConfigResponseModel()
            {
                SmtpConfigId = 24,
                NetworkCredentialUsername = "Limepro@hanwhalife.com.vn",
                NetworkCredentialPassword = "LIME@2021!",
                FromAddress = "Limepro@hanwhalife.com.vn",
                FromDisplayName = "Sales Force Automation",
                EnableSSL = true,
                SmtpClientPort = "25",
                SmtpClientHost = "mail.hanwhalife.com.vn",
                Active = true,
                GroupCode = "HLV_SFA",
                ListMailCC = "agency.admin@hanwhalife.com",
                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
        };
    }
}
