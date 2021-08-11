using System;
using TheConsoleApp;
using Xunit;

namespace TheChallengeTests
{
    public class WaitingTimeTests
    {
        [Fact]
        public void EmptyArrayForWaitingTimeShouldThrowsException()
        {
            Assert.ThrowsAny<Exception>(() =>
            {
                new WaitingTime(new int[0]);
            });
        }

        [Fact]
        public void NullForWaitingTimeShouldThrowsException()
        {
            Assert.ThrowsAny<Exception>(() =>
            {
                new WaitingTime(null);
            });
        }

        [Theory]
        [InlineData(0, 2)]
        [InlineData(1, 3)]
        [InlineData(2, 1)]
        [InlineData(3, 4)]
        [InlineData(4, 5)]
        [InlineData(5, 6)]
        [InlineData(6, 7)]
        [InlineData(7, 7)]
        [InlineData(8, 7)]
        [InlineData(9, 7)]
        public void ShouldFindWaitingTimeCorrectly(int index, int expected)
        {
            var waitingTimes = new[] { 2, 3, 1, 4, 5, 6, 7 };
            var waitingTime = new WaitingTime(waitingTimes);

            var result = waitingTime.Find(index);
            Assert.Equal(TimeSpan.FromSeconds(expected), result);
        }
    }
}
