using System.ComponentModel;
using System.Windows.Input;
using MyApp.Views;
using MyApp.Models;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows;
using MyApp.Database;

namespace MyApp.ViewModels
{
    public class RegistrationViewModel : INotifyPropertyChanged
    {
        private string username;
        private string password;
        private static List<User> users = new List<User>();

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

        public ICommand RegisterCommand { get; }
        public ICommand GoBackCommand { get; }

        public RegistrationViewModel()
        {
            RegisterCommand = new RelayCommand(Register);
            GoBackCommand = new RelayCommand(GoBack);
        }

        private void GoBack(object parameter)
        {
            var registerationWindow = parameter as RegistrationWindow;
            if (registerationWindow != null)
            {
                var loginWindow = new LoginWindow
                {
                    DataContext = new LoginViewModel()
                };
                loginWindow.Show();
                registerationWindow.Close();
            }
        }

        private void Register(object parameter)
        {
            // Проверяем, что логин и пароль введены
            var passwordBox = parameter as PasswordBox;
            if (string.IsNullOrWhiteSpace(Username) || string.IsNullOrWhiteSpace(passwordBox.Password))
            {
                MessageBox.Show("Данные не введены. Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            using (var context = new AppDbContext())
            {
                // Проверяем, существует ли уже пользователь с таким именем
                if (context.Users.Any(u => u.Username == Username))
                {
                    MessageBox.Show("Пользователь с таким именем уже существует.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                // Добавляем нового пользователя в базу данных
                var newUser = new User { Username = Username, Password = passwordBox.Password };
                context.Users.Add(newUser);
                context.SaveChanges();
            }

            // Открываем окно авторизации
            var loginWindow = new LoginWindow
            {
                DataContext = new LoginViewModel()
            };
            loginWindow.Show();
            var registrationWindow = Application.Current.Windows.OfType<RegistrationWindow>().FirstOrDefault();
            registrationWindow?.Close();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}