using System.Collections.Generic;
using WebAPI.Models;
namespace WebAPI.Repositories
{
    public interface IcategoryRepo
    {
        void Insert_Cat(Category category);

        void Update_Cat(Category category);

        void Delete_Cat(int categoryid);

        Category Get_Cat_ById(int Id);

        IEnumerable<Category> Get_Cat();
    }
}
