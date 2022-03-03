using PharmacyII.BLL.Services;
using PharmacyIII.DLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyII.BLL
{
    public static class GlobalConfig
    {
        public static IGenericService GenericService { get; private set; }

        public static void InitializeConnections(string ConnectionString)
        {

                ISqlDataAccess SqlDB = new SqlDataAccess(ConnectionString);

                IGenericRepository repository = new GenericRepository(SqlDB);
                GenericService = new GenericService(repository);

        }


    }
}
