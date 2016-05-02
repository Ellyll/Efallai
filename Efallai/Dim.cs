using System.Collections.Generic;

namespace Efallai
{
    public class Dim<T> : Efallai<T>
    {
        public override bool HasValue { get { return false; } }

        public Dim()
        {
        }

        public override IEnumerator<T> GetEnumerator()
        {
            yield break;
        }
    }
}
