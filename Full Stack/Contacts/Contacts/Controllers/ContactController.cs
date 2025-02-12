using Contacts.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Contacts.Controllers
{
    public class ContactController : Controller
    {
        private ContactContext context { get; set; }
        public ContactController(ContactContext ctx)
        {
            context = ctx;
        }
        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            ViewBag.Categories = context.Categories.ToList();
            return View("Edit", new Contact());
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            ViewBag.Action = id == null ? "Add" : "Edit"; // Set action type based on whether ID is null (Add) or not (Edit)

            // Populate the categories for the dropdown
            ViewBag.Categories = context.Categories.ToList();

            if (id == null)
            {
                // If there's no ID, we are adding a new contact
                return View(new Contact());
            }
            else
            {
                // If there's an ID, we are editing an existing contact
                var contact = context.Contacts.Include(c => c.Category).FirstOrDefault(c => c.ContactId == id);
                if (contact == null)
                {
                    return NotFound();
                }
                return View(contact);
            }
        }
        [HttpPost]
        public IActionResult Add(Contact contact)
        {
            if (ModelState.IsValid)
            {
                contact.DateAdded = DateTime.Now; // Set the current date and time
                context.Contacts.Add(contact);
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }

            ViewBag.Action = "Add";
            return View("Edit", contact);
        }

        [HttpPost]
        public IActionResult Edit(Contact contact)
        {
            if (ModelState.IsValid)
            {
                if (contact.ContactId == 0)  // Adding a new contact
                {
                    contact.DateAdded = DateTime.Now; // Only for new contacts
                    context.Contacts.Add(contact);
                }
                else  // Editing an existing contact
                {
                    var existingContact = context.Contacts.Find(contact.ContactId);
                    if (existingContact != null)
                    {
                        contact.DateAdded = existingContact.DateAdded; // Keep the original date
                        context.Entry(existingContact).CurrentValues.SetValues(contact);
                    }
                }
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                // If the model state is not valid, we want to show the form again with errors
                ViewBag.Action = (contact.ContactId == 0) ? "Add" : "Edit";
                ViewBag.Categories = context.Categories.OrderBy(c => c.Name).ToList();
                return View(contact);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var contact = context.Contacts.Find(id);
            return View(contact);
        }
        [HttpPost]
        public IActionResult Delete(Contact contact)
        {
            context.Contacts.Remove(contact);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        // Details action to fetch and display a contact
        public IActionResult Details(int id)
        {
            var contact = context.Contacts
                                  .Include(c => c.Category)  // Include Category to show its name
                                  .FirstOrDefault(c => c.ContactId == id);

            if (contact == null)
            {
                return NotFound();  // Return a 404 if the contact is not found
            }

            return View(contact);  // Pass the contact to the Details view

        }
    }
}
