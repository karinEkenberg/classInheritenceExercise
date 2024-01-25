/*
 Exempel 1. Skriv en konsolapplikation för ett exempel på klass arv.
 */
namespace klass_arv
{
    internal class Program
    {
        public class ExampleClass
        {
            public string example;
            public ExampleClass()
            {
                this.example = example;
            }

            public void Method()
            {
                Console.WriteLine("Hello there!");
            }
        }

        public class  ExampleInheritance : ExampleClass
        {
            public string inheritence;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
