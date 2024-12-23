using MyApp.Database;
using MyApp.Models;
using MyApp.Views;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace MyApp.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        private string username;
        private string password;

        public string Username
        {
            get => username;
            set
            {
                username = value;
                OnPropertyChanged(nameof(Username));
            }
        }

        public string Password
        {
            get => password;
            set
            {
                password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        public ICommand LoginCommand { get; }
        public ICommand RegisterCommand { get; }

        public LoginViewModel()
        {
            LoginCommand = new RelayCommand(Login);
            RegisterCommand = new RelayCommand(Register);
        }

        private void Login(object parameter)
        {
            using (var context = new AppDbContext()) //using для автоматического освобождения ресурсов (закрытия соединения с базой данных) после выполнения
            {
                var passwordBox = parameter as PasswordBox;
                var user = context.Users.FirstOrDefault(u => u.Username == Username && u.Password == passwordBox.Password);
                if (user != null)
                {
                    var themeSelectionWindow = new ThemeSelectionWindow
                    {
                        DataContext = new ThemeSelectionViewModel()
                    };
                    themeSelectionWindow.Show();

                    var loginWindow = Application.Current.Windows.OfType<LoginWindow>().FirstOrDefault();
                    loginWindow?.Close();
                }
                else
                {
                    MessageBox.Show("Неверное имя пользователя или пароль.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void Register(object parameter)
        {
            var registrationWindow = new RegistrationWindow
            {
                DataContext = new RegistrationViewModel()
            };
            registrationWindow.Show();
            var loginWindow = Application.Current.Windows.OfType<LoginWindow>().FirstOrDefault();
            loginWindow?.Close();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}