using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EF6Demo.Repository.Interfaces
{
    public interface IRepository<T> : IDisposable where T: class 
    {
        List<T> GetList();
    }
}