using AutosColombia.Src.Data;
using AutosColombia.Src.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutosColombia.Src.Repositories
{
    public class AutoRepository : IAutoRepository
    {
        private readonly IDataContext _context;

        public AutoRepository(IDataContext context)
        {
            _context = context;

        }


        public async Task Add(Auto Auto)
        {
            _context.Autos.Add(Auto);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var itemToRemove = await _context.Autos.FindAsync(id);

            if (itemToRemove == null)
                throw new NullReferenceException();

            _context.Autos.Remove(itemToRemove);
            await _context.SaveChangesAsync();
        }

        public async Task<Auto> Get(int id)
        {
            return await _context.Autos.FindAsync(id);
        }

        public async Task<IEnumerable<Auto>> GetAll()
        {
            return await _context.Autos.ToListAsync();
        }

        public async Task Update(Auto Auto)
        {
            var itemToUpdate = await _context.Autos.FindAsync(Auto.Id);
            if (itemToUpdate == null)
                throw new NullReferenceException();


            itemToUpdate.CarBrand = Auto.CarBrand;
            itemToUpdate.Color = Auto.Color;
            itemToUpdate.FabricationDate = Auto.FabricationDate;
            itemToUpdate.Model = Auto.Model;
            itemToUpdate.Seating = Auto.Seating;


            await _context.SaveChangesAsync();
        }
    }
}
