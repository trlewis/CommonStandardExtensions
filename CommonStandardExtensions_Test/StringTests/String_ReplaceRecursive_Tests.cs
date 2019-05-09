namespace CommonStandardExtensions_Test.StringTests
{
    using System;
    using CommonStandardExtensions;
    using Xunit;
    using Xunit.Sdk;

    public class String_ReplaceRecursive_Tests
    {
        [Theory]
        [InlineData("a..a.a...a...", "..", ".", "a.a.a.a.")]
        [InlineData("abcc", "cc", "c", "abc")]
        [InlineData("1  2 3      4", "  ", " ", "1 2 3 4")]
        [InlineData("   a   b", "  ", " ", " a b")]
        public void String_ReplaceRecursive_CanReplace(string original, string oldVal, string newVal, string expected)
        {
            string replaced = original.ReplaceRecursive(oldVal, newVal);
            Assert.Equal(expected, replaced);
        }

        [Theory]
        [InlineData("a   b c", ".", "  ", "a   b c")]
        [InlineData("", " ", ".", "")]
        public void String_ReplacementRecursive_CannotReplace(string original, string oldVal,
            string newVal, string expected)
        {
            string replaced = original.ReplaceRecursive(oldVal, newVal);
            Assert.Equal(expected, replaced);
        }

        [Fact]
        public void String_ReplaceRecursive_Throws()
        {
            Exception ex = Assert.Throws<ArgumentException>(() => 
                "abc".ReplaceRecursive(".", ".."));
//            Assert.Equal(typeof(ArgumentException), ex.GetType());
        }
    }
}