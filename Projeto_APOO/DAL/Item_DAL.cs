using Projeto_APOO.Context;
using Projeto_APOO.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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


        public Item_Tema Ver(long id)
        {
            return Item_Tema.NomeTabela.Find(id);
             
        
        }

        public void Deletar(Item_Tema i)
        {

            Item_Tema entityToDelete = Ver(i.Item_temaId);
            if (entityToDelete != null)
            {
                Item_Tema.NomeTabela.Remove(entityToDelete);
                Item_Tema.SaveChanges();
            }

        }
        public void Create(Item_Tema i)
        {

            if (i != null)
            {
                Item_Tema.NomeTabela.Add(i);
                Item_Tema.SaveChanges();
            }

        }
        public void Edit(Item_Tema i)
        {

            if (i != null)
            {
                Item_Tema.Entry(i).State = EntityState.Modified;
                Item_Tema.SaveChanges();
            }

        }



    }
}
