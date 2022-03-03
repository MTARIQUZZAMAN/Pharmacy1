using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyIII.DLL
{
    public interface ISqlDataAccess
    {
        List<T> LoadData<T, U>(string storedProcedure, U parameters);
    }
}
