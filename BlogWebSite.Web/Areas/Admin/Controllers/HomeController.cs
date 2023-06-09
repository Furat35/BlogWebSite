﻿using BlogWebSite.Core.Const;
using BlogWebSite.Service.Services.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BlogWebSite.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = $"{RoleConst.SuperAdmin},{RoleConst.Admin}")]
    public class HomeController : Controller
    {
        #region Fields
        private readonly IArticleService _articleService;
        private readonly IDashboardService _dashboardService;
        #endregion

        #region Ctor
        public HomeController(IArticleService articleService, IDashboardService dashboardService)
        {
            _articleService = articleService;
            _dashboardService = dashboardService;
        }
        #endregion

        public async Task<IActionResult> Index()
        {
            var articles = await _articleService
                .GetAllArticlesWithCategoryNonDeletedAsync();
            var result = await _dashboardService
                .GetYearlyArticleCountsAsync();

            return View(articles);
        }

        public async Task<IActionResult> YearlyArticleCount()
        {
            var count = await _dashboardService
                .GetYearlyArticleCountsAsync();
            return Json(JsonConvert.SerializeObject(count));
        }

        public async Task<IActionResult> TotalArticleCount()
        {
            var articleCount = await _dashboardService
                .GetTotalArticleCountAsync(_ => !_.isDeleted);
            return Json(articleCount);
        }

        public async Task<IActionResult> TotalCategoryCount()
        {
            var categoryCount = await _dashboardService
                .GetTotalCategoryCountAsync(_ => !_.isDeleted);
            return Json(categoryCount);
        }

        public async Task<IActionResult> TotalUserCount()
        {
            var userCount = await _dashboardService
                .GetAllUsersAsync();
            return Json(userCount);
        }

        public async Task<IActionResult> ActiveUserCount()
        {
            var userCount = await _dashboardService
                .GetAllUsersAsync(_ => !_.IsDeleted);
            return Json(userCount);
        }
    }
}
