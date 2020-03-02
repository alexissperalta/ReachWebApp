using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DotNetAppSqlDb.Models;using System.Diagnostics;

namespace DotNetAppSqlDb.Controllers
{
    public class TodosController : Controller
    {
        private MyDatabaseContext db = new MyDatabaseContext();

        // GET: Config
        public ActionResult Index()
        {            
            Trace.WriteLine("GET /Config");
            var config_stuff = db.Config.ToList();
            return View(config_stuff);
        }

        public ActionResult Messages()
        {
            Trace.WriteLine("GET /Messages");
            var msgs = db.Messages.ToList();
            return View(msgs);
        }

        // GET: Config/Edit/5
        public ActionResult Edit(int? id)
        {
            Trace.WriteLine("GET /Config/Edit" + id);
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Config config = db.Config.Find(id);
            if (config == null)
            {
                return HttpNotFound();
            }
            return View(config);
        }

        // POST: Config/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Pollrate,Postrate")] Config config)
        {
            Trace.WriteLine("POST /Config/Edit/" + config.ID);
            if (ModelState.IsValid)
            {
                db.Entry(config).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(config);
        }

    }
}
