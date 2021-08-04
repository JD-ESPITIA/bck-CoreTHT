using AutosColombia.Src.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AutosColombia.Src.Data
{
    public interface IDataContext
    {
        DbSet<Auto> Autos { get; init; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}