using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace KuzeyYeli.WCF
{
    [ServiceContract]
    public interface IService<DTO> where DTO: class
    {
        [OperationContract]
        List<DTO> List();

        [OperationContract]
        bool Insert(DTO dto);

        [OperationContract]
        bool Update(DTO dto);

        [OperationContract]
        bool Delete(DTO dto);



    }
}
