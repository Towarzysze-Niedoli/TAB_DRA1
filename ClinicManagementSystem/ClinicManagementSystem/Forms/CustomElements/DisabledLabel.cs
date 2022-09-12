using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace ClinicManagementSystem.Forms.CustomElements
{
    class DisabledLabel : Label
    {
        public DisabledLabel()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            Enabled = false;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if(!Enabled)
            {
                SolidBrush drawBrush = new SolidBrush(this.ForeColor); 

                e.Graphics.DrawString(Text, Font, drawBrush, 0f, 0f);
            }
            else
            {
                base.OnPaint(e);
            }
        }
    }
}
