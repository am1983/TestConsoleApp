using System;
using Xunit;

namespace TestConsoleApp.Tests
{
    public class ConfirmationTests
    {
        [Fact]
        public void ConfirmsAssertionTrue()
        {
          Assert.True(true);
        }

        [Fact]
        public void IntentionalFailure()
        {
          Assert.True(false);
        }
    }
}
