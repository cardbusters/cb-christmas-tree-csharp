using System;
using System.Collections.Generic;
using Xunit;

namespace christmas_tree_kata
{
    public class UnitTest1
    {
        [Fact]
        public void DrawMethodCannotTakeLessThenValue5()
        {
            var expected = 5;
            var actual = Christmastree.Draw(4);
            
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DrawMethodReturnsATypeOfList()
        {
            var expectedType = typeof(List<object>);
            var actual = Christmastree.Draw(4);
            
            Assert.IsType(expected, actual);
        }
    }
}
