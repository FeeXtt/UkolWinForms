using Microsoft.VisualBasic.Logging;
using UkolWinFormsProRadu;

namespace DatabaseViewForm;

public partial class StartForm : Form
{
    private UserView userView;
    private NavigationView navigationView;
    private LoginView loginView;
    private LanguageView languageView;
    private RegistrationView registrationView;
    public string Password;
    private UserControl _currentView;
    

    public enum ViewType
    {
        User,
        Navigation,
        Login,
        Language,
        Registration,
    }

    public StartForm()
    {
        InitializeComponent();
        userView = new UserView(this);
        navigationView = new NavigationView(this);
        loginView = new LoginView(this);
        languageView = new LanguageView(this);
        registrationView = new RegistrationView(this);
        
        SelectView(ViewType.Login);
    }

    public void RenderCurrentView()
    {
        this.Controls.Clear();
        this.Controls.Add(_currentView);
    }

    public void SelectView(ViewType viewType)
    {
        _currentView = viewType switch
        {
            ViewType.User => userView,
            ViewType.Navigation => navigationView,
            ViewType.Login => loginView,
            ViewType.Language => languageView,
            ViewType.Registration => registrationView,

        };
        RenderCurrentView();
    }
}