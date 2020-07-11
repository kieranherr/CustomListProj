using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class MyList<T> : IEnumerable<T>
    {
        int count;
        public int Count { get; set; }
        int capacity; 
        public int Capacity { get; set; }
        private T[] items;
        public MyList()
        {
            capacity = 4;
            items = new T[capacity];
        }

        public void Add()
        { 
            T[] TempList = new T[items.Length + 1];
            for(int i = 0; i < items.Length; i++)
            {
                TempList[i] = items[i];
            }
            items = TempList;

        }
        public void AddTogether(MyList<T> list1, MyList<T> list2 )
        {
            T[] TempList = new T[list1.Count+list2.Count];
            
            for(int i = 0; i<list1.Count; i++)
            {
                TempList[i] = list1[i];
            }
            for (int i = 0; i < list2.Count; i++)
            {
                TempList[i] = list2[i];
            }
            items = TempList;

        }

      
        public IEnumerator<T> GetEnumerator()
        {
            for(int i = 0; i<count; i++)
            {
                yield return items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
