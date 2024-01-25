using FinalExamLumia.DAL;
using FinalExamLumia.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinalExamLumia.Conrollers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            List<Employee> employees=await _context.Employees.ToListAsync();
            return View(employees);
        }
    }
}
