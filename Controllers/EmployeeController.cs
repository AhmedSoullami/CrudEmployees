using GestionDesEmployees.Models;
using GestionDesEmployees.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GestionDesEmployees.Controllers
{
    public class EmployeeController : Controller

    {
        private readonly IEmployes _employes;
        public EmployeeController(IEmployes employes)
        {
            _employes = employes;
        }
        // GET: EmployeeController
        public ActionResult Index()
        {
            var employees=_employes.GetEmployees();
            return View(employees);
        }

        // GET: EmployeeController/Details/5
        public ActionResult Details(int id)
        {
            var emp=_employes.Detail(id);
            return View(emp);
        }

        // GET: EmployeeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee employee)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    
                    _employes.AddEmployee(employee);

                    
                    return RedirectToAction(nameof(Index));
                }

                return View(employee);
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EmployeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeController/Delete/5
      
       

        // POST: EmployeeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            
                _employes.DeleteEmployee(id);
                return RedirectToAction(nameof(Index));
            }

        }
    }
