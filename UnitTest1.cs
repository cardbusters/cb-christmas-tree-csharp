using System;
using System.Collections.Generic;
using Xunit;

namespace christmas_tree_kata
{
    public class UnitTest1
    {
        [Fact]
        public void DrawMethod_GivingLessThan5ThenOutputShouldBe6()
        {
            var expectedCount = 6;
            var actualList = Christmastree.Draw(4);

            Assert.Equal(expectedCount, actualList.Count);
        }

        [Fact]
        public void DrawMethod_GivenAnyValueThenReturnsListOfObjects()
        {
            var expectedType = typeof(List<object>);
            var actualList = Christmastree.Draw(4);

            Assert.IsType(expectedType, actualList);
        }

        [Theory]
        [InlineData("       X",0)]
        [InlineData("      XXX",1)]
        [InlineData("     XXXXX",2)]
        [InlineData("    XXXXXXX",3)]
        [InlineData("   XXXXXXXXX",4)]
        [InlineData("       X",5)]
        public void DrawMethod_Given5ThenReturnsSpecificData(string expectedString, int index){
            var actualString = Christmastree.Draw(5)[index];

            Assert.Equal(expectedString, actualString);
        }

        [Theory]
        [InlineData(1,6)]
        [InlineData(5,6)]
        [InlineData(6,7)]
        public void DrawMethod_GivenHeightShouldReturnActualHeight(int height, int expectedHeight)
        {
            var actualList = Christmastree.Draw(height);

            Assert.Equal(expectedHeight, actualList.Count);        
        }
    }
}
