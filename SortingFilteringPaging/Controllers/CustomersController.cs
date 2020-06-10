using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SortingFilteringPaging.Data;
using SortingFilteringPaging.Models;
using System.Linq.Dynamic.Core;

namespace SortingFilteringPaging.Controllers
{
    public class CustomersController : Controller
    {
        private readonly SortingFilteringPagingContext _context;

        public CustomersController(SortingFilteringPagingContext context)
        {
            _context = context;
        }

        // GET: Customers
        public async Task<IActionResult> Index(string SearchString,int Page, string Paging, string Sorting, int ItemsInPage = 25, int SkipValue = 0 )
        {

            //SeedData sd = new SeedData();
            //_context.AddRange(sd.GeneratedCustomers(100259));
            //_context.SaveChanges();
            

            int skip = SkipValue;
            int totalRecords = _context.Customer.Count(); // get the number of all the records
            bool isItLastPage = false;
            bool isItFirstPage = false;

            if (!String.IsNullOrEmpty(Paging))
            {              
                    if (Paging == "Next")
                    {
                        skip = skip + ItemsInPage;
                    }
                    if (Paging == "Previous")
                    {
                        if (skip - ItemsInPage >= 0)
                        {
                            skip = skip - ItemsInPage;
                        }

                    }                     
            }


            if (Page != 0)
            {
                Page = Page - 1;
                skip = Page * ItemsInPage;
            }



            List<Customer> customers = new List<Customer>(); // create new list of customers          

            if (!String.IsNullOrEmpty(SearchString))
            {
                if (!String.IsNullOrEmpty(Sorting))
                {
                    customers = _context.Customer.Where(x =>
                    x.FirstName.ToLower().Contains(SearchString.ToLower()) ||
                    x.LastName.ToLower().Contains(SearchString.ToLower()) ||
                   x.MaleFemale.ToLower().Contains(SearchString.ToLower()) ||
                   x.Age.ToString().ToLower().Contains(SearchString.ToLower()) ||
                   x.PhoneNumber.ToLower().Contains(SearchString.ToLower()) ||
                   x.EmailAddress.ToLower().Contains(SearchString.ToLower()) ||
                   x.City.ToLower().Contains(SearchString.ToLower()) ||
                   x.Street.ToLower().Contains(SearchString.ToLower()) ||
                   x.HouseNr.ToLower().Contains(SearchString.ToLower())).OrderBy(Sorting)
                   .Skip(skip).Take(ItemsInPage).ToList();


                }
                else
                {
                    customers = _context.Customer.Where(x =>
                    x.FirstName.ToLower().Contains(SearchString.ToLower()) ||
                    x.LastName.ToLower().Contains(SearchString.ToLower()) ||
                    x.MaleFemale.ToLower().Contains(SearchString.ToLower()) ||
                    x.Age.ToString().ToLower().Contains(SearchString.ToLower()) ||
                    x.PhoneNumber.ToLower().Contains(SearchString.ToLower()) ||
                    x.EmailAddress.ToLower().Contains(SearchString.ToLower()) ||
                    x.City.ToLower().Contains(SearchString.ToLower()) ||
                    x.Street.ToLower().Contains(SearchString.ToLower()) ||
                    x.HouseNr.ToLower().Contains(SearchString.ToLower()))
                    .Skip(skip).Take(ItemsInPage).ToList();

                }

                 totalRecords = _context.Customer.Where(x =>          // number of customers matching the search string
                    x.FirstName.ToLower().Contains(SearchString.ToLower()) ||
                    x.LastName.ToLower().Contains(SearchString.ToLower()) ||
                    x.MaleFemale.ToLower().Contains(SearchString.ToLower()) ||
                    x.Age.ToString().ToLower().Contains(SearchString.ToLower()) ||
                    x.PhoneNumber.ToLower().Contains(SearchString.ToLower()) ||
                    x.EmailAddress.ToLower().Contains(SearchString.ToLower()) ||
                    x.City.ToLower().Contains(SearchString.ToLower()) ||
                    x.Street.ToLower().Contains(SearchString.ToLower()) ||
                    x.HouseNr.ToLower().Contains(SearchString.ToLower())).Count();

            }
            else
            {
                if (!String.IsNullOrEmpty(Sorting))
                {
                    customers = _context.Customer.OrderBy(Sorting)
                   .Skip(skip).Take(ItemsInPage).ToList();

                }
                else
                {
                    customers = _context.Customer.Skip(skip).Take(ItemsInPage).ToList(); // takes first 20 records 
                }

                
            }

            isItLastPage = totalRecords <= ItemsInPage + skip ;
            isItFirstPage = skip == 0;

            CustomerViewModel cvm = new CustomerViewModel()
            {
                SkipValue = skip,
                ItemsPerPage = ItemsInPage,
                SearchString = SearchString,
                Sorting = Sorting,
                AllRecords = totalRecords,
                Customers = customers,
                LastPage = isItLastPage,
                FirsPage = isItFirstPage
            };

            //ViewBag.SkipValue = skip; // sends current skipped pages number
            //ViewBag.ItemsPerPage = ItemsInPage; // sends items per page to view 
            //ViewBag.SearchString = SearchString; // sends searchstring to view 
            //ViewBag.sorting = Sorting;
            //ViewBag.allRecords = totalRecords;

            return View(cvm);
        }

        // GET: Customers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customer
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // GET: Customers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Customers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,MaleFemale,Age,PhoneNumber,EmailAddress,City,Street,HouseNr")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(customer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(customer);
        }

        // GET: Customers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customer.FindAsync(id);
            if (customer == null)
            {
                return NotFound();
            }
            return View(customer);
        }

        // POST: Customers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,MaleFemale,Age,PhoneNumber,EmailAddress,City,Street,HouseNr")] Customer customer)
        {
            if (id != customer.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerExists(customer.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(customer);
        }

        // GET: Customers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customer
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // POST: Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var customer = await _context.Customer.FindAsync(id);
            _context.Customer.Remove(customer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustomerExists(int id)
        {
            return _context.Customer.Any(e => e.Id == id);
        }
    }
}
