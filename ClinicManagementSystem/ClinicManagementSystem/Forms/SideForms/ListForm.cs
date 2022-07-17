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
    public partial class ListForm : Form
    {
        public delegate void DoctorElementClickedEventHandler(object source, ListElementClickedArgs args);

        public event DoctorElementClickedEventHandler ElementClicked;

        protected int _currentIndex = -1;

        protected List<ListElement> _elements;

        public ListForm()
        {
            InitializeComponent();

            Dock = DockStyle.Fill;
            this.TopMost = true;
            this.TopLevel = false;
            
            PopulateListExample();
        }

        /// <summary>
        /// Clears existing elements and sets the provided ones
        /// </summary>
        /// <param name="elements"></param>
        public void PopulateList(List<ListElement> elements)
        {
            ResetIndex();
            _elements = elements;
            ListFlowPanel.Controls.Clear();
            foreach (ListElement element in _elements)
            {
                element.ListElementClicked += OnElementClicked;
                ListFlowPanel.Controls.Add(element);
            }
        }

        public void Deselect()
        {
            if (_currentIndex >= 0)
                ChangeElementColoring();
            
            _currentIndex = -1;
        }

        protected virtual void PopulateListExample() { }

        protected void ResetIndex()
        {
            _currentIndex = -1;
        }

        protected void OnElementClicked(object source, ListElementClickedArgs args)
        {
            if (_currentIndex >= 0)
            {
                ChangeElementColoring();
            }

            _currentIndex = args.Index;
            ChangeElementColoring();

            ElementClicked.Invoke(this, args);
        }

        private void ChangeElementColoring()
        {
            _elements[_currentIndex].ChangeStatus();
            _elements[_currentIndex].SetNoHoverColor();
        }
    }
}
