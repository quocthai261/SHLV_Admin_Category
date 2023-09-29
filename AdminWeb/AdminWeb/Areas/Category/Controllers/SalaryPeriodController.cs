using AdminWeb.Dtos.ApiResponse;
using AdminWeb.Models;
using AdminWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace AdminWeb.Areas.Category.Controllers
{
    [Area("Category")]
    public class SalaryPeriodController : Controller
    {
        private readonly IApiService _apiService;

        public SalaryPeriodController(IApiService apiService)
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

        #region -- Methods --

        [HttpGet]
        public object GetSalaryPeriodList(DataSourceLoadOptions loadOptions)
        {
            var _response = SalaryPeriodList;

            return DataSourceLoader.Load(_response, loadOptions);
        }

        public static List<SalaryPeriodResponseModel> SalaryPeriodList = new List<SalaryPeriodResponseModel>()
        {

                 new SalaryPeriodResponseModel
                {
                    SalaryPeriodId = 1,
                    SalaryPeriodCode = "SLC05221",
                    SalaryPeriodType = "Full",
                    IsActive = true,
                    CreationDate = DateTime.Now,
                    CreatedBy = null,
                    LastUpdatedDate = DateTime.Now,
                    LastUpdatedBy = -1
                },
                 new SalaryPeriodResponseModel
                 {
                     SalaryPeriodId = 1,
                    SalaryPeriodCode = "SLC05241",
                    SalaryPeriodType = "Fresher",
                    IsActive = true,
                    CreationDate = DateTime.Now,
                    CreatedBy = null,
                    LastUpdatedDate = DateTime.Now,
                    LastUpdatedBy = -1
                 }
         
            #endregion
        };
    }
}
