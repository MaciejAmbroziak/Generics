using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public interface IRecentlyUsedList<T>: IEnumerable<T>
    { 
        public bool IsEmpty();
        public void Open(T project);
        public T Pick(string line);

    }
}
