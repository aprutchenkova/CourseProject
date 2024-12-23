using MyApp.Database;
using MyApp.Views;
using MyApp.ViewModels;
using System.Windows;

namespace MyApp
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // Инициализация базы данных
            using (var context = new AppDbContext())
            {
                DatabaseInitializer.Initialize(context);
            }

            // Создаем и показываем окно логина
            var loginWindow = new LoginWindow
            {
                DataContext = new LoginViewModel()
            };
            loginWindow.Show();
        }
    }
}