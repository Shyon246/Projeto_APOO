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

        public Item_Tema Ver(long id)
        {
            return DAL.Ver(id);
        }
        public void Deletar(Item_Tema i)
        {
            DAL.Deletar(i);
        }
        public void Edit(Item_Tema i)
        {
            DAL.Edit(i);
        }
        public void Create(Item_Tema i)
        {
            DAL.Create(i);
        }
    }



    

    

}