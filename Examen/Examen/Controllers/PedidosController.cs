using System.Data;
using Examen.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Examen.Controllers
{
    public class PedidosController : Controller
    {

        public Contexto contexto { get; }

        public PedidosController(Contexto contexto)
        {
            this.contexto = contexto;
        }



        // GET: PedidosController
        public ActionResult Index()
        {
            var lista = contexto.Pedidos.ToList();
            return View(lista);
        }

        // GET: PedidosController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PedidosController/Create
        public ActionResult Create()
        {
            //ViewBag.LosProveedores = contexto.Proveedores.ToList();
            //ViewBag.ProveedoresProductos = new MultiSelectList(contexto.Productos, "ID", "nomProducto");
            return View();
        }

        // POST: PedidosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PedidosController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PedidosController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PedidosController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PedidosController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
