using System.Windows;
using Kurs.Services;

namespace Kurs.Windows
{
    public partial class AuthWindow : Window
    {
        private readonly WindowService _windowService;
        
        public AuthWindow()
        {
            InitializeComponent();
            _windowService = new WindowService();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            _windowService.OpenWindow<RegisterWindow>(this);
        }
    }
}