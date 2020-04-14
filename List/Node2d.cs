using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace risovalka.List
{
    public class L2Node
    {
        public Bitmap Value { get; set; }
        public L2Node Next { get; set; }
        public L2Node Previous { get; set; }

        public L2Node()
        {
            Next = null;
            Previous = null;
        }

        public L2Node(Bitmap value)
        {
            Value = value;
            Next = null;
            Previous = null;
        }
    }
}
