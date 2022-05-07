using System;
using System.Collections.Generic;
using System.Text;
using ClinicManagementSystem.Forms.MainForms;

namespace ClinicManagementSystem.Forms.EventArguments
{
    public class PageControllingButtonClickedArgs : EventArgs
    {
        public MainFormType WindowType { set; get; }

        public UserLevel UserLevel { set; get; }

        public PageControllingButtonClickedArgs(MainFormType windowType, UserLevel userLevel)
        {
            WindowType = windowType;
            UserLevel = userLevel;
        }
    }
}
