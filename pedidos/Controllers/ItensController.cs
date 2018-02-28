using pedidos.Contexto;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pedidos.Controllers
{
    public class ItensController : Controller
    {
        private DBContext db = new DBContext();

        // GET: Itens
        public ActionResult ListarItens(int id)
        {
            var lista = db.Itens.Where(m => m.Pedido.id == id);
            ViewBag.Pedido = id;
            return View(lista);
        }
    }
}