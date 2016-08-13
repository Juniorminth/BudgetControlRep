using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BudgetControlMVC.Models;

namespace BudgetControlMVC.Controllers
{
    public class SystemUsersController : Controller
    {
        private BudgetDBContext db = new BudgetDBContext();

        // GET: SystemUsers
        public ActionResult Index()
        {
            var systemUserSet = db.SystemUserSet.Include(s => s.account);
            return View(systemUserSet.ToList());
        }

        // GET: SystemUsers/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SystemUser systemUser = db.SystemUserSet.Find(id);
            if (systemUser == null)
            {
                return HttpNotFound();
            }
            return View(systemUser);
        }

        // GET: SystemUsers/Create
        public ActionResult Create()
        {
            ViewBag.accountId = new SelectList(db.AccountSet, "accountId", "accountName");
            return View();
        }

        // POST: SystemUsers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "userId,Username,firstName,lastName,emailAddress,Birthdate,accountId,createdOn,modifiedOn,Id")] SystemUser systemUser)
        {
            if (ModelState.IsValid)
            {
                systemUser.userId = Guid.NewGuid();
                db.SystemUserSet.Add(systemUser);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.accountId = new SelectList(db.AccountSet, "accountId", "accountName", systemUser.accountId);
            return View(systemUser);
        }

        // GET: SystemUsers/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SystemUser systemUser = db.SystemUserSet.Find(id);
            if (systemUser == null)
            {
                return HttpNotFound();
            }
            ViewBag.accountId = new SelectList(db.AccountSet, "accountId", "accountName", systemUser.accountId);
            return View(systemUser);
        }

        // POST: SystemUsers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "userId,Username,firstName,lastName,emailAddress,Birthdate,accountId,createdOn,modifiedOn,Id")] SystemUser systemUser)
        {
            if (ModelState.IsValid)
            {
                db.Entry(systemUser).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.accountId = new SelectList(db.AccountSet, "accountId", "accountName", systemUser.accountId);
            return View(systemUser);
        }

        // GET: SystemUsers/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SystemUser systemUser = db.SystemUserSet.Find(id);
            if (systemUser == null)
            {
                return HttpNotFound();
            }
            return View(systemUser);
        }

        // POST: SystemUsers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            SystemUser systemUser = db.SystemUserSet.Find(id);
            db.SystemUserSet.Remove(systemUser);
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
