﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessWebProject.AplicationCore.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetUser(int id);
        void Create(T entity);
        void Update(T entity);
        void Delete(int id);

    }
}