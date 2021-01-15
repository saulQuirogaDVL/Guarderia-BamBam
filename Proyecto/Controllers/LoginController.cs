using Proyecto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Inicio()
        {
            return View();
        }

        public ActionResult Validar()
        {
            String cuenta = Request.Params.Get("cuenta");
            String pass = Request.Params.Get("pass");
            String tipo = Request.Params.Get("tipo");
            Login login = new Login(cuenta,pass,tipo);
            if (login.crear_Sesion())
            {
                Session.Add("autorizacion", tipo);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("Inicio", "Login");
            }
        }
        public ActionResult Salir()
        {
            Session.Remove("autorizacion");
            return RedirectToAction("Index", "Home");
        }
    }
}