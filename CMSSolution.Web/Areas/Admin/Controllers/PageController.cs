﻿using CMSSolution.Data.Repositories.Interface.EntityRepository;
using CMSSolution.Entity.Entities.Concrete;
using CMSSolution.Entity.Enums;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMSSolution.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PageController : Controller
    {
        private readonly IPageRepository _repo;

        public PageController(IPageRepository pageRepository) => _repo = pageRepository;

        public async Task<IActionResult> List() => View(await _repo.Get(x => x.Status != Entity.Enums.Status.Passive));

        public IActionResult Create() => View();
        [HttpPost]
        public async Task<IActionResult> Create(Page page)
        {
            if (ModelState.IsValid)
            { //Aşağıdaki Slug kullanıcıya göstermek istemediğimiz url uzantıları için kullanılır. Temel olarak Slug , sitenizdeki URL’lerin, sitenizdeki her bir sayfayı tanımlayan bölümüdür.
                page.Slug = page.Title.ToLower().Replace(" ", "-");
                var slug = await _repo.FirstOrDefault(x => x.Slug == page.Slug); //Database de böyle bir slug var mı?
                if (slug != null)
                {
                    ModelState.AddModelError("", "There is already a page..!");
                    return View(page);
                }

                await _repo.Add(page);
                TempData["Success"] = "The page added..!";
                return RedirectToAction("List");
            }

            else
            {
                TempData["Error"] = "The page hasn't been added..!";
                return RedirectToAction("List");
            }
        }


        public async Task<IActionResult> Edit(int id) => View(await _repo.GetById(id));

        [HttpPost]
        public async Task<IActionResult> Edit(Page page)
        {
            if (ModelState.IsValid)
            {
                page.Slug = page.Title.ToLower().Replace(" ", "-");
                var slug = await _repo.FirstOrDefault(x => x.Slug == page.Slug);
                if (slug != null)
                {
                    ModelState.AddModelError("", "There is already a page..!");
                    TempData["Warning"] = "The page  is already exsist..!";
                    return View(page);
                }
                else
                {
                    page.UpdateDate = DateTime.Now;
                    page.Status = Status.Modified;
                    await _repo.Update(page);
                    TempData["Success"] = "The page has been edited..!";
                    return RedirectToAction("List");
                }
            }
            else
            {
                TempData["Error"] = "The page hasn't been edited..!";
                return View(page);
            }
        }

        public async Task<IActionResult> Remove(int id)
        {
            Page page = await _repo.GetById(id);
            if (page != null)
            {
                await _repo.Delete(page);
                TempData["Success"] = "The page deleted..!";
                return RedirectToAction("List");
            }
            else
            {
                TempData["Error"] = "The page hasn't been deleted..!";
                return RedirectToAction("List");
            }


        }




    }
}
