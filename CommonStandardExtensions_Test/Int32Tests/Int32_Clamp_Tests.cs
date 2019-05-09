namespace CommonStandardExtensions_Test.Int32Tests
{
    using Xunit;
    using CommonStandardExtensions;
    
    public class Int32_Clamp_Tests
    {
        [Theory]
        [InlineData(50, 60, 100, 60)]
        [InlineData(0, 10, 100, 10)]
        [InlineData(-50, -40, 100, -40)]
        public void Int32_Clamp_LessThanMin(int toClamp, int min, int max, int expected)
        {
            int clamped = toClamp.Clamp(min, max);
            Assert.Equal(expected, clamped);
        }

        [Theory]
        [InlineData(50, 5, 40, 40)]
        [InlineData(0, -5, -2, -2)]
        [InlineData(-11, -100, -22, -22)]
        public void Int32_Clamp_OverMax(int toClamp, int min, int max, int expected)
        {
            int clamped = toClamp.Clamp(min, max);
            Assert.Equal(expected, clamped);
        }

        [Theory]
        [InlineData(50, 40, 70, 50)]
        [InlineData(0, -2, 5, 0)]
        [InlineData(-82, -100, -60, -82)]
        public void Int32_Clamp_InRange(int toClamp, int min, int max, int expected)
        {
            int clamped = toClamp.Clamp(min, max);
            Assert.Equal(expected, clamped);
        }
    }
}