using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using ClinicManagementSystem.Forms.EventArguments;

namespace ClinicManagementSystem.Forms.CustomElements
{
    public class ListElement : UserControl
    {
        public delegate void ElementClickedEventHandler(object source, ListElementClickedArgs args);
        public event ElementClickedEventHandler ListElementClicked;

        protected Color _inactiveColor = Color.FromArgb(0, 119, 182);
        protected Color _activeColor = Color.FromArgb(3, 4, 94);
        protected Color _hoverColor = Color.FromArgb(2, 62, 138);

        protected bool _status = false;
        protected int _index;

        public ListElement(int index)
        {
            InitializeComponent();
            _index = index;
        }

        public void SetNoHoverColor()
        {
            if (_status)
            {
                this.BackColor = _activeColor;
            }
            else
            {
                this.BackColor = _inactiveColor;
            }
        }

        public void ChangeStatus()
        {
            _status = !_status;
        }

        protected void ListElement_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = _hoverColor;
        }

        protected void ListElement_MouseLeave(object sender, EventArgs e)
        {
            SetNoHoverColor();
        }

        protected virtual void ListElement_MouseDown(object sender, MouseEventArgs e) {}

        protected void OnListElementClicked(ListElementClickedArgs args)
        {
            ListElementClicked.Invoke(this, args);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ListElement
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.Name = "ListElement";
            this.Size = new System.Drawing.Size(188, 188);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListElement_MouseDown);
            this.MouseLeave += new System.EventHandler(this.ListElement_MouseLeave);
            this.MouseHover += new System.EventHandler(this.ListElement_MouseHover);
            this.ResumeLayout(false);

        }
    }
}
