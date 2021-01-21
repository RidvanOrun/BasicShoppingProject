using CMSSolution.Data.Repositories.Interface.EntityRepository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMSSolution.Web.Controllers
{
    public class PageController : Controller
    {
        private readonly IPageRepository _pageRepository;

        public PageController(IPageRepository pageRepository) => _pageRepository = pageRepository;

        public async Task<IActionResult> Page(string slug) => View(await _pageRepository.FirstOrDefault(x => x.Slug == slug));
    }
}
