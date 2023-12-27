﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTrader.Domain.Services
{
    public interface IDataService<T>
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> Get(int Id);
        Task<T> Create(T entity);
        Task<T> Update(int Id,T entity);
        Task<T> Delete(int Id);
    }
}
