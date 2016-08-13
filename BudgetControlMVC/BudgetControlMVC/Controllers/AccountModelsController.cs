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
    public class AccountModelsController : Controller
    {
        private BudgetDBContext db = new BudgetDBContext();

        // GET: AccountModels
        public ActionResult Index()
        {
            var accountSet = db.AccountSet.Include(a => a.Owner);
            return View(accountSet.ToList());
        }

        // GET: AccountModels/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AccountModel accountModel = db.AccountSet.Find(id);
            if (accountModel == null)
            {
                return HttpNotFound();
            }
            return View(accountModel);
        }

        // GET: AccountModels/Create
        public ActionResult Create()
        {
            ViewBag.OwnerId = new SelectList(db.SystemUserSet, "userId", "Username");
            return View();
        }

        // POST: AccountModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "accountId,accountName,OwnerId,createdOn,modifiedOn,Id")] AccountModel accountModel)
        {
            if (ModelState.IsValid)
            {
                accountModel.accountId = Guid.NewGuid();
                db.AccountSet.Add(accountModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.OwnerId = new SelectList(db.SystemUserSet, "userId", "Username", accountModel.OwnerId);
            return View(accountModel);
        }

        // GET: AccountModels/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AccountModel accountModel = db.AccountSet.Find(id);
            if (accountModel == null)
            {
                return HttpNotFound();
            }
            ViewBag.OwnerId = new SelectList(db.SystemUserSet, "userId", "Username", accountModel.OwnerId);
            return View(accountModel);
        }

        // POST: AccountModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "accountId,accountName,OwnerId,createdOn,modifiedOn,Id")] AccountModel accountModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(accountModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.OwnerId = new SelectList(db.SystemUserSet, "userId", "Username", accountModel.OwnerId);
            return View(accountModel);
        }

        // GET: AccountModels/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AccountModel accountModel = db.AccountSet.Find(id);
            if (accountModel == null)
            {
                return HttpNotFound();
            }
            return View(accountModel);
        }

        // POST: AccountModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            AccountModel accountModel = db.AccountSet.Find(id);
            db.AccountSet.Remove(accountModel);
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
