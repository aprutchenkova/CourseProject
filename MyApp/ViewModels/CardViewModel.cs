using System.ComponentModel;
using System.Windows.Input;
using MyApp.Models;
using System.Collections.ObjectModel;
using MyApp.Views;

namespace MyApp.ViewModels
{
    public class CardViewModel : INotifyPropertyChanged
    {
        private Word currentWord;
        private int currentIndex;
        private ObservableCollection<Word> words;
        private bool isTranslationVisible;
        private bool isExampleSentenceVisible;

        public Word CurrentWord
        {
            get => currentWord;
            set
            {
                currentWord = value;
                OnPropertyChanged(nameof(CurrentWord));
            }
        }

        public bool IsTranslationVisible
        {
            get => isTranslationVisible;
            set
            {
                isTranslationVisible = value;
                OnPropertyChanged(nameof(IsTranslationVisible));
            }
        }

        public bool IsExampleSentenceVisible
        {
            get => isExampleSentenceVisible;
            set
            {
                isExampleSentenceVisible = value;
                OnPropertyChanged(nameof(IsExampleSentenceVisible));
            }
        }

        public ICommand NextCommand { get; }
        public ICommand PreviousCommand { get; }
        public ICommand ShowTranslationCommand { get; }
        public ICommand GoBackCommand { get; }

        public CardViewModel(Theme selectedTheme)
        {
            words = new ObservableCollection<Word>(selectedTheme.Words);
            currentIndex = 0;
            CurrentWord = words[currentIndex];

            NextCommand = new RelayCommand(Next);
            PreviousCommand = new RelayCommand(Previous);
            ShowTranslationCommand = new RelayCommand(ShowTranslation);
            GoBackCommand = new RelayCommand(GoBack);
        }

        private void Next(object parameter)
        {
            if (currentIndex < words.Count - 1)
            {
                currentIndex++;
                CurrentWord = words[currentIndex];
                IsTranslationVisible = false; // Скрываем перевод при переходе к следующему слову
                IsExampleSentenceVisible = false; // Скрываем перевод предложения
            }
        }

        private void Previous(object parameter)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                CurrentWord = words[currentIndex];
                IsTranslationVisible = false; // Скрываем перевод при переходе к предыдущему слову
                IsExampleSentenceVisible = false; // Скрываем перевод предложения
            }
        }

        private void ShowTranslation(object parameter)
        {
            IsTranslationVisible = !IsTranslationVisible; // Переключаем видимость перевода слова
            IsExampleSentenceVisible = IsTranslationVisible; // Перевод предложения появляется вместе с переводом слова
        }

        private void GoBack(object parameter)
        {
            // Логика для возврата на предыдущее окно
            var cardWindow = parameter as CardWindow;
            if (cardWindow != null)
            {
                var themeSelectionWindow = new ThemeSelectionWindow
                {
                    DataContext = new ThemeSelectionViewModel()
                };
                themeSelectionWindow.Show();
                cardWindow.Close();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}