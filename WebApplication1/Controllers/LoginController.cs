 using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Calpion.Artemis.Models;
using Calpion.Artemis.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Controllers;

namespace Calpion.Artemis.Web.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Title = "Login";
            return View();
        }

      
        [HttpPost]
        //[AllowAnonymous]
        //[ValidateAntiForgeryToken]
        public ActionResult DoLogin(LoginViewModel model, string returnUrl)
        {
            if (model.loginview.UserName == null || model.loginview.Password == null)
            {
                return RedirectToAction("Index", "Login");
                //return RedirectToRoute("Index");
            }
            string Uname = "mani";
            string pass = "mani123";
            if (ModelState.IsValid)
            {
                if (model.loginview.UserName.ToString() != Uname || model.loginview.Password.ToString() != pass)
                {
                    return RedirectToRoute("/Error");
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                    //return View("Views/Login/LoginHome.cshtml");
                
                }
            }
            //return View(model);
            return View();
        }


        [HttpPost]
        public ActionResult SendEmail(LoginViewModel model)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    var senderEmail = new MailAddress("nikithasri.b@gmail.com", "Artemis");
                    var receiverEmail = new MailAddress(model.forgotview.UserName, "Receiver");
                    var password = "nikki143";
                    var sub = "ForGot Password";
                    var body = "www.google.com";
                    var smtp = new SmtpClient
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential(senderEmail.Address, password)
                    };
                    using (var mess = new MailMessage(senderEmail, receiverEmail)
                    {
                        Subject = "ForGot Password",
                        Body = body
                    })
                    {
                        smtp.Send(mess);
                    }
                    return RedirectToAction("Index", "Login");

                }
            }

            catch (Exception ex)
            {
                ViewBag.Error = "Some Error";
            }
            return View();
        }


    }
}