using System;
using Xunit;
using FillPrintProject;

namespace FillPrintTest
{
    public class FillPrintTest
    {
        [Fact]
        public void PrintsEmptyString()
        {
            var fp = new FillPrint(0);
            Assert.Equal(String.Empty, fp.Print());
        }

        [Fact]
        public void PrintSingleValue()
        {
            var fp = new FillPrint(1);
            Assert.Equal(fp[0].ToString(), fp.Print());
        }

        [Fact]
        public void PrintMultipleValues()
        {
            var fp = new FillPrint(3);
            Assert.Equal($"{fp[0]}, {fp[1]}, {fp[2]}", fp.Print());
        }
    }
}
