using FileWriter.App;
using FluentAssertions;
using Xunit;

namespace FileWriter.Tests
{
    public class CustomEventArgsTests
    {
        [Fact]
        public void Should_CreateNewCustomEventArgs_BeMessage()
        {
            var cust = new FileWriteComplete("message");

            cust.Message.Should().Be("message");
        }
    }
}