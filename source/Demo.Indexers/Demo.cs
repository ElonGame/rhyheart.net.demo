using System;
using System.Collections.Generic;

namespace Demo.Indexers
{
    public class Demo<T>
    {
        public List<T> List { get; set; }
        public Demo(List<T> list)
        {
            List = list;
        }

        public T this[int index]
        {
            get => List[index];
            set
            {
                var oldValue = List[index];
                var newValue = value;
                List[index] = newValue;
                OnChanged(oldValue, newValue);
            }
        }

        public void OnChanged(T oldValue, T newValue)
        {
            Changed?.Invoke(this, new MyEventArgs
            {
                Message = $"原值:{oldValue} 新值:{newValue}"
            });
        }

        public event EventHandler<MyEventArgs> Changed;
    }
}
