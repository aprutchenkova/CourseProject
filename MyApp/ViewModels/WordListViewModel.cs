using MyApp.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Input;
using MyApp.Views;
using System.Windows;

namespace MyApp.ViewModels
{
    public class WordListViewModel : INotifyPropertyChanged
    {
        public List<Word> Words { get; set; }
        public ICommand StartCardCommand { get; }
        public ICommand GoBackCommand { get; }

        public WordListViewModel(Theme selectedTheme)
        {
            Words = selectedTheme.Words;
            StartCardCommand = new RelayCommand(StartCard);
            GoBackCommand = new RelayCommand(GoBack);
        }
        private void StartCard(object parameter)
        {
            var wordListWindow = parameter as Window;
            if (wordListWindow != null)
            {
                var cardWindow = new CardWindow
                {
                    DataContext = new CardViewModel(new Theme { Words = Words })
                };
                cardWindow.Show();
                wordListWindow.Close();
            }
        }

        private void GoBack(object parameter)
        {
            var wordListWindow = parameter as WordListWindow;
            if (wordListWindow != null)
            {
                var themeSelectionWindow = new ThemeSelectionWindow
                {
                    DataContext = new ThemeSelectionViewModel()
                };
                themeSelectionWindow.Show();
                wordListWindow.Close();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}