using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClinicManagementSystem.Forms.CustomElements;
using ClinicManagementSystem.Forms.EventArguments;

namespace ClinicManagementSystem.Forms.SideForms
{
    public partial class OrderLabForm : Form
    {
        private OrderLabListForm _orderLabListForm;
        public OrderLabForm()
        {
            InitializeComponent();

            _orderLabListForm = new OrderLabListForm();
            _orderLabListForm.ElementClicked += ListElementClicked;
            this.ListPanel.Controls.Add(_orderLabListForm);
            _orderLabListForm.Show();
            SetDocking();
        }

        private void SetDocking()
        {
            Dock = DockStyle.Fill;
            this.TopMost = true;
            this.TopLevel = false;
        }

        private void ListElementClicked(object source, ListElementClickedArgs args)
        {

        }

        public void SetDisabled()
        {
            _orderLabListForm.SetDisabled();
        }
    }
}
