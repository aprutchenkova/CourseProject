using MyApp.Models;
using MyApp.Views;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using System.Windows;
using MyApp.Database;
using Microsoft.EntityFrameworkCore;

namespace MyApp.ViewModels
{
    public class ThemeSelectionViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Theme> Themes { get; set; }

        private Theme selectedTheme;
        public Theme SelectedTheme
        {
            get => selectedTheme;
            set
            {
                selectedTheme = value;
                OnPropertyChanged(nameof(SelectedTheme));
            }
        }

        public ICommand SelectThemeCommand { get; }
        public ICommand GoBackCommand { get; }

        public ThemeSelectionViewModel()
        {
            // Загружаем темы из базы данных
            LoadThemesFromDatabase();

            SelectThemeCommand = new RelayCommand(SelectTheme);
            GoBackCommand = new RelayCommand(GoBack);
        }

        private void LoadThemesFromDatabase()
        {
            using (var context = new AppDbContext())
            {
                // Загружаем темы и связанные слова из базы данных
                var themesFromDb = context.Themes.Include(t => t.Words).ToList();
                Themes = new ObservableCollection<Theme>(themesFromDb);
            }
        }
        private void SelectTheme(object parameter)
        {
            if (SelectedTheme != null)
            {
                var cardWindow = new CardWindow
                {
                    DataContext = new CardViewModel(SelectedTheme)
                };
                cardWindow.Show();
                var themeSelectionWindow = Application.Current.Windows.OfType<ThemeSelectionWindow>().FirstOrDefault();
                themeSelectionWindow?.Close();
            }
        }

        private void GoBack(object parameter)
        {
            var themeSelectionWindow = parameter as ThemeSelectionWindow;
            if (themeSelectionWindow != null)
            {
                var loginWindow = new LoginWindow
                {
                    DataContext = new LoginViewModel()
                };
                loginWindow.Show();
                themeSelectionWindow.Close();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}