using System.Collections.Generic;

namespace Efallai
{
    public class Rhai<T> : Efallai<T>
    {
        private readonly T _data;

        public override bool HasValue { get { return true; } }

        public Rhai(T item)
        {
            _data = item;
        }

        public override IEnumerator<T> GetEnumerator()
        {
            yield return _data;
        }
    }
}
