using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Программная_инженерия.Lab4
{
    public class ClickButton : Button
    {
        int mClicks;
        public int Clicks
        {
            get { return mClicks; }
        }

        protected override void OnClick(EventArgs e)
        {
            mClicks++;
            base.OnClick(e);
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            Graphics g = pevent.Graphics;
            SizeF stringsize;
            stringsize = g.MeasureString(Clicks.ToString(), Font, Width);
            g.DrawString(Clicks.ToString(), Font, SystemBrushes.ControlText, Width - stringsize.Width - 3, Height - stringsize.Height - 3);
        }
    }
}
