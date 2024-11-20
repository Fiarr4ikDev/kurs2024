using System.Windows;
using Kurs.Services;

namespace Kurs.Windows
{
    public partial class RegisterWindow : Window
    {
        private readonly WindowService _windowService;
        public RegisterWindow()
        {
            InitializeComponent();
            _windowService = new WindowService();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            _windowService.OpenWindow<AuthWindow>(this);
        }
    }
}