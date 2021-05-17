using FileWriter.App;
using FluentAssertions;
using Xunit;

namespace FileWriter.Tests
{
    public class DisplayServiceTests
    {
        [Theory]
        [InlineData("id1")]
        [InlineData("id2")]
        [InlineData("id3")]
        public void DisplayService_ShouldSetId_WhenConstructed(string id)
        {
            //Given
            var pub = new FileWriters();
            var service = new DisplayService(id, pub);

            //When
            pub.RaiseInsertMessageEvent("Message","file");
            //Then
            service.Id().Should().Be(id);
        }
    }
}