using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GXXD.Domain.Abstract;
using GXXD.Domain.Entities;
using GXXD.WebUI.Models;

namespace GXXD.WebUI.Controllers
{
    public class GrandController : Controller
    {
       private IProdustRepositiory repository;
        public int PageSize = 10;
        public GrandController(IProdustRepositiory GrandRepository)
        {
            this.repository = GrandRepository;
        }
        public ViewResult List(int page = 1)
        {
            GrandListViewModel model = new GrandListViewModel
            {
                Grands = repository.Grands.OrderBy(p => p.Id).Skip((page - 1) * PageSize).Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    ToTalItems = repository.Grands.Count()
                }
            };
            return View(model);

        }
    }
}