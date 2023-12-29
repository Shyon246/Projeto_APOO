﻿using Projeto_APOO.Context;
using Projeto_APOO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projeto_APOO.Controllers
{
    public class ItemController : Controller
    {
        // GET: Item
        EFContext Item_Tema = new EFContext();
        public ActionResult Index()
        {
            return View(Item_Tema.NomeTabela.OrderBy(x => x.Item_temaId).ToList());
        }

        public ActionResult Create()
        {
            return View(new Item_Tema());
        }

        [HttpPost]
        public ActionResult Create(Item_Tema I)
        {
            Item_Tema.NomeTabela.Add(I);
            Item_Tema.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(long id)
        {
            Item_Tema I = Item_Tema.NomeTabela.Find(id);
            return View(I);
        }



    }
}   