using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GalleryWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Image> Images { get; set; } = new ObservableCollection<Image>
        {
            new Image
            {
                Name="Burning Shadows",
                ImagePath="Images/burningShadows.jpg",
                Date=new DateTime(2020,9,9),
                Type=".jpg",
                Details="Shadows of refugees and migrants carrying their belongings are seen as they flee from a fire at the Moria camp on the Greek island of Lesbos on Sept. 9"
            },
            new Image
            {
                Name="Christmas Tree Farm",
                ImagePath="Images/christmastreefarm.jpg",
                Date=new DateTime(2020,9,19),
                Type=".jpg",
                Details="A burned Christmas Tree farm near Gates, Ore., in September. More than 5 million acres have burned in California, Oregon and Washington."
            },
            new Image
            {
                Name="Falcon 9",
                ImagePath="Images/falcon9.jpg",
                Date=new DateTime(2020,11,15),
                Type=".jpg",
                Details="A view of the SpaceX Falcon 9 rocket launch, as seen from the UCF Knights' stadium in Orlando on Nov. 15."
            },
            new Image
            {
                Name="Final Presidential Debate",
                ImagePath="Images/finalpresidentialdebate.jpg",
                Date=new DateTime(2020,10,22),
                Type=".jpg",
                Details="Passengers on a flight from Detroit watch the final presidential debate between President Trump and Joe Biden on Oct. 22. "
            },
            new Image
            {
                Name="Flower Lives Matter",
                ImagePath="Images/flowerLivesMatter.jpg",
                Date=new DateTime(2020,6,8),
                Type=".jpg",
                Details="A person holds flowers as demonstrators clash with police near the Seattle Police Department's East Precinct shortly after midnight on June 8. Earlier in the evening, a suspect drove into the crowd of protesters and shot one person, which happened after a day of peaceful protests across the city. Later, police and protesters clashed violently. "
            },
            new Image
            {
                Name="Kaaba",
                ImagePath="Images/kaaba.jpg",
                Date=new DateTime(2020,3,6),
                Type=".jpg",
                Details="An eerie emptiness enveloped the area surrounding the Kaaba in Mecca's Grand Mosque, Islam's holiest site, on March 6, as attendance at Friday prayers was hit by measures to protect against COVID-19."
            },
            new Image
            {
                Name="Kobe Bryant",
                ImagePath="Images/kobe.jpg",
                Date=new DateTime(2020,1,31),
                Type=".jpg",
                Details="The Los Angeles Lakers honor Kobe Bryant and daughter Gigi—two of nine people who died in a helicopter crash—by spotlighting two empty court-side seats at the Staples Center on Jan. 31."
            },
            new Image
            {
                Name="Protester",
                ImagePath="Images/protester.jpg",
                Date=new DateTime(2020,5,29),
                Type=".jpg",
                Details="A protester, wearing a shirt that reads \"Please Stop the Violence,\" is dragged near Brooklyn's Barclays Center on May 29, four days after George Floyd's killing."
            },
            new Image
            {
                Name="San Francisco",
                ImagePath="Images/sanfrancisco.jpg",
                Date=new DateTime(2020,9,9),
                Type=".jpg",
                Details="Dark orange skies hang over the San Francisco skyline, as seen from Treasure Island, on Sept. 9, due to multiple wildfires burning across California and Oregon."
            },
            new Image
            {
                Name="Ships",
                ImagePath="Images/ships.jpg",
                Date=new DateTime(2020,10,2),
                Type=".jpg",
                Details="Five luxury cruise ships are seen while being broken down for scrap metal at the Aliaga ship recycling port in Izmir, Turkey, on Oct. 2. As the global pandemic slowed the multi-billion dollar cruise industry, and with public confidence in cruise vacations down after a series of outbreaks, some operators have been forced to cut losses and retire ships earlier than planned. The crisis, however, has bolstered the year's intake of ships at this port."
            },
            new Image
            {
                Name="Taal Volcano",
                ImagePath="Images/taalvolcano.jpg",
                Date=new DateTime(2020,1,14),
                Type=".jpg",
                Details="Dead trees near the Taal volcano's crater are covered in volcanic ash on Jan. 14."
            },
            new Image
            {
                Name="Thirsty Koala",
                ImagePath="Images/thirstykoala.jpg",
                Date=new DateTime(2020,1,16),
                Type=".jpg",
                Details="A fire-response volunteer pours water on a koala injured in a bushfire on Kangaroo Island, South Australia, on Jan. 16. It was quickly hustled to a nearby shelter, joining hundreds of other animals receiving care."
            },
        };

        public MainWindow()
        {
            InitializeComponent();
            GalleryLstbox.ItemsSource = Images;
        }

        private void GalleryLstbox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Page1 page1 = new Page1();
            GalleryLstbox.Visibility = Visibility.Hidden;
            page1.Visibility = Visibility.Visible;
            var img = GalleryLstbox.SelectedItem as Image;
            page1.NameTxtblockFrame.Text = img.Name;
        }
    }
}
