using System;

namespace FunctionalConsole
{
    class PipeExample
    {
        static int Method(int a) => a;

        static int Produce() => 0;

        static int Example()
        {
            var arg = Produce();

            var data = Method(arg);
             
            data = Method(data);

            return data;
        }

        static void Example1()
        {
            var arg = Produce();

            var data = Method(arg);

            data = Method(data);
        }
    }
}