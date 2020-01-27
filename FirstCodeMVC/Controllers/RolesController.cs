﻿using FirstCodeMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstCodeMVC.Controllers
{
    public class RolesController : Controller
    {
        ApplicationDbContext myContext = new ApplicationDbContext();
        // GET: Roles
        public ActionResult Index()
        {
            var list = myContext.Roles.ToList();
            return View(list);
        }

        // GET: Roles/Details/5
        public ActionResult Details(int id)
        {
            var list = myContext.Roles.Find(id);
            return View(list);
        }

        // GET: Roles/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: Roles/Create
        [HttpPost]
        public ActionResult Create(Role role)
        {
            try
            {
                // TODO: Add insert logic here
                myContext.Roles.Add(role);
                myContext.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Roles/Edit/5
        public ActionResult Edit(int id)
        {
            var edit = myContext.Roles.Find(id);
            return View(edit);
        }

        // POST: Roles/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Role role)
        {
            try
            {
                // TODO: Add update logic here
                var edit = myContext.Roles.Find(id);
                edit.Name = role.Name;
                myContext.Entry(edit).State = System.Data.Entity.EntityState.Modified;
                myContext.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Roles/Delete/5
        public ActionResult Delete(int id)
        {
            var Delete = myContext.Roles.Find(id);
            return View(Delete);
        }

        // POST: Roles/Delete/5
        [HttpPost]
        public ActionResult Delete(int id,Role role)
        {
            try
            {
                // TODO: Add delete logic here
                var delete = myContext.Roles.Find(id);
                myContext.Roles.Remove(delete);
                myContext.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
