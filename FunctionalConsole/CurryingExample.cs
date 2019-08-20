using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalConsole
{
    public class CurryingExample
    {
        public void Execute()
        {
            var persist = new Store("persist");

            Save(persist, 3, 10);
            Save(persist, 3, 25);
        }
    
        private bool Save(Store store, int attempts, int value) => store.Save(attempts, value);
    }
}