using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Efallai;
using Xunit;

namespace Efallai.Profion
{
    // This project can output the Class library as a NuGet Package.
    // To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".
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
    }
}
