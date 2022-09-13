using APEAM.Data;
using APEAM.Models;
using ExamenAPEAM.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace APEAM.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly APEAMContext _context;

        public HomeController(ILogger<HomeController> logger, APEAMContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.Productos = _context.Producto.ToList();
            ViewBag.Proveedores = _context.Proveedor.ToList();
            ViewBag.RegistroTransaccions = _context.RegistroTransaccion.ToList();
            ViewBag.TipoPago = _context.TipoPago.ToList();
            return View();
        }


        public IActionResult Privacy()
        {
            var transacciones = _context.RegistroTransaccion
                .Include(i => i.Producto)
                .Include(i => i.Proveedor)
                .Include(i => i.TipoPago);
            
            ViewBag.Transacciones = (from t in transacciones 
                                    select new { 
                                        t.Id,
                                        t.Fecha,
                                        t.Accion,
                                        t.Cantidad,
                                        t.CostoUnitario,
                                        t.Total,
                                        Producto = t.Producto.Name, 
                                        Proveedor = t.Proveedor.Name,
                                        TipoPago = t.TipoPago.Tipo
                                    }).ToList();

            return View(transacciones.ToList());
        }
        public IActionResult Producto()
        {
            return View();
        }
        public IActionResult Proveedor()
        {
            return View();
        }
        public IActionResult TipoPago()
        {
            return View();
        }
        public IActionResult ESProducto()
        {
            ViewBag.Productos = _context.Producto.ToList();
            ViewBag.Proveedores = _context.Proveedor.ToList();
            ViewBag.TipoPagos = _context.TipoPago.ToList();
            return View();
        }
        public IActionResult Imprimir()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}