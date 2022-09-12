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

        public object[] AdditionalParams { get; set; }

        public PageControllingButtonClickedArgs(MainFormType windowType, UserLevel userLevel, params object[] additionalParams)
        {
            WindowType = windowType;
            UserLevel = userLevel;
            AdditionalParams = additionalParams;
        }
    }
}
