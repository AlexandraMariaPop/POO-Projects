using System;
using System.Collections.Generic;
using System.Text;
namespace ClasaStiva
{
    public class Stiva<T>
    {
        private List<T> lista;
        private int size;
        public Stiva(int size)
        {
            lista = new List<T>();
            this.size = size;
        }
        //Push() – pentru introducerea de elemente în stivă,
        public void Push(T toadd)
        {
            if (lista.Count < size)
                lista.Add(toadd);
            else
                throw new Exception("STACK IS FULL");
        }
        //Pop() – pentru extragerea de elemente din stivă,
        public T Pop()
        {
            if (lista.Count != 0)
            {
                T toreturn = lista[lista.Count-1];
                lista.Remove(toreturn);
                return toreturn;
               
            }
            else
                throw new Exception("STACK IS EMPTY");
        }
        //Clear() – pentru ștergerea tuturor elementelor din stivă.
        public void Clear()
        {
            if (lista.Count != 0)
                lista.Clear();
            else
                throw new Exception("STACK IS ALREADY EMPTY");
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in lista)
            {
                sb.Append(item.ToString() + " ");
            }
            return sb.ToString();
        }
    }
}