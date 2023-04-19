using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class WeatherstackResponse
    {
        public Request Request { get; set; }
        public Location Location { get; set; }
        public Current Current { get; set; }
        public int StatusCode { get; set; }
    }
}
