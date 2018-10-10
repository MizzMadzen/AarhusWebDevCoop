using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;
using Umbraco.Core.Models;
using AarhusWebDevCoop.ViewModels;
using System.Net.Mail;

namespace AarhusWebDevCoop.Controllers
{
    public class ContactFormSurfaceController : SurfaceController
    {
        // GET: ContactFormSurface
        public ActionResult Index() {
            return PartialView("ContactForm", new ContactForm());
        }

        [HttpPost]
        public ActionResult HandleFormSubmit(ContactForm contact) {
            if (!ModelState.IsValid) { return CurrentUmbracoPage(); }

            // Insert the data in the Umbraco System - The string names in setvalues are the
            // aliases from the Comment document type properties
            IContent comment = Services.ContentService.CreateContent(contact.Subject, CurrentPage.Id, "comment");
            comment.SetValue("cName", contact.Name);
            comment.SetValue("cEmail", contact.Email);
            comment.SetValue("cSubject", contact.Subject);
            comment.SetValue("cMessage", contact.Message);
            Services.ContentService.Save(comment); // Saving


            // Create an email to be sent to the editor (Currently deactivated)
            MailMessage message = new MailMessage();
            message.To.Add("eaamamad14@gmail.com");
            message.Subject = contact.Subject;
            message.From = new MailAddress(contact.Email, contact.Name);
            message.Body = contact.Message + "\n my email is: " + contact.Email;

            using (SmtpClient smtp = new SmtpClient()) {
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.UseDefaultCredentials = false;
                smtp.EnableSsl = true;
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.Credentials = new System.Net.NetworkCredential("eaamamad14@gmail.com", "testingApps");
                smtp.EnableSsl = true;

                // Send Mail
                TempData["success"] = true;
                //smtp.Send(message);
            }

            return RedirectToCurrentUmbracoPage();
        }
    }
}