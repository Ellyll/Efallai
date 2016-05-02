using System;
using System.Collections;
using System.Collections.Generic;

namespace Efallai
{
    public abstract class Efallai<T> : IEnumerable<T>
    {
        public abstract bool HasValue { get; }
        public abstract IEnumerator<T> GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
