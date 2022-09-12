using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicManagementSystem.Forms.EventArguments
{
    public class ListElementClickedArgs : EventArgs
    {
        public int Index;

        public ListElementClickedArgs(int index)
        {
            Index = index;
        }
    }
}
