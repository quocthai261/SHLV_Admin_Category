using AdminWeb.Dtos.ApiResponse;
using AdminWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AdminWeb.Areas.Category.Controllers
{
    [Area("Category")]
    public class SalePlanConfigDetailController : Controller
    {
        private readonly IApiService _apiService;

        public SalePlanConfigDetailController(IApiService apiService)
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
        public object GetSalePlanConfigDetailList(DataSourceLoadOptions loadOptions)
        {
            var _response = salePlanConfigDetailList;

            return DataSourceLoader.Load(_response, loadOptions);
        }

        public static List<SalePlanConfigDetailResponseModel> salePlanConfigDetailList = new List<SalePlanConfigDetailResponseModel>()
        {
            new SalePlanConfigDetailResponseModel()
            {
                SalePlanConfigDetailId = 1,
                SalePlanConfigId = 22,
                PlanTypeCode = "OperationNumber",
                CreationDate=DateTime.Now,
                LastUpdatedDate=DateTime.Now,
            },
            new SalePlanConfigDetailResponseModel()
            {
                SalePlanConfigDetailId = 1,
                SalePlanConfigId = 23,
                PlanTypeCode = "K2",
                CreationDate=DateTime.Now,
                LastUpdatedDate=DateTime.Now,
            },
            new SalePlanConfigDetailResponseModel()
            {
                SalePlanConfigDetailId = 1,
                SalePlanConfigId = 22,
                PlanTypeCode = "OperationNumber",
                CreationDate=DateTime.Now,
                LastUpdatedDate=DateTime.Now,
            },
        };
    }
}
