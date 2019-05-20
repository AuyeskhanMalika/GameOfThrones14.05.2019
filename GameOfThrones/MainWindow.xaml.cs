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
using static GameOfThrones.GetAllGotCharacters;
using Gecko;

namespace GameOfThrones
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //gotCharacters = GetAllGotCharacters.GetListOfGotCharacters();
            //var characterName = gotCharacters.Select(c => c.Name);
            //charactersListBox.ItemsSource = characterName;
        }

        private void charactersListMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            int counter = 0;
            foreach (var item in gotCharacters)
            {
                if (counter == charactersListBox.SelectedIndex)
                {
                    Characters characterInfo = new Characters(item);
                    characterInfo.Show();
                    return;
                }
                counter++;
            }
        }
        public static List<GotCharacters> GetListOfGotCharacters()
        {
            return JsonConvert.DeserializeObject<List<GotCharacters>>(Downloader.DataJsonFormat(ConfigurationManager.AppSettings["urlString"]));
        }

        private void characterNameTextBoxTextChanged(object sender, TextChangedEventArgs e)
        {
            if (findCharacterNameTextBox is null)
            {
                findCharacterNameTextBox.Text = "";
            }
            int index = 0;
            foreach (var person in gotCharacters)
            {
                if (person.Name.Contains(characterNameTextBox.Text))
                {
                    charactersListBox.Items[index] = person;
                }
                else
                {
                    charactersListBox.Items[index] = new EmptySpaces();
                }
                index++;
            }
        }
    }
}
