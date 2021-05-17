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
        public void FileWriterWritesToTestFile()
        {
            //Given
            var pub = new FileWriters();
            var sub = new DisplayService("id",pub);
            pub.RaiseInsertMessageEvent("This is Message","text");
            
            //When
            var text = File.ReadAllText(@"../../../../text.txt");
            //Then
            text.Should().NotBeEmpty();
        }

        [Fact]
        public void Event_ShouldBeRaised_WhenDoSomethingIsCalled()
        {
            //Given
            var pub = new FileWriters();
            //When
            //Then
            using (IMonitor<FileWriters> monitoredSubject = pub.Monitor())
            {
                pub.RaiseInsertMessageEvent("This Is Message","text");
                monitoredSubject.Should().Raise("RaiseCustomEvent");
            }
        }
    }
}