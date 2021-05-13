using System;
using Xunit;
using FileWriterEvents.App;
using FluentAssertions;

namespace FileWriterEvents.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void FileWriterWritesToTestFile()
        {
            //Given
            var fileWriter = new FileWriter();
            //When
            string text = System.IO.File.ReadAllText(@"../test.txt");
            //Then
            text.Should().Be("PICKLERICK");
        }

        [Fact]
        public void TestName()
        {
        //Given
        var fileWriter = new FileWriter();
        //When
        string text = System.IO.File.ReadAllText(@"../test.txt");
        //Then
        text.Should().Be("PICKLERICK");
        }
    }
}
