﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BookShoppingCartMvcUI.Controllers
{
    [Authorize(Roles=nameof(Roles.Admin))]
   
    public class ReportsController : Controller
    {
        private readonly IReportRepository _reportRepository;

        public ReportsController(IReportRepository reportRepository)
        {
            _reportRepository = reportRepository;
        }

        public async Task<IActionResult> TopFiveSellingBooks(
            DateTime? sDate = null, DateTime? eDate = null)
        {
            try
            {
                DateTime startDate = sDate ?? DateTime.UtcNow.AddDays(-7);
                DateTime endDate = eDate ?? DateTime.UtcNow;
                var topFiveSellingBooks = await _reportRepository.GetTopNSellingBooksByDate(startDate, endDate);
                var vm = new TopNSoldBooksVm(startDate, endDate, topFiveSellingBooks);


                return View(vm);
            }
            catch (Exception ex) 
            {
                TempData["errorMessage"] = "Someting went wrong";
                return RedirectToAction("Index", "Home");   
            }



        }
    }
}
