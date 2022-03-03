using PharmacyII.BLL.Models;
using PharmacyIII.DLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyII.BLL.Services
{
    public class GenericService : IGenericService
    {
        private readonly IGenericRepository repository;

        public GenericService(IGenericRepository repository)
        {
            this.repository = repository;
        }

        public IEnumerable<GenericModel> Get()
        {
            return repository.Get().Select(GenericDto => new GenericModel
            {
                GenericId = GenericDto.GENERIC_ID,
                GenericName = GenericDto.GENERIC_NAME,
                IsShow = GenericDto.SHOW
            });
        }

        public GenericModel GetById(int id)
        {
            return repository.GetById(id).Select(GenericDto => new GenericModel
            {
                GenericId = GenericDto.GENERIC_ID,
                GenericName = GenericDto.GENERIC_NAME,
                IsShow = GenericDto.SHOW
            }).FirstOrDefault();
        }

    }
}
