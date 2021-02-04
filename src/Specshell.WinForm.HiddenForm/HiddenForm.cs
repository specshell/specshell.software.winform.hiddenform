using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Specshell.WinForm.HiddenForm
{
    public class HiddenForm : PartialHiddenForm, IHiddenForm
    {
        public HiddenForm()
        {
            Load += HiddenForm_Load;
        }

        public Form Form => this;

        [DllImport("user32.dll")]
        private static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hwndNewParent);

        private void HiddenForm_Load(object? source, EventArgs e)
        {
            const int hwndMessage = -1;
            SetParent(Handle, new IntPtr(hwndMessage));
        }
    }
}
