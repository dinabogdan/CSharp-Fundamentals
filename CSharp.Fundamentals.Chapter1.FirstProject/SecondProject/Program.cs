using System;

namespace SecondProject
{
    class Program
    {
        static void Main(string[] args)
        {

            // Integer numeric types

            byte b = 0;
            sbyte sb = -128;
            ushort us = 100;
            short s = 100;
            uint ui = 0;
            int i = -128;
            ulong ul = 0;
            long l = -128;

            Console.WriteLine("Integer numeric types:");
            Console.WriteLine($"Variable: '{nameof(b)}' has type: {b.GetType()} and value: {b}");
            Console.WriteLine($"Variable: '{nameof(sb)}' has type: {sb.GetType()} and value: {sb}");
            Console.WriteLine($"Variable: '{nameof(us)}' has type: {us.GetType()} and value: {us}");
            Console.WriteLine($"Variable: '{nameof(s)}' has type: {s.GetType()} and value: {s}");
            Console.WriteLine($"Variable: '{nameof(ui)}' has type: {ui.GetType()} and value: {ui}");
            Console.WriteLine($"Variable: '{nameof(i)}' has type: {i.GetType()} and value: {i}");
            Console.WriteLine($"Variable: '{nameof(ul)}' has type: {ul.GetType()} and value: {ul}");
            Console.WriteLine($"Variable: '{nameof(l)}' has type: {l.GetType()} and value: {l}");
            Console.WriteLine();

            // Floating-point numeric types

            double d = 123456;
            float f = 123456789;
            var d1 = 123456d;
            var f1 = 123456789f;

            Console.WriteLine("Floating-point numeric types:");
            Console.WriteLine($"Variable: '{nameof(d)}' has type: {d.GetType()} and value: {d}");
            Console.WriteLine($"Variable: '{nameof(f)}' has type: {f.GetType()} and value: {f}");
            Console.WriteLine($"Variable: '{nameof(d1)}' has type: {d1.GetType()} and value: {d1}");
            Console.WriteLine($"Variable: '{nameof(f1)}' has type: {f1.GetType()} and value: {f1}");
            Console.WriteLine();

            // Decimal numeric type

            decimal x = 10.0M;
            Console.WriteLine("Decimal numeric type:");
            Console.WriteLine($"Variable: '{nameof(x)}' has type: {x.GetType()} and value: {x}");

            // Boolean type

            var _true = true;
            var _false = false;

            Console.WriteLine("Boolean type:");
            Console.WriteLine($"Variable: '{nameof(_true)}' has type: {_true.GetType()} and value: {_true}");
            Console.WriteLine($"Variable: '{nameof(_false)}' has type: {_false.GetType()} and value: {_false}");
            Console.WriteLine();

            // Text types

            var _char = 'x';
            var _string = "Some long characters array";

            Console.WriteLine("Text types:");
            Console.WriteLine($"Variable: '{nameof(_char)}' has type: {_char.GetType()} and value: {_char}");
            Console.WriteLine($"Variable: '{nameof(_string)}' has type: {_string.GetType()} and value: {_string}");



        }
    }
}
