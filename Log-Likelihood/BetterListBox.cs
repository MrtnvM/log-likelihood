using System.Windows.Forms;

namespace Log_Likelihood
{
    public class BetterListBox : ListBox
    {
        // Event declaration
        public delegate void BetterListBoxScrollDelegate(object sender, BetterListBoxScrollArgs e);
        public event BetterListBoxScrollDelegate Scroll;

        // WM_VSCROLL message constants
        private const int WM_VSCROLL = 0x0115;
        private const int SB_THUMBTRACK = 5;
        private const int SB_ENDSCROLL = 8;

        protected override void WndProc(ref Message m)
        {
            // Trap the WM_VSCROLL message to generate the Scroll event
            base.WndProc(ref m);
            if (m.Msg == WM_VSCROLL)
            {
                int nfy = m.WParam.ToInt32() & 0xFFFF;
                if (Scroll != null && (nfy == SB_THUMBTRACK || nfy == SB_ENDSCROLL))
                    Scroll(this, new BetterListBoxScrollArgs(this.TopIndex, nfy == SB_THUMBTRACK));
            }
        }
        public class BetterListBoxScrollArgs
        {
            // Scroll event argument
            public BetterListBoxScrollArgs(int top, bool tracking)
            {
                Top = top;
                Tracking = tracking;
            }
            public int Top { get; }

            public bool Tracking { get; }
        }
    }
}