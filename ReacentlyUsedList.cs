using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Generics
{
    public class RecentlyUsedList<T> : IRecentlyUsedList<T>
    {
        List<T> myList;
        public RecentlyUsedList()
        {
            myList = new List<T>();
        }
        //checkes if there is any project in the list
        public bool IsEmpty()
        {
            return myList == null;
        }

        public void Open(T project)
        {
            if (Exists(project))
            {
                Remove(project);
                Insert(project);
            }
            else
            {
                Console.WriteLine("It does not esists.");
            }
        }

        public void Insert(T project)
        {
            myList.Insert(0, project);
        }

        private void Remove(T project)
        {
            if (Exists(project))
            {
                myList.Remove(project);
            }
        }

        private bool Exists(T project)
        {
            if (!IsEmpty()) {
                foreach (var item in myList)
                {
                    if (project.Equals(item))
                    {
                        return true;
                    }
                }
                
            }
            return false;
        }

        public void PrintList()
        {
            foreach(var item in this)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach(var item in myList)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach (var item in myList)
            {
                yield return item;
            }
        }

        public T Pick(string line)
        {
            int i = int.Parse(line) - 1;
            return myList[i];
        }
    } 
}
