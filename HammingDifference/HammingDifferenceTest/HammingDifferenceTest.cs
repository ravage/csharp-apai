using System;
using Xunit;
using LibHammingDifference;

namespace HammingDifferenceTest
{
    public class HammingDifferenceTest
    {
        private HammingDifference hamming;

        public HammingDifferenceTest()
        {
            hamming = new HammingDifference();
        }

        [Fact]
        public void ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => hamming.Difference("A", "AB"));    
        }

        [Fact]
        public void EmptyStrings()
        {
            Assert.Equal(0, hamming.Difference(string.Empty, string.Empty));
        }

        [Fact]
        public void SingleCharacter()
        {
            Assert.Equal(0, hamming.Difference("A", "A"));
            Assert.Equal(1, hamming.Difference("A", "B"));
        }

        [Fact]
        public void MultipleCharacters()
        {
            Assert.Equal(0, hamming.Difference("ABCDE", "ABCDE"));
            Assert.Equal(2, hamming.Difference("ABCDE", "ADCBE"));
            Assert.Equal(5, hamming.Difference("ABCDE", "FGHIJ"));
        }
    }
}
