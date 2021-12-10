namespace Specshell.WinForm.HiddenForm;

public class PartialHiddenForm : Form
{
    protected override CreateParams CreateParams => base.CreateParams.Hidden();
}

public static class CreateParamsExtension
{
    public static CreateParams Hidden(this CreateParams baseParams)
    {
        const int wsPopup = unchecked((int) 0x80000000);
        const int wsExToolwindow = 0x80;

        var cp = baseParams;
        cp.ExStyle = wsExToolwindow;
        cp.Style = wsPopup;
        cp.Height = 0;
        cp.Width = 0;
        return cp;
    }
}
