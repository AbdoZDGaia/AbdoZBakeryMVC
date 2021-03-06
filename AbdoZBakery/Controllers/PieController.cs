﻿using AbdoZBakery.Models.Interfaces;
using AbdoZBakery.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbdoZBakery.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PieController(IPieRepository pieRepository,ICategoryRepository categoryRepository)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List()
        {
            var piesListVM = new PiesListViewModel();
            piesListVM.PieList = _pieRepository.AllPies;
            piesListVM.CurrentCategory = "Cheese cakes";
            return View(piesListVM);
        }
    }
}
