﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay7.PracticeWorkWithGeneric.Repository
{
    public interface IRepository <T> where T : Entity
    {
        void Add(T item);
        void Remove(T item);

        void Save();

        IEnumerable<T> GetAll();

        T GetById(int id);


    }
}
