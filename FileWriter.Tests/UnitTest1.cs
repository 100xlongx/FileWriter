using System;
using Xunit;
using FileWriterEvents.App;
using FluentAssertions;

namespace FileWriterEvents.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var fileWriter = new FileWriter();

            string text = System.IO.File.ReadAllText(@"../test.txt");

            text.Should().Be("PICKLERICK");
        }
    }
}
