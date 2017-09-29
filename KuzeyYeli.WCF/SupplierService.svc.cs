using KuzeyYeli.Entity.Models;
using KuzeyYeliDTO;
using KuzeyYeli.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace KuzeyYeli.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SupplierService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select SupplierService.svc or SupplierService.svc.cs at the Solution Explorer and start debugging.
    public class SupplierService : ServiceBase<SupplierRepository, Tedarikciler,SupplierDTO>
    {
        public void DoWork()
        {
        }
    }
}
