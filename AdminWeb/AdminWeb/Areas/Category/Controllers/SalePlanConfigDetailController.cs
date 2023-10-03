using AdminWeb.Dtos.ApiResponse;
using AdminWeb.Models;
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
/*        public object GetSalePlanConfigDetailList(DataSourceLoadOptions loadOptions)
        {
            var _response = salePlanConfigDetailList;

            return DataSourceLoader.Load(_response, loadOptions);
        }*/
        public IEnumerable<SalePlanConfigDetailResponseModel> GetSalePlanConfigDetailList(int id)
{
            return salePlanConfigDetailList.Where(e => e.SalePlanConfigId == id);
        }

        public static List<SalePlanConfigDetailResponseModel> salePlanConfigDetailList = new List<SalePlanConfigDetailResponseModel>()
        {
            new SalePlanConfigDetailResponseModel()
            {
                SalePlanConfigDetailId = 1,
                SalePlanConfigId = 2,
                PlanTypeCode = "OperationNumber",
                CreationDate=DateTime.Now,
                LastUpdatedDate=DateTime.Now,
            },
            new SalePlanConfigDetailResponseModel()
            {
                SalePlanConfigDetailId = 2,
                SalePlanConfigId = 2,
                PlanTypeCode = "K2",
                CreationDate=DateTime.Now,
                LastUpdatedDate=DateTime.Now,
            },
            new SalePlanConfigDetailResponseModel()
            {
                SalePlanConfigDetailId = 3,
                SalePlanConfigId = 1,
                PlanTypeCode = "OperationNumber",
                CreationDate=DateTime.Now,
                LastUpdatedDate=DateTime.Now,
            },
        };
    }
}
