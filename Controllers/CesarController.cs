using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VigenereWeb.Models;
using VigenereWeb.Services;

namespace CesarWeb.Controllers
{
    public class CesarController : Controller
    {
        private ISeguridadService<string> _seguridadService;

        public CesarController(ISeguridadService<string> VigenereSeguridadService)
        {
            _seguridadService = VigenereSeguridadService;
        }

        
        [HttpPost]
        public IActionResult Encriptar(CesarViewModel mensajeAEncriptar)
        {
            mensajeAEncriptar.Mensaje = _seguridadService.Encriptar(mensajeAEncriptar.Mensaje, mensajeAEncriptar.Clave);
            return View(mensajeAEncriptar);
        }

        [HttpPost]
        public IActionResult Desencriptar(CesarViewModel mensajeADesencriptar)
        {
            mensajeADesencriptar.Mensaje = _seguridadService.DesEncriptar(mensajeADesencriptar.Mensaje, mensajeADesencriptar.Clave);
            return View(mensajeADesencriptar);
        }


    }
}
