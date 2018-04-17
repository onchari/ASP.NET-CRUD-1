using CRUD.DBEntities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Controllers
{
    public class CustomerController : Controller
    {
        private CRUDContext _context;

        public CustomerController(CRUDContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            IEnumerable<CustomerViewModel> model = _context.Set<Customer>().ToList().Select(s => new CustomerViewModel {
                Id =s.Id,
                Name = $"{s.FirstName} {s.LastName}",
                MobileNo = s.MobileNo,
                Email = s.Email

            });
            return View("Index", model);
        }

        [HttpGet]
        public IActionResult AddEditCustomer(long? id)
        {
            CustomerViewModel model = new CustomerViewModel();
            if (id.HasValue)
            {
                Customer customer = _context.Set<Customer>().SingleOrDefault(c => c.Id == id.Value);
                if(customer != null)
                {
                    model.Id = customer.Id;
                    model.FirstName = customer.FirstName;
                    model.LastName = customer.LastName;
                    model.MobileNo = customer.MobileNo;
                    model.Email = customer.Email;
                }
            }
        }
    }
}
