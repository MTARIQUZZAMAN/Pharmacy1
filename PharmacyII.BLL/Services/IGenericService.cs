using PharmacyII.BLL.Models;
using System.Collections.Generic;

namespace PharmacyII.BLL.Services
{
    public interface IGenericService
    {
        IEnumerable<GenericModel> Get();
        GenericModel GetById(int id);
    }
}