using System.Linq;
using Xunit;

namespace Efallai.Profion
{
    public class ProfionRhai
    {
        public ProfionRhai()
        {

        }

        [Fact]
        public void Gellir_Creu_Gyda_Cynnwys()
        {
            var rhai = new Rhai<int>(123);

            Assert.NotNull(rhai);
        }

        [Fact]
        public void Gellir_Dychwelyd_Cynnwys()
        {
            var rhai = new Rhai<int>(123);

            Assert.Equal(rhai.First(), 123);
        }

        [Fact]
        public void Dychwelyd_Un_Eitem_Yn_Unig()
        {
            var rhai = new Rhai<int>(123);

            var nifer = rhai.Count();

            Assert.Equal(nifer, 1);
        }

        [Fact]
        public void Mae_HasValue_Yn_Gwir()
        {
            var rhoi = new Rhai<int>(123);

            Assert.True(rhoi.HasValue);
        }
    }
}
