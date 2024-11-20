using System.Windows;

namespace Kurs.Services
{
    public class WindowService
    {

        public void OpenWindow<TWindow>(Window currentWindow = null) where TWindow : Window, new()
        {
            var window = new TWindow();
            window.Show();
            currentWindow?.Close();
        }
    }
}