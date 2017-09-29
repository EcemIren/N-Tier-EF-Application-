using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuzeyYeli.Repository
{
    interface IRepository<T> where T : class
    {
        //Listing Entities
        List<T> List();

        //Insert new Items
        bool Insert(T entity);

        //Update an item
        bool Update(T entity);

        //Remove an item
        bool Delete(T entity);
    }
}
