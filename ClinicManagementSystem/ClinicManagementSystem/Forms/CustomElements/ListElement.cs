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

        protected readonly MouseEventHandler MouseDownHandler;
        protected readonly EventHandler MouseLeaveHandler;
        protected readonly EventHandler MouseHoverHandler;

        protected Color _inactiveColor = Color.FromArgb(0, 119, 182);
        protected Color _activeColor = Color.FromArgb(3, 4, 94);
        protected Color _hoverColor = Color.FromArgb(2, 62, 138);

        protected bool _status = false;
        protected int _index;

        [Obsolete("Designer only", true)]
        public ListElement()
        {
            InitializeComponent();
            _index = -1;
        }

        public ListElement(int index)
        {
            MouseDownHandler = new MouseEventHandler(ListElement_MouseDown);
            MouseLeaveHandler = new EventHandler(ListElement_MouseLeave);
            MouseHoverHandler = new EventHandler(ListElement_MouseHover);

            InitializeComponent();
            _index = index;
        }

        public void SetNoHoverColor()
        {
            BackColor = _status ? _activeColor : _inactiveColor;
        }

        public void ChangeStatus()
        {
            _status = !_status;
        }

        protected void ListElement_MouseHover(object sender, EventArgs e)
        {
            BackColor = _hoverColor;
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
            SuspendLayout();
            // 
            // ListElement
            // 
            BackColor = _inactiveColor;
            Name = "ListElement";
            Size = new Size(188, 188);
            MouseDown += MouseDownHandler;
            MouseLeave += MouseLeaveHandler;
            MouseHover += MouseHoverHandler;
            ResumeLayout(false);

        }

        
    }
}
