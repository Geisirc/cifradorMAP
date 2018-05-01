using Criptografia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Criptografia.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Sobre()
        {
            ViewBag.Titulo = "Cripto - Aplicativo de (des)criptografia.";

            return View();
        }


        // GET: Home/Criptografia
        public ActionResult Criptografia()
        {
            return View();
        }


        // GET: Home/Criptografia/texto
        public ActionResult CriptografiaTexto(string texto)
        {
            ViewBag.textoOriginal = texto;
            return View();
        }

        // POST: Home/Criptografia
        [HttpPost]
        public ActionResult Criptografia([Bind(Include ="textoOriginal, chave")] Cifra cifra)
        {
            try
            {
                if (cifra.Validado())
                {
                    ViewBag.textoOriginal = cifra.textoOriginal;
                    ViewBag.textoChave = cifra.chave;
                    ViewBag.textoCifrado = cifra.textoCifrado;

                }
                return View();
            }
            catch (Exception e)
            {
                ViewBag.textoOriginal = cifra.textoOriginal;
                ViewBag.textoChave = cifra.chave;
                ViewBag.textoErro = e.Message;

                return View();
            }
        }


        // GET: Home/Descriptografia
        public ActionResult Descriptografia(string texto)
        {
            if (texto != "")
            {
                ViewBag.textoOriginal = texto;
            }

            return View();
        }

        // POST: Home/Descriptografia
        [HttpPost]
        public ActionResult Descriptografia([Bind(Include = "textoCifrado,chave")] Decifra decifra)
        {
            try
            {
                if (decifra.Validado())
                {
                    ViewBag.textoCifrado = decifra.textoCifrado;
                    ViewBag.textoChave = decifra.chave;
                    ViewBag.textoDecifrado = decifra.textoOriginal;
                }
                return View();
            }
            catch (Exception e)
            {
                ViewBag.textoCifrado = decifra.textoCifrado;
                ViewBag.textoChave = decifra.chave;
                ViewBag.textoErro = e.Message;

                return View();
            }
        }


    }
}
