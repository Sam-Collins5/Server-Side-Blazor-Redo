using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorRedo;

namespace ApiAiBlazorLab.Tests
{
    using Xunit;

    public class TextUtilitiesTests
    {
        [Fact]
        public void NullTest()
        {
            string test = TextUtilities.NormalizeFact(null);
            Assert.Equal("No fact available.", test);
        }

        [Fact]
        public void EmptyTest()
        {
            string test = TextUtilities.NormalizeFact("");
            Assert.Equal("No fact available.", test);
        }

        [Fact]
        public void MissingTest()
        {
            string test = TextUtilities.NormalizeFact("Fact");
            Assert.Equal("Fact.", test);
        }

        [Fact]
        public void ExistingTest()
        {
            string test = TextUtilities.NormalizeFact("Fact.");
            Assert.Equal("Fact.", test);
        }

        [Fact]
        public void SpaceTest()
        {
            string test = TextUtilities.NormalizeFact("  Fact  ");
            Assert.Equal("Fact.", test);
        }
    }
}
