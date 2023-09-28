using AdminWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AdminWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SettingsController : Controller
    {
        private readonly IApiService _apiService;

        public SettingsController(IApiService apiService)
        {
            _apiService = apiService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public object GetSettingListApi(DataSourceLoadOptions loadOptions)
        {
            var _response = _apiService.GetSettingListApi().Result;

            return DataSourceLoader.Load(_response, loadOptions);
        }
    }
}
