using System.ComponentModel;
using Xunit;

namespace Testing
{
    public class UnitTest1
    {
        [Fact]
        [Trait("Category","Unit")]
        public void Test1()
        {
            Assert.True(true);
        }

        [Fact]
        [Trait("Category","Unit")]
        public void Test2()
        {
            Assert.True(true);
        }

        [Fact]
        [Trait("Category","Intergration")]
        public void Test4()
        {
            Assert.True(true);
        }
    }
}



namespace Testing2
{
    public class UnitTest3
    {
        [Fact]
        [Trait("Category","Unit")]
        public void Test6()
        {
            Assert.True(true);
        }

      
    }
}