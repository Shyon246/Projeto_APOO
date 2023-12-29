using Projeto_APOO.Context;
using Projeto_APOO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto_APOO.DAL
{
    public class Item_DAL
    {
        EFContext Item_Tema = new EFContext();
        public List<Item_Tema> List()
        {
            return Item_Tema.NomeTabela.OrderBy(x => x.Item_temaId).ToList();
        }


        public Item_Tema View(long id)
        {
            Item_Tema i = Item_Tema.NomeTabela.Find(id);
            return i;
        
        }

        public void Deletar(long id)
        {

        }


        
    }
}
