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


namespace GameOfThrones
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<GotCharacters> _gotCharacters;
        public MainWindow()
        {
            InitializeComponent();
            string result = string.Empty;
            using (var client = new WebClient())
            {
                result = client.DownloadString(ConfigurationManager.AppSettings["GotCharactersDownloadString"]);
            }
            _gotCharacters = JsonConvert.DeserializeObject<List<GotCharacters>>(result);
            _gotCharacters.ForEach(character => charactersListBox.Items.Add(character));
        }

        private void charactersListMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var selectedCharacterName = charactersListBox.SelectedItem.ToString();
        }

    }
}
