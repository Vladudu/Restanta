using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restanta.Models
{
    public interface IHotelRepository
    {
        void Add(RestModel restModel);
        void Edit(RestModel restModel);
        void Delete(int id);
        IEnumerable<RestModel> GetAll();
        IEnumerable<RestModel> GetByValue(string value); 
    }
}
