using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_CSharp_ADV_Delegate
{
    internal class CustomList<T>
    {
            private List<T> _list = new List<T>();

            public bool Exists(Predicate<T> match)
            {
                foreach (var item in _list)
                {
                    if (match(item))
                        return true;
                }
                return false;
            }

            public T Find(Predicate<T> match)
            {
                foreach (var item in _list)
                {
                    if (match(item))
                        return item;
                }
                return default(T);
            }

            public List<T> FindAll(Predicate<T> match)
            {
                List<T> result = new List<T>();
                foreach (var item in _list)
                {
                    if (match(item))
                        result.Add(item);
                }
                return result;
            }

            public int FindIndex(Predicate<T> match)
            {
                for (int i = 0; i < _list.Count; i++)
                {
                    if (match(_list[i]))
                        return i;
                }
                return -1;
            }

            public T FindLast(Predicate<T> match)
            {
                for (int i = _list.Count - 1; i >= 0; i--)
                {
                    if (match(_list[i]))
                        return _list[i];
                }
                return default(T);
            }

            public int FindLastIndex(Predicate<T> match)
            {
                for (int i = _list.Count - 1; i >= 0; i--)
                {
                    if (match(_list[i]))
                        return i;
                }
                return -1;
            }

            public void ForEach(Action<T> action)
            {
                foreach (var item in _list)
                {
                    action(item);
                }
            }

            public bool TrueForAll(Predicate<T> match)
            {
                foreach (var item in _list)
                {
                    if (!match(item))
                        return false;
                }
                return true;
            }
    }
}
