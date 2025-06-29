using Microsoft.AspNetCore.Mvc;
using MiniCore_Comision.Models;
using System.Linq;

namespace MiniCore_Comision.Controllers
{
    public class ComisionesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ComisionesController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var resumen = _context.Vendedores
                .Select(v => new ResumenComisionViewModel
                {
                    NombreVendedor = v.Nombre,
                    TotalVentas = v.Ventas.Sum(venta => venta.Monto),
                    PorcentajeComision = 0.10m // 10%
                })
                .ToList();

            return View(resumen);
        }
    }
}

