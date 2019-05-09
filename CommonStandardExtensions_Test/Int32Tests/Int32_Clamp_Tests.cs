namespace CommonStandardExtensions_Test.Int32Tests
{
    using System;
    using Xunit;
    using CommonStandardExtensions;
    
    public class Int32_Clamp_Tests
    {
        [Theory]
        [InlineData(50, 60, 100, 60)]
        [InlineData(0, 10, 100, 10)]
        [InlineData(-50, -40, 100, -40)]
        [InlineData(Int32.MinValue, -10, 1000, -10)]
        public void Int32_Clamp_UnderMin(int toClamp, int min, int max, int expected)
        {
            int clamped = toClamp.Clamp(min, max);
            Assert.Equal(expected, clamped);
        }

        [Theory]
        [InlineData(50, 5, 40, 40)]
        [InlineData(0, -5, -2, -2)]
        [InlineData(-11, -100, -22, -22)]
        [InlineData(Int32.MaxValue, 0, 500, 500)]
        public void Int32_Clamp_OverMax(int toClamp, int min, int max, int expected)
        {
            int clamped = toClamp.Clamp(min, max);
            Assert.Equal(expected, clamped);
        }

        [Theory]
        [InlineData(50, 40, 70, 50)]
        [InlineData(0, -2, 5, 0)]
        [InlineData(-82, -100, -60, -82)]
        [InlineData(50, Int32.MinValue, Int32.MaxValue, 50)]
        public void Int32_Clamp_InRange(int toClamp, int min, int max, int expected)
        {
            int clamped = toClamp.Clamp(min, max);
            Assert.Equal(expected, clamped);
        }

        [Theory]
        [InlineData(Int32.MinValue, Int32.MinValue, 100, Int32.MinValue)]
        [InlineData(50, 50, 1000, 50)]
        public void Int32_Clamp_EqualsMin(int toClamp, int min, int max, int expected)
        {
            int clamped = toClamp.Clamp(min, max);
            Assert.Equal(expected, clamped);
        }

        [Theory]
        [InlineData(Int32.MaxValue, -10, Int32.MaxValue, Int32.MaxValue)]
        [InlineData( -10, -50, -10, -10)]
        public void Int32_Clamp_EqualsMax(int toClamp, int min, int max, int expected)
        {
            int clamped = toClamp.Clamp(min, max);
            Assert.Equal(expected, clamped);
        }

        [Fact]
        public void Int32_Clamp_MinGreaterThanMax()
        {
            Assert.Throws<ArgumentException>(() => 50.Clamp(100, 10));
        }
    }
}