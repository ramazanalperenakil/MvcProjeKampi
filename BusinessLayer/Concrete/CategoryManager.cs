﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
   public class CategoryManager
    {
        GenericRepository<Category> repo = new GenericRepository<Category>();


        public List<Category> GetAllBL()
        {
            return repo.List();
        }


        public void CategoryAddBL(Category p)
        {
            repo.Insert(p);
            //if(p.CategoryName=="" || p.CategoryName.Length<=3 || p.CategoryDescription=="" || p.CategoryName.Length>=51 )
            //{
            //    //Hata mesajı eklenecek
            //}

            //else
            //{
            //    repo.Insert(p);
            //}
        }
    }
}
 