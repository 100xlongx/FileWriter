using System;
using Xunit;
using FileWriterEvents.App;
using FluentAssertions;

namespace FileWriterEvents.Tests
{
    public class CustomEventArgs_Tests
    {
        [Fact]
        public void Should_CreateNewCustomEventArgs_BeMessage() {
            var cust = new CustomEventArgs("message");

            cust.Message.Should().Be("message");
        }
    }
}