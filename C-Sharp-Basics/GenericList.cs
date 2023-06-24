using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Basics
{
    public class GenericList<T>
    {

        private List<T> _list;
        public GenericList()
        {
            _list = new List<T>();
        }
        public void Add(T obj)
        {
            _list.Add(obj);
        }
        public void PrintList()
        {
            foreach(T obj in _list)
                Console.WriteLine(obj);
        }
    }
}
