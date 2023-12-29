using Projeto_APOO.DAL;
using Projeto_APOO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto_APOO.Service
{

    public class Item_Service
    {
        Item_DAL DAL = new Item_DAL();
        public List<Item_Tema> List()
        {
            return DAL.List();
        }

        public Item_Tema View(long id)
        {
            return DAL.View(id);
        }
    }



    

    

}