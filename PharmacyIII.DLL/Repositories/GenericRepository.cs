using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyIII.DLL
{
    public class GenericRepository : IGenericRepository
    {
        private readonly ISqlDataAccess _db;

        public GenericRepository(ISqlDataAccess db)
        {
            _db = db;
        }

        public List<GenericDto> Get()
        {
            string sql = "select * from MED_GENERIC_INFO";
            var result = _db.LoadData<GenericDto, dynamic>(sql, new { });
            return result;
        }

        public List<GenericDto> GetById(int GenericId)
        {
            string sql = "select * from MED_GENERIC_INFO where GENERIC_ID=@id";
            var p = new { id = GenericId };
            var result = _db.LoadData<GenericDto, dynamic>(sql, p);
            return result;
        }



    }
}
