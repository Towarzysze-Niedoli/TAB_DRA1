using System;
using System.Collections.Generic;
using System.Text;
using ClinicManagementSystem.Forms.SideForms;

namespace ClinicManagementSystem.Forms.EventArguments
{
    public class VisitsButtonClickedArgs : EventArgs
    {
        public PerformVisitFormMode Mode;

        public VisitsButtonClickedArgs(PerformVisitFormMode mode)
        {
            Mode = mode;
        }
    }
}
