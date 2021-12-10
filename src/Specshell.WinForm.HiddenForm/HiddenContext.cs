namespace Specshell.WinForm.HiddenForm;

public class HiddenContext : ApplicationContext
{
    public HiddenContext(IHiddenMainForm hiddenForm)
    {
        MainForm = hiddenForm.Form;
    }
}
