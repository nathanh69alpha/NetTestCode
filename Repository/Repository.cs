using EF6Demo.Data;
using EF6Demo.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EF6Demo.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly SchoolContext _db;
        private DbSet<T> dBset;
        public Repository()
        {
            _db = new SchoolContext();
            dBset = _db.Set<T>();
        }
        public void Dispose()
        {
            _db.Dispose();
        }

        public List<T> GetList()
        {
            var query = dBset.ToList();
            return query;
        }
    }
}