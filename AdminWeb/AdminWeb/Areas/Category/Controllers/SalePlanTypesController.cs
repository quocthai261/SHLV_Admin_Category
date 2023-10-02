using AdminWeb.Dtos.ApiResponse;
using AdminWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AdminWeb.Areas.Category.Controllers
{
    [Area("Category")]
    public class SalePlanTypesController : Controller
    {
        private readonly IApiService _apiService;

        public SalePlanTypesController(IApiService apiService)
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
        public object GetSalePlanTypesList(DataSourceLoadOptions loadOptions)
        {
            var _response = salePlanTypesList;

            return DataSourceLoader.Load(_response, loadOptions);
        }

        public static List<SalePlanTypesResponseModel> salePlanTypesList = new List<SalePlanTypesResponseModel>()
        {
            new SalePlanTypesResponseModel()
            {
                SalePlanTypesId = 1,
                Title = "AFYP",
                Code = "AFYP",
                Icon = "SalePlan/AFYP.png",
                Color = "#FFF",
                Unit = "VND",
                IsActive = true,
                CreationDate=DateTime.Now,
                LastUpdatedDate=DateTime.Now,
            },
             new SalePlanTypesResponseModel()
            {
                SalePlanTypesId = 2,
                Title = "Số lượng hợp đồng",
                Code = "PolicyNumber",
                Icon = "SalePlan/PN.png",
                Color = "#FFF",
                Unit = "%",
                IsActive = true,
                CreationDate=DateTime.Now,
                LastUpdatedDate=DateTime.Now,
            },
              new SalePlanTypesResponseModel()
            {
                SalePlanTypesId = 3,
                Title = "Tỷ lệ duy trì K2",
                Code = "K2",
                Icon = "SalePlan/K2.png",
                Color = "#FFF",
                Unit = "VND",
                IsActive = true,
                CreationDate=DateTime.Now,
                LastUpdatedDate=DateTime.Now,
            },
        };
    }
}
