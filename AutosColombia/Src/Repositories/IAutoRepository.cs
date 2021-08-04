using AutosColombia.Src.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutosColombia.Src.Repositories
{
    public interface IAutoRepository
    {
        Task<Auto> Get(int id);
        Task<IEnumerable<Auto>> GetAll();
        Task Add(Auto Auto);
        Task Delete(int id);
        Task Update(Auto Auto);
    }
}
