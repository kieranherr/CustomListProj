using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class CustomList<T> : IEnumerable
    {
        public T[] items;
        public CustomList()
        {
            items = new T[0];
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public class MyList<T>
        {

            public readonly int Count;
          
            public int Capacity { get; set; }
           
            
            public void Add()
            {

            }
        }
    }
}
