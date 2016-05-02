using System.Linq;
using Xunit;

namespace Efallai.Profion
{
    public class ProfionRhai
    {
        public ProfionRhai() {}

        [Fact]
        public void Gellir_Creu_Gyda_Cynnwys()
        {
            Efallai<int> efallai = new Rhai<int>(123);

            Assert.NotNull(efallai);
        }

        [Fact]
        public void Gellir_Dychwelyd_Cynnwys()
        {
            Efallai<int> efallai = new Rhai<int>(123);

            Assert.Equal(efallai.First(), 123);
        }

        [Fact]
        public void Dychwelyd_Un_Eitem_Yn_Unig()
        {
            Efallai<int> efallai = new Rhai<int>(123);

            var nifer = efallai.Count();

            Assert.Equal(nifer, 1);
        }

        public void Gweithio_Gyda_Null()
        {
            Efallai<string> efallai = new Rhai<string>(null);

            var eitem = efallai.First();

            Assert.Null(eitem);
            Assert.True(efallai.HasValue);
        }

        [Fact]
        public void Mae_HasValue_Yn_Gwir()
        {
            Efallai<int> efallai = new Rhai<int>(123);

            Assert.True(efallai.HasValue);
        }
    }
}
