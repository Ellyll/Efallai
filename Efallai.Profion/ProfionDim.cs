using System.Linq;
using Xunit;

namespace Efallai.Profion
{
    public class ProfionDim
    {
        public ProfionDim() { }

        [Fact]
        public void Gellir_Creu_Heb_Cynnwys()
        {
            Efallai<int> efallai = new Dim<int>();

            Assert.NotNull(efallai);
        }

        [Fact]
        public void Dim_yn_Dychwelyd_Cynnwys()
        {
            Efallai<int> efallai = new Dim<int>();

            var canlyniad = efallai.ToList();

            Assert.Empty(canlyniad);
        }

        [Fact]
        public void Dychwelyd_Dim_Eitemau()
        {
            Efallai<int> efallai = new Dim<int>();

            var nifer = efallai.Count();

            Assert.Equal(nifer, 0);
        }

        [Fact]
        public void Mae_HasValue_Yn_Anwir()
        {
            Efallai<int> efallai = new Dim<int>();

            Assert.False(efallai.HasValue);
        }
    }
}
