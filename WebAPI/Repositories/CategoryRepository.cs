using System;
using System.Collections.Generic;
using WebAPI.Models;
using WebAPI.DAL;
using System.Linq;

namespace WebAPI.Repositories
{
    public class categoryRepo : IcategoryRepo
    {
        private readonly ProductContext _dbContext;
        public categoryRepo(ProductContext dbContext) 
        {
            _dbContext = dbContext;
        }

        public void Delete_Cat(int categoryid)
        {
            var category = _dbContext.Categories.Find(categoryid);
            _dbContext.Categories.Remove(category);
            Save();
        }


        public Category Get_Cat_ById(int Id)
        {
            var cate = _dbContext.Categories.Find(Id);

            return cate;
        }

        public IEnumerable<Category> Get_Cat()
        {
            return _dbContext.Categories.ToList();
        }

        public void Insert_Cat(Category category)
        {
             _dbContext.Add(category);
            Save();
        }

        public void Update_Cat(Category category)
        {
            _dbContext.Entry(category).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
        public void Save() 
        {
            _dbContext.SaveChanges();
        }
    }
}
