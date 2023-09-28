using AdminWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AdminWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PermissionsController : Controller
    {
        private readonly IApiService _apiService;

        public PermissionsController(IApiService apiService)
        {
            _apiService = apiService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        //[HlvValidateAntiForgeryToken]
        public async Task<ActionResult> Insert(string values)
        {
            try
            {
                

                return Ok();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut]
        public async Task<ActionResult> Update(int key, string values)
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete]
        public async Task<ActionResult> Delete(int key)
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        public object GetPermissionsListApi(DataSourceLoadOptions loadOptions)
        {
            var _response = _apiService.GetPermissionListApi().Result;

            return DataSourceLoader.Load(_response, loadOptions);
        }
    }
}
