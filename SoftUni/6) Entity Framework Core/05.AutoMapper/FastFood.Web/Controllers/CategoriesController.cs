﻿namespace FastFood.Web.Controllers
{
    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using FastFood.Data;
    using FastFood.Models;
    using Microsoft.AspNetCore.Mvc;
    using System.Linq;
    using ViewModels.Categories;

    public class CategoriesController : Controller
    {
        private readonly FastFoodContext context;
        private readonly IMapper mapper;

        public CategoriesController(FastFoodContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Create(CreateCategoryInputModel model)
        {
            if (!ModelState.IsValid)
            {
                return this.RedirectToAction("Error", "Home");
            }

            var categories = this.mapper.Map<Category>(model);

            this.context.Categories.Add(categories);

            this.context.SaveChanges();

            return this.RedirectToAction("All", "Categories");
        }

        public IActionResult All()
        {
            var categories = this.context.Categories
                .ProjectTo<CategoryAllViewModel>(this.mapper.ConfigurationProvider)
                .ToList();

            return this.View(categories);
        }
    }
}
