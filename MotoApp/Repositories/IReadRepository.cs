using Microsoft.EntityFrameworkCore;
using MotoApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoApp.Repositories
{
    public interface IReadRepository<out T> where T : class, IEntity
    {
        public IEnumerable<T> GetAll();

        public T? GetById(int id);
    }
}
