using System.Windows.Forms;

namespace Specshell.WinForm.HiddenForm
{
    public class MainHiddenForm : PartialHiddenForm, IHiddenMainForm
    {
        public Form Form => this;
    }
}
