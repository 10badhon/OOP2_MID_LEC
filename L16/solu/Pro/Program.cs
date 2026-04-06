using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro
{
    class Program
    {
        static void Main(string[] args)
        {
            // boxing unboxing is only in between ( value and reference type )
            int x = 100; 
            object obj = x;     // ✅ Boxing || Converting a value type → object (reference type) Happens automatically(implicit)
            int y = (int)obj;   // ✅ Unboxing || Converting object → value type Must be explicit (manual cast)
            
            // Value types (like int, double, bool, struct) and reference types (object or interfaces)

            // this is casting not boxing unboxing 
            int z = 100;
            double d = x;
            int f = (int)d;
        }
    }
}
