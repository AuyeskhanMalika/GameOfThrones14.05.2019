using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace GameOfThrones
{
    /// <summary>
    /// Логика взаимодействия для Characters.xaml
    /// </summary>
    public partial class Characters : Window
    {
        public Characters(GotCharacters characters)
        {
            InitializeComponent();
            if (characters.Image != null)
            {
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(characters.Image);
                bitmap.EndInit();
                characterImage.Source = bitmap;
            }
            else
            {
                characterImage.Source = new BitmapImage(new Uri("noname.png"));
            }
            nameTextBlock.Text = "Name: " + characters.Name;
            genderTextBlock.Text = "Title: " + characters.Titles;
            houseTextBlock.Text = "Children: " + characters.Children;
            birthTextBlock.Text = "Allegience: " + characters.Allegiance;
            aliveTextBlock.Text = "Gender: " + characters.Gender;
            createdAtTextBlock.Text = "House: " + characters.House;
            createdAtTextBlock.Text = "Is Alive: " + characters.Alive;
            createdAtTextBlock.Text = "Created at: " + characters.CreatedAt;
            createdAtTextBlock.Text = "Date of birth: " + characters.Birth;
            createdAtTextBlock.Text = "Place of birth: " + characters.PlaceOfBirth;
            createdAtTextBlock.Text = "Date of death: " + characters.Death;
            createdAtTextBlock.Text = "Place of death: " + characters.PlaceOfDeath;
            createdAtTextBlock.Text = "Father: " + characters.Father;
            createdAtTextBlock.Text = "Mother: " + characters.Mother;
            createdAtTextBlock.Text = "Heir: " + characters.Heir;
        }
    }
}
