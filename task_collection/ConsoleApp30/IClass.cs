using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp30
{
    interface IClass
    {
        public abstract void Add(object value);
    }
    interface IRemove
    {
        public abstract void Remove(object obj);
    }
    interface IRemoveAt
    {
        public abstract void RemoveAt(int index);
    }
    interface IAddRange
    {
        public abstract void AddRange(ICollection c);
    }
}
