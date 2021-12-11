using AppCore_DomainModel.Interfaces;
using AppCore_DomainModel.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace appCore.Controllers
{
    public class EmployeesController : Controller
    {
        //private readonly IBaseRepository<Employee> _employeeRepository;
        private readonly IUnitOfWork _unitOfWork;
        public EmployeesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult FindEmployee()
        {
            var emp = _unitOfWork.Employees.FindAll(e => e.Name.StartsWith("b") || e.Name.StartsWith("q"));
            return View("Index", emp.ToList());
        }

        public IActionResult Index()
        {
            return View(_unitOfWork.Employees.GetAll());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee model)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Employees.Add(model);
                _unitOfWork.Complete();
                return RedirectToAction(nameof(Index));
            }

            return View(model);
        }
    }
}
