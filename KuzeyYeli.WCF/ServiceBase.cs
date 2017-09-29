using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KuzeyYeli.WCF
{
    using Repository;
    using Entity.Models;
    using KuzeyYeliDTO;
    using Extension;
    public class ServiceBase<Rep,Ent,DTO> : IService<DTO> 
      where Rep : RepositoryBase<Ent>
      where Ent:class
      where DTO : class
     
    {
        private Rep repository;

        public Rep Repository
        {
            get
            {
                //It provides to create a new instance from generic type
                repository = repository ?? Activator.CreateInstance<Rep>();
                return repository;
            }

            set
            {
                repository = value;
            }
        }


        public bool Delete(DTO dto)
        {
            return Repository.Delete(dto.Changer<Ent>());
        }

        public bool Insert(DTO dto)
        {
            return Repository.Insert(dto.Changer<Ent>());
        }

        public List<DTO> List()
        {
            return Repository.List().Select(x => x.Changer<DTO>()).ToList();
        }

        public bool Update(DTO dto)
        {
            return Repository.Update(dto.Changer<Ent>());
        }
    }
}