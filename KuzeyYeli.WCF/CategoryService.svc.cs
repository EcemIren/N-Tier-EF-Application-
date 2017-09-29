using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace KuzeyYeli.WCF
{
    using Repository;
    using Entity;
    using KuzeyYeliDTO;
    using Entity.Models;
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CategoryService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CategoryService.svc or CategoryService.svc.cs at the Solution Explorer and start debugging.
    public class CategoryService : ServiceBase<CategoryRepository, Kategoriler,CategoryDTO>
    {
        public void DoWork()
        {
        }
    }
}
