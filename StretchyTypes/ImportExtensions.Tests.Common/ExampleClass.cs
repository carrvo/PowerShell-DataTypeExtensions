﻿using ImportExtensions.UnitTests.Generic;

namespace ImportExtensions.UnitTests
{
    public interface IExampleClass
    {
        string Method(string name);
    }
    public class ExampleClass : IExampleClass
    {
        public string Method(string name)
        {
            return $"Hello {name} from {nameof(Method)}";
        }

        public static string StaticMethod(string name)
        {
            return $"Hello {name} from {nameof(StaticMethod)}";
        }
    }

    public static class ExampleStatic
    {
        public static string StaticMethod(ExampleClass example, string name)
        {
            return $"Hello {name} from {nameof(StaticMethod)}";
        }
    }

    public static class ExampleClassExtensions
    {
        public static string StaticMethod(ExampleClass example, string name)
        {
            return $"Hello {name} from {nameof(StaticMethod)}";
        }

        public static string StaticIMethod(IExampleClass example, string name)
        {
            return $"Hello {name} from {nameof(StaticIMethod)}";
        }

        public static string ExtensionMethod(this ExampleClass example, string name)
        {
            return $"Hello {name} from {nameof(ExtensionMethod)}";
        }

        public static string ExtensionIMethod(this IExampleClass example, string name)
        {
            return $"Hello {name} from {nameof(ExtensionIMethod)}";
        }

        public static string ExtensionProperty(this ExampleClass example)
        {
            return $"Hello from {nameof(ExtensionProperty)}";
        }
    }
}