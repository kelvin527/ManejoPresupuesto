using ManejoPresupuesto.Models;
using Microsoft.AspNetCore.Mvc;

namespace ManejoPresupuesto.Controllers
{
    public class TiposCuentasController:Controller
    {
        [HttpGet("api/get")]
        public IActionResult Crear()
        {
            return View("kelvin");
        }

        [HttpPost("PRI")]
        public IActionResult Crear(TiposCuentas tiposCuentas)
        {
            return View();
        }
    }

}
