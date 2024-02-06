﻿using FluentAssertions;
using ImportExtensions.UnitTests;
using System.Reflection;
using Xunit;

namespace ImportExtensions.UnitTests.Interface
{
#if !SKIP_TESTS
    public sealed class WhenExtensionMethod
    {
        [Fact]
        public void ShouldBeExtension()
        {
            MethodInfo method = typeof(ExampleClassExtensions).GetMethod(nameof(ExampleClassExtensions.ExtensionIMethod));
            ImportExtensionsCommand
                .IsExtensionMethod(method)
                .Should()
#if NET7_0_OR_GREATER
                .BeTrue();
#else
                .Be(true);
#endif
        }
    }
#endif
}
