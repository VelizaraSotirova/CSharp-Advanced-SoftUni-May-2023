using System;
using System.Collections.Generic;
using System.Text;

namespace BoxOfT
{
    public class Box<T>
    {
        private List<T> items;

        public Box()
        { 
            items = new List<T>();
        }
        public void Add(T element)
        {
            items.Add(element);
        }
        public T Remove()
        {
            T firstElement = items[this.items.Count-1];
            items.RemoveAt(this.items.Count - 1 );
            return firstElement;
        }

        public int Count
        {
            get { return this.items.Count; }
        }
    }
}
