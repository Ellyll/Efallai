using System.Linq;
using Xunit;

namespace Efallai.Profion
{
    public class ProfionDim
    {
        public ProfionDim()
        {

        }

        [Fact]
        public void Gellir_Creu_Heb_Cynnwys()
        {
            var efallai = new Dim<int>();

            Assert.NotNull(efallai);
        }

        [Fact]
        public void Dim_yn_Dychwelyd_Cynnwys()
        {
            var efallai = new Dim<int?>();

            var canlyniad = efallai.FirstOrDefault();

            Assert.Null(canlyniad);
        }

        [Fact]
        public void Dychwelyd_Dim_Eitemau()
        {
            var efallai = new Dim<int>();

            var nifer = efallai.Count();

            Assert.Equal(nifer, 0);
        }

        [Fact]
        public void Mae_HasValue_Yn_Anwir()
        {
            var efallai = new Dim<int>();

            Assert.False(efallai.HasValue);
        }
    }
}
