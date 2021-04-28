using System;
using System.Text;
using System.Threading.Tasks;

namespace Hierarhy
{
    abstract class Printed_product
    {
        public int Pages { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }

        public abstract void GetInfo();
    }
}
