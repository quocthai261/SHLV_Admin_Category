using AdminWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AdminWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MenuManagementController : Controller
    {
        private readonly IApiService _apiService;

        public MenuManagementController(IApiService apiService)
        {
            _apiService = apiService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public object GetMenuListApi(DataSourceLoadOptions loadOptions)
        {
            var _response = _apiService.GetMenuListApi().Result;

            return DataSourceLoader.Load(_response, loadOptions);
        }
    }
}
