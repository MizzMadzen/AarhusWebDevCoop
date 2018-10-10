using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;
using Umbraco.Core.Models;
using AarhusWebDevCoop.ViewModels;

namespace AarhusWebDevCoop.Controllers
{
    public class MessageFormSurfaceController : SurfaceController
    {
        // GET: MessageFormSurface
        public ActionResult Index() {
            return PartialView("MessageForm", new MessageForm());
        }

        [HttpPost]
        public ActionResult HandleFormSubmit(MessageForm message) {
           if (!ModelState.IsValid) { return CurrentUmbracoPage(); }

            // Insert the data in the Umbraco System
            // Parameters: The "headline" on the list in backend office, the node the list
            // should be shown and the Document Type that the message should be inserted into
            IContent userMessage = Services.ContentService.CreateContent(message.mesTitle, CurrentPage.Id, "Message");
            userMessage.SetValue("mName", message.mesName);
            userMessage.SetValue("mEmail", message.mesEmail);
            userMessage.SetValue("mTitle", message.mesTitle);
            userMessage.SetValue("mMessage", message.mesMessage);
            Services.ContentService.Save(userMessage); // only saving, but does not publish it

            TempData["success"] = true;

            return RedirectToCurrentUmbracoPage();
        }
    }
}