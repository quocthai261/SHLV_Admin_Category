using AdminWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AdminWeb.Areas.Category.Controllers
{
    [Area("Category")]
    public class PositionApplingsController : Controller
    {
        private readonly IApiService _apiService;

        public PositionApplingsController(IApiService apiService)
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

/*
        [HttpGet]
        public object GetBankList(DataSourceLoadOptions loadOptions)
        {
            var _response = bankList;

            return DataSourceLoader.Load(_response, loadOptions);
        }*/

    }
}
