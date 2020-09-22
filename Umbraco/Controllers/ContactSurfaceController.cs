using Umbraco.Web.Mvc;
using System.Web.Mvc;
using Umbraco.Web.Actions;
using Umbraco.Models;
using System.Net.Mail;

namespace Umbraco.Controllers
{
    public class ContactSurfaceController : SurfaceController
    {

        public ActionResult SubmitContact(ContactModel model)
        {
            if (ModelState.IsValid)
            {
                this.SendEmail(model);
                return RedirectToCurrentUmbracoPage();
            }
            return CurrentUmbracoPage();
        }

        private void SendEmail(ContactModel model)
        {
            string to = "willy.everton.s.nascimento@gmail.com";
            //string to = "hit@hitdigital.com.br";

            MailMessage message = new MailMessage(model.email, to);
            message.Subject = model.name + " - " + model.email;
            message.Body = model.message;

            SmtpClient client = new SmtpClient("172.0.0.1", 25);
            client.Send(message);
        }
    }
}