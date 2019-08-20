using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalConsole
{
    class PipeCurryingExample
    {
        static int Update(int a, int b, int c) => 14;
        static int Save(int a) => a;
        static int Import() => 0;
        static int Example()
        {
            var arg = Import();
            
            var data = Update(arg,5,10);

            data = Save(data);

            return data;
        }
    }
}