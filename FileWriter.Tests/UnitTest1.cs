using System.IO;
using FileWriter.App;
using FluentAssertions;
using FluentAssertions.Events;
using Xunit;

namespace FileWriter.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Should_CreateNewFileWriter_FileNameShouldBeTest()
        {
            var pub = new Publisher();
            var fileWriter = new FileWriters("test", pub);

            fileWriter.FileName.Should().NotBeNull();
            fileWriter.FileName.Should().Be("test");
        }

        [Fact]
        public void FileWriterWritesToTestFile()
        {
            //Given
            var pub = new Publisher();

            var fileWriter = new FileWriters("test.txt", pub);
            //When
            var text = File.ReadAllText(@"../../../../text.txt");
            //Then
            text.Should().NotBeEmpty();
        }

        [Fact]
        public void Event_ShouldBeRaised_WhenDoSomethingIsCalled()
        {
            //Given
            var pub = new Publisher();
            var sub = new FileWriters("text", pub);
            //When
            //Then
            using (IMonitor<Publisher> monitoredSubject = pub.Monitor())
            {
                pub.RaiseInsertMessageEvent("This Is Message");
                monitoredSubject.Should().Raise("RaiseCustomEvent");
            }
        }
    }
}