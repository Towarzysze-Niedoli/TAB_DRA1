using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClinicManagementSystem.Forms.CustomElements
{
    public partial class OrderLabListElement : ListElement
    {
        private bool _isEnabled;
        public OrderLabListElement(int index, string name) : base(index)
        {
            InitializeComponent();
            this.UpperMainLabel.Text = name;
            _isEnabled = true;
        }

        protected override void ListElement_MouseDown(object sender, MouseEventArgs e)
        {
            if (_isEnabled)
            {
                SetNoHoverColor();
                if (Checkbox.Checked)
                {
                    Checkbox.Checked = false;
                }
                else
                {
                    Checkbox.Checked = true;
                }
                OnListElementClicked(new EventArguments.ListElementClickedArgs(_index));
            }
        }

        public void SetDisabled()
        {
            _isEnabled = false;
        }
    }
}
