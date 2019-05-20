using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Gecko;

namespace GameOfThrones
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<GotCharacters> gotCharacters;
        public MainWindow()
        {
            InitializeComponent();
            gotCharacters = GetDataService.GetListOfGotCharacters();
            var characterName = gotCharacters.Select(c => c.Name);
            charactersListBox.ItemsSource = characterName;
        }

        private void charactersListMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var selectedCharacterName = charactersListBox.SelectedItem.ToString();

            var selectedCharacter = gotCharacters.FirstOrDefault(c => c.Name == selectedCharacterName);

            Characters characterWindow = new Characters(selectedCharacter);
            characterWindow.ShowDialog();
        }

        private void characterNameTextBoxTextChanged(object sender, TextChangedEventArgs e)
        {
            var charactersName = gotCharacters.Select(c => c.Name);
            var sortedCharacters = charactersName.Where(c => c.ToLower().Contains(findCharacterNameTextBox.Text.ToLower()));

            charactersListBox.ItemsSource = sortedCharacters;
        }
    }
}
