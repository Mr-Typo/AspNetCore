using System;
using System.Linq;
using Microsoft.AspNet.Identity;
using Xunit;

namespace Microsoft.AspNet.Identity.InMemory.Test
{
    public static class UnitTestHelper
    {
        public static void IsSuccess(IdentityResult result)
        {
            Assert.NotNull(result);
            Assert.True(result.Succeeded);
        }

        public static void IsFailure(IdentityResult result)
        {
            Assert.NotNull(result);
            Assert.False(result.Succeeded);
        }

        public static void IsFailure(IdentityResult result, string error)
        {
            Assert.NotNull(result);
            Assert.False(result.Succeeded);
            Assert.Equal(error, result.Errors.First());
        }
    }
}