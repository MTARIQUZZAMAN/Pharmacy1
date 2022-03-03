using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyIII.DLL
{
    public interface IGenericRepository
    {
        List<GenericDto> Get();
        List<GenericDto> GetById(int GenericId);
    }
}
