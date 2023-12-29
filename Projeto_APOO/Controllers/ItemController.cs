
using Projeto_APOO.Models;
using Projeto_APOO.Service;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projeto_APOO.Controllers
{
    public class ItemController : Controller
    {
        // GET: Item

        Item_Service Service = new Item_Service();
        public ActionResult Index()
        {
            return View(Service.List());
        }

        public ActionResult Create()
        {
            return View(new Item_Tema());
        }

        [HttpPost]
        public ActionResult Create(Item_Tema I)
        {
            Service.Create(I);
            return RedirectToAction("Index");
        }


        public ActionResult Delete(long id)
        {
     
            Item_Tema I = Service.Ver(id);
            return View(I);
        }

        [HttpPost]
        public ActionResult Delete(Item_Tema I)
        {
            Item_Tema i = Service.Ver(I.Item_temaId); 
            Service.Deletar(i);
            return RedirectToAction("Index");
        }


        public ActionResult Edit(long id)
        {
            Item_Tema I = Service.Ver(id);
            return View(I);
              
        }

        [HttpPost]
        public ActionResult Edit(Item_Tema I)
        {
            Service.Edit(I);
            return RedirectToAction("Index");

        }


        public ActionResult Details(long id)
        {
            Item_Tema I = Service.Ver(id);
            return View(I);
        }


    }
}   