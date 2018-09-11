using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EC_Repuetos_v2.Models;

namespace EC_Repuetos_v2.Controllers
{
    public class EC_COMPRASController : Controller
    {

        private DB_PROYECTO_WEBEntities db = new DB_PROYECTO_WEBEntities();

        // GET: EC_COMPRAS
        public ActionResult Index()
        {
            var user = (EC_Repuetos_v2.Models.EC_USUARIOS)Session["usuarios"]; 
            string temp = user.EC_USUARIOS_ID.ToString();
            if (!string.IsNullOrEmpty(temp))
            {
                var compras = from d in db.EC_COMPRAS select d;
                compras  = compras.Where(s => s.EC_COMPRAS_USUARIOS.Equals(temp));
                return View(compras);
            }
            return View(db.EC_PRODUCTOS.ToList());
        }

        // GET: EC_COMPRAS/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EC_COMPRAS eC_COMPRAS = db.EC_COMPRAS.Find(id);
            if (eC_COMPRAS == null)
            {
                return HttpNotFound();
            }
            return View(eC_COMPRAS);
        }

        // GET: EC_COMPRAS/Create
        public ActionResult Create()
        {
            ViewBag.EC_COMPRAS_PRODUCTOS = new SelectList(db.EC_PRODUCTOS, "EC_PRODUCTO_ID", "EC_PRODUCTO_NOMBRE");
            ViewBag.EC_COMPRAS_USUARIOS = new SelectList(db.EC_USUARIOS, "EC_USUARIOS_ID", "EC_USUARIOS_CEDULA");
            return View();
        }

        // POST: EC_COMPRAS/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EC_COMPRAS_ID,EC_COMPRAS_USUARIOS,EC_COMPRAS_FECHA,EC_COMPRAS_CANTIDAD,EC_COMPRAS_PRODUCTOS,EC_COMPRAS_IMPUESTO,EC_COMPRAS_SUBTOTAL,EC_COMPRAS_TOTAL,EC_COMPRAS_PAGO")] EC_COMPRAS eC_COMPRAS)
        {
            var user = (EC_Repuetos_v2.Models.EC_USUARIOS)Session["usuarios"];
            if (ModelState.IsValid)
            {
                db.EC_COMPRAS.Add(eC_COMPRAS);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EC_COMPRAS_PRODUCTOS = new SelectList(db.EC_PRODUCTOS, "EC_PRODUCTO_ID", "EC_PRODUCTO_NOMBRE", eC_COMPRAS.EC_COMPRAS_PRODUCTOS);
            ViewBag.EC_COMPRAS_USUARIOS = user;
            return View(eC_COMPRAS);
        }

        // GET: EC_COMPRAS/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EC_COMPRAS eC_COMPRAS = db.EC_COMPRAS.Find(id);
            if (eC_COMPRAS == null)
            {
                return HttpNotFound();
            }
            ViewBag.EC_COMPRAS_PRODUCTOS = new SelectList(db.EC_PRODUCTOS, "EC_PRODUCTO_ID", "EC_PRODUCTO_NOMBRE", eC_COMPRAS.EC_COMPRAS_PRODUCTOS);
            ViewBag.EC_COMPRAS_USUARIOS = new SelectList(db.EC_USUARIOS, "EC_USUARIOS_ID", "EC_USUARIOS_CEDULA", eC_COMPRAS.EC_COMPRAS_USUARIOS);
            return View(eC_COMPRAS);
        }

        // POST: EC_COMPRAS/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EC_COMPRAS_ID,EC_COMPRAS_USUARIOS,EC_COMPRAS_FECHA,EC_COMPRAS_CANTIDAD,EC_COMPRAS_PRODUCTOS,EC_COMPRAS_IMPUESTO,EC_COMPRAS_SUBTOTAL,EC_COMPRAS_TOTAL,EC_COMPRAS_PAGO")] EC_COMPRAS eC_COMPRAS)
        {
            if (ModelState.IsValid)
            {
                db.Entry(eC_COMPRAS).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EC_COMPRAS_PRODUCTOS = new SelectList(db.EC_PRODUCTOS, "EC_PRODUCTO_ID", "EC_PRODUCTO_NOMBRE", eC_COMPRAS.EC_COMPRAS_PRODUCTOS);
            ViewBag.EC_COMPRAS_USUARIOS = new SelectList(db.EC_USUARIOS, "EC_USUARIOS_ID", "EC_USUARIOS_CEDULA", eC_COMPRAS.EC_COMPRAS_USUARIOS);
            return View(eC_COMPRAS);
        }

        // GET: EC_COMPRAS/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EC_COMPRAS eC_COMPRAS = db.EC_COMPRAS.Find(id);
            if (eC_COMPRAS == null)
            {
                return HttpNotFound();
            }
            return View(eC_COMPRAS);
        }

        // POST: EC_COMPRAS/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EC_COMPRAS eC_COMPRAS = db.EC_COMPRAS.Find(id);
            db.EC_COMPRAS.Remove(eC_COMPRAS);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
