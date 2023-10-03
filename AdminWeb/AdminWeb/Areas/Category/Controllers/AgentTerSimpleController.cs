using AdminWeb.Dtos.ApiResponse;
using AdminWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AdminWeb.Areas.Category.Controllers
{
    [Area("Category")]
    public class AgentTerSimpleController : Controller
    {
        private readonly IApiService _apiService;

        public AgentTerSimpleController(IApiService apiService)
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
        public object GetAgentTerSimpleList(DataSourceLoadOptions loadOptions)
        {
            var _response = getAgentTerSimpleList;

            return DataSourceLoader.Load(_response, loadOptions);
        }

        public static List<AgentTerSimpleResponseModel> getAgentTerSimpleList = new List<AgentTerSimpleResponseModel>()
        {
            new AgentTerSimpleResponseModel
            {
                AgentTerSimpleId = 1,
                RequestCode = "CRAT22_000001",
                AgentCode = "91810988",
                UnitName = "NGUYỄN THỊ THÚY NGA",
                PositionName = "Senior District Manager",
                DistrictName = "HCM 107",
                RegionName = "GA HO CHI MINH 1",
                PositionApply = "FC",
                RequestDate = DateTime.Now,
                Reason = "Vì lý do cá nhân",
                Status = "Đang chờ phê duyệt"
            },
        };

    }
}
