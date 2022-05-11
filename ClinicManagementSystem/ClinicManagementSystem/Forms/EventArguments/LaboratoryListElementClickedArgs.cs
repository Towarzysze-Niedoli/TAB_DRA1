using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicManagementSystem.Forms.EventArguments
{
    public class LaboratoryListElementClickedArgs : EventArgs
    {
        public string TestName;
        public string Results;

        public LaboratoryListElementClickedArgs(string testName, string results)
        {
            TestName = testName;
            Results = results;
        }
    }
}
