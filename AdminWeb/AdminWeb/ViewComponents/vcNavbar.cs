using AdminWeb.Models.Menu;
using Microsoft.AspNetCore.Mvc;
using System.Security.Policy;
using System;

namespace AdminWeb.ViewComponents
{
    public class vcNavbar : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            ViewBag.SiteMap = await GetSiteMap();

            return View();
        }

        private async Task<IEnumerable<TreeMenuItem<SiteMapNode>>> GetSiteMap()
        {
            IEnumerable<TreeMenuItem<SiteMapNode>> siteMap = null;

            List<SiteMapNode> menus = null;

            menus = new List<SiteMapNode>()
                {
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "DanhMuc",
                        ICONCLASS = "glyphicon glyphicon-folder-close",
                        ID = 1,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 1,
                        PARENTID = null,
                        SYSTEMNAME = null,
                        URL = null,
                        URL_ = ""
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "CertiType",
                        ICONCLASS = "fa fa-caret-right",
                        ID = 2,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 1,
                        PARENTID = 1,
                        SYSTEMNAME = null,
                        URL = null,
                        URL_ =  "Category/CertiType"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "LoaiKhachHang",
                        ICONCLASS = "fa fa-caret-right",
                        ID = 2,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 1,
                        PARENTID = 1,
                        SYSTEMNAME = null,
                        URL = null,
                        URL_ = ""
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "ViTri",
                        ICONCLASS = "fa fa-caret-right",
                        ID = 3,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 2,
                        PARENTID = 1,
                        SYSTEMNAME = null,
                        URL = null,
                        URL_ = ""
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "DanhMucNganHang",
                        ICONCLASS = "fa fa-caret-right",
                        ID = 4,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 3,
                        PARENTID = 1,
                        SYSTEMNAME = null,
                        URL = null,
                        URL_ = ""
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "DanhSachLoaiSP",
                        ICONCLASS = "fa fa-caret-right",
                        ID = 5,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 4,
                        PARENTID = 1,
                        SYSTEMNAME = null,
                        URL = null,
                        URL_ = ""
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "TieuChiDanhGia",
                        ICONCLASS = "fa fa-caret-right",
                        ID = 6,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 5,
                        PARENTID = 1,
                        SYSTEMNAME = null,
                        URL = null,
                        URL_ = "Category/LST_CRITERIAS"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "QuanTriHeThong",
                        ICONCLASS = "glyphicon glyphicon-folder-close",
                        ID = 7,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 2,
                        PARENTID = null,
                        SYSTEMNAME = null,
                        URL = null,
                        URL_ = ""
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "NguoiDung",
                        ICONCLASS = "fa fa-caret-right",
                        ID = 8,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 1,
                        PARENTID = 7,
                        SYSTEMNAME = null,
                        URL = null,
                        URL_ = "Admin/Users"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "NhomNguoiDung",
                        ICONCLASS = "fa fa-caret-right",
                        ID = 9,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 2,
                        PARENTID = 7,
                        SYSTEMNAME = null,
                        URL = null,
                        URL_ = "Admin/Roles"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "QuanLyQuyen",
                        ICONCLASS = "fa fa-caret-right",
                        ID = 10,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 3,
                        PARENTID = 7,
                        SYSTEMNAME = null,
                        URL = null,
                        URL_ = "Admin/Permissions"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "CauHinh",
                        ICONCLASS = "fa fa-caret-right",
                        ID = 11,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 4,
                        PARENTID = 7,
                        SYSTEMNAME = null,
                        URL = null,
                        URL_ = "Admin/Settings"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "QuanLyMenu",
                        ICONCLASS = "fa fa-caret-right",
                        ID = 12,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 5,
                        PARENTID = 7,
                        SYSTEMNAME = null,
                        URL = null,
                        URL_ = "Admin/MenuManagement"
                    },
                    new SiteMapNode()
                    {
                        ACTIVE = false,
                        CONTENT = "Version Management",
                        ICONCLASS = "fa fa-caret-right",
                        ID = 13,
                        ISACTIVE = true,
                        ISDISPLAY = true,
                        ORDER = null,
                        ORDER_ = 2,
                        PARENTID = 7,
                        SYSTEMNAME = null,
                        URL = null,
                        URL_ = "Admin/Version"
                    },
                };

            if (menus != null && menus.Count > 0)
            {
                siteMap = menus.GenerateTreeMenu(c => c.ID, c => c.PARENTID, c => c.ORDER_);
            }

            return siteMap;
        }
    }
}
