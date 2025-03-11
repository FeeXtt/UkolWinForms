using DatabaseViewForm;

namespace UkolWinFormsProRadu;

public partial class RegistrationView : UserControl
{
    private readonly StartForm _parentForm;
    public RegistrationView(StartForm _parentForm)
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        _parentForm.SelectView(StartForm.ViewType.Navigation); 
    }
}