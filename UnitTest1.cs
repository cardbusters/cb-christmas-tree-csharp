using System;
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
    }
}
