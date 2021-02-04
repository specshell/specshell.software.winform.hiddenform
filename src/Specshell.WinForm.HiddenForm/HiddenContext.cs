using System.Windows.Forms;

namespace Specshell.WinForm.HiddenForm
{
    public class HiddenContext : ApplicationContext
    {
        public HiddenContext(IHiddenMainForm hiddenForm)
        {
            MainForm = hiddenForm.Form;
        }
    }
}
