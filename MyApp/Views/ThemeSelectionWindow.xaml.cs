using System.Windows;
using System.Windows.Controls;
using MyApp.ViewModels;
using MyApp.Views;

namespace MyApp.Views
{
    public partial class ThemeSelectionWindow : Window
    {
        public ThemeSelectionWindow()
        {
            InitializeComponent();
            DataContext = new ThemeSelectionViewModel();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DataContext is ThemeSelectionViewModel viewModel && viewModel.SelectedTheme != null)
            {
                var wordListWindow = new WordListWindow
                {
                    DataContext = new WordListViewModel(viewModel.SelectedTheme)
                };
                wordListWindow.Show();
                this.Close();
            }
        }
    }
}