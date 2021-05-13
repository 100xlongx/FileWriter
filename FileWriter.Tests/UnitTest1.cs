using System;
using Xunit;
using FileWriterEvents.App;
using FluentAssertions;

namespace FileWriterEvents.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Should_CreateNewFileWriter_FileNameShouldBeTest() {
            var pub = new Publisher();
            var fileWriter = new FileWriter("test", pub);

            fileWriter.FileName.Should().NotBeNull();
            fileWriter.FileName.Should().Be("test");
        }

        [Fact]
        public void FileWriterWritesToTestFile()
        {
            //Given
            var pub = new Publisher();
            var fileWriter = new FileWriter("test.txt", pub);
            //When
            string text = System.IO.File.ReadAllText(@"../test.txt");
            //Then
            text.Should().Be("PICKLERICK");
        }

        // [Fact]
        // public void Should_WriteTextToFile_BePICKLERICK()
        // {
        //     //Given
        //     var pub = new Publisher();
        //     var fileWriter = new FileWriter("test.txt", pub);
        //     //When
        //     string text = System.IO.File.ReadAllText(@"../test.txt");
        //     //Then
        //     text.Should().Contain("PICKLERICK");
        // }
    }
}
