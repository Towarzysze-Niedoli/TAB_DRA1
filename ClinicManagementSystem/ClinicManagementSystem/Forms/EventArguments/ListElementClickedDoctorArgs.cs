using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicManagementSystem.Forms.EventArguments
{
    public class ListElementClickedDoctorArgs : EventArgs
    {
        public int Index;
        public string Name;
        public string Date;

        public ListElementClickedDoctorArgs(int index, string  name, string date)
        {
            Index = index;
            Name = name;
            Date = date;
        }
    }
}
