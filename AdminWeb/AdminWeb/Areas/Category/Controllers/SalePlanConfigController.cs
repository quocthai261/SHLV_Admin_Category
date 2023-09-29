using AdminWeb.Dtos.ApiResponse;
using AdminWeb.Models;
using AdminWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace AdminWeb.Areas.Category.Controllers
{
    [Area("Category")]
    public class SalePlanConfigController : Controller
    {
        private readonly IApiService _apiService;

        public SalePlanConfigController(IApiService apiService)
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
        public object GetSalePlanConfigList(DataSourceLoadOptions loadOptions)
        {
            var _response = salePlanConfig;

            return DataSourceLoader.Load(_response, loadOptions);
        }

        public static List<SalePlanConfigResponseModel> salePlanConfig = new List<SalePlanConfigResponseModel>()
        {
            new SalePlanConfigResponseModel {
                        SalePlanConfigId = 1,
                        PositionCode = "03",
                        AllowCreateDay = 27,
                        AllowEditDay = 29,
                        PlanType = 2,
                        IsActive = true,
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
            },
            new SalePlanConfigResponseModel {
                        SalePlanConfigId = 2,
                        PositionCode = "FC",
                        AllowCreateDay = 15,
                        AllowEditDay = 17,
                        PlanType = 1,
                        IsActive = true,
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
            new SalePlanConfigResponseModel {
                        SalePlanConfigId = 3,
                        PositionCode = "DM",
                        AllowCreateDay = 27,
                        AllowEditDay = 29,
                        PlanType = 2,
                        IsActive = true,
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
            new SalePlanConfigResponseModel {
                        SalePlanConfigId = 4,
                        PositionCode = "UM",
                        AllowCreateDay = 27,
                        AllowEditDay = 29,
                        PlanType = 2,
                        IsActive = true,
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
            new SalePlanConfigResponseModel {
                        SalePlanConfigId = 5,
                        PositionCode = "SrUM",
                        AllowCreateDay = 27,
                        AllowEditDay = 29,
                        PlanType = 2,
                        IsActive = true,
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
            new SalePlanConfigResponseModel {
                        SalePlanConfigId = 6,
                        PositionCode = "SDM",
                        AllowCreateDay = 27,
                        AllowEditDay = 29,
                        PlanType = 2,
                        IsActive = true,
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
            new SalePlanConfigResponseModel {
                        SalePlanConfigId = 7,
                        PositionCode = "SrDM",
                        AllowCreateDay = 27,
                        AllowEditDay = 29,
                        PlanType = 2,
                        IsActive = true,
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
            new SalePlanConfigResponseModel {
                        SalePlanConfigId = 7,
                        PositionCode = "SA",
                        AllowCreateDay = 27,
                        AllowEditDay = 29,
                        PlanType = 2,
                        IsActive = true,
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
            new SalePlanConfigResponseModel {
                        SalePlanConfigId = 9,
                        PositionCode = "RM",
                        AllowCreateDay = 27,
                        AllowEditDay = 29,
                        PlanType = 2,
                        IsActive = true,
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },  
        };

        #endregion
    }
}
