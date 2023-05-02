using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreatEnumsFlags
{
    class MyControl : Control
    {
        [Flags]//Bit Field Flags
        public enum MyFlags//Bit Fields //Bit Masks
        {
            //None = 0,
            Flag1 = 1,//dont start with 0 start with 1
            Flag2 = 2,
            Flag3 = 4,
        }
        //Flag member declaration
        private MyFlags _myFlags;

        //property access member
        public MyFlags MyFlagsYay
        {
            get { return _myFlags; }
            set
            {
                _myFlags = value;

                //if(_myFlags == MyFlags.None )
                if (_myFlags == 0)
                {
                    Debug.WriteLine("No flags set");
                    return;//if none then return 
                }
                //The bitwise AND operator ( & ) compares each bit of the first operand to the corresponding bit of the second operand. If both bits are 1, the corresponding result bit is set to 1. Otherwise, the corresponding result bit is set to 0.

                //001 
                if (( _myFlags & MyFlags.Flag1) == MyFlags.Flag1)
                {
                    Debug.WriteLine("Flag1 set");
                }

                //010
                if ((_myFlags & MyFlags.Flag2) == MyFlags.Flag2)
                {
                    Debug.WriteLine("Flag2 set");
                }

                //100
                if ((_myFlags & MyFlags.Flag3) == MyFlags.Flag3)
                {
                    Debug.WriteLine("Flag3 set");
                }
            }
        }
    }
}
