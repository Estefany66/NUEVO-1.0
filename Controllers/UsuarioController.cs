using Microsoft.AspNetCore.Mvc;
using NUEVO_1._0.Models;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace NUEVO_1._0.Controllers
{
     public class UsuarioController : Controller
    {
       
        private readonly PeruContext _context;
        public UsuarioController(PeruContext context)
        {
           _context = context;
        }

        public IActionResult Registro(){
            ViewBag.Invitados = _context.Invitados.Select(x => new SelectListItem(x.Mensaje, x.Id .ToString()));
            return View();
        }

        [HttpPost]
        public IActionResult Registro(Usuario p){
            if(ModelState.IsValid){
                _context.Usuarios.Add(p);
                _context.SaveChanges();
                return RedirectToAction("Index", "Home");

            }else{
                return View(p);
            }
        }
    }
}