using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Lydia's code - find the errors!
//Corrected by Tessa

namespace CST_117_Exercise_9
{
    class Set
    {
        private List<int> elements;


        public Set()
        {
            elements = new List<int>();
        }

        public bool addElement(int val)
        {
            if (ContainsElement(val)) return false;
            else
            {
                elements.Add(val);
                return true;
            }
        }

        private bool ContainsElement(int val)
        {
            return elements.Contains(val);

            //replaced with Built in List<T>.Contains method
            //for (int i = 0; i < elements.Count; i++)
            //{
            //    if (val == elements[i])
            //        return true;
            //    else
            //        return false;
            //}
            //return false;
        }

        public override string ToString()
        {
            string str = "";
            foreach (int i in elements)
            {
                str += i + " ";
            }
            return str;
        }

        public void clearSet()
        {
            elements.Clear();
        }

        public Set union(Set rhs)
        {
            //Fix: needs to return a new Set object instead of adding onto current object.
            Set union = new Set();

            //Add the current elements to the new object.
            for (int i = 0; i < this.elements.Count; i++)
            {
                union.addElement(this.elements[i]);
            }
            for (int i = 0; i < rhs.elements.Count; i++)
            {
                //Adds elements to the current object
                //this.addElement(rhs.elements[i]);
                union.addElement(rhs.elements[i]);
            }
            return union;
        }
    }
}
