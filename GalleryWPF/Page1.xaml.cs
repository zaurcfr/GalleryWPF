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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GalleryWPF
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public int selectedIndex { get; set; }

        public Page1()
        {
            InitializeComponent();

        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
        }

        private void prevBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MainWindow main = new MainWindow();
                var prevIndex = selectedIndex - 1;
                selectedIndex = prevIndex;
                var prevItem = main.GalleryLstbox.Items[prevIndex] as Image;
                NameTxtblockFrame.Text = prevItem.Name + " " + prevItem.Date.ToShortDateString();
                fsImage.Source = new BitmapImage(new Uri(prevItem.ImagePath, UriKind.Relative));
                detailsTxtblck.Text = prevItem.Details;
            }
            catch (Exception)
            {
                MessageBox.Show("There is no previous image");
            }
        }

        private void nextBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MainWindow main = new MainWindow();
                var nextIndex = selectedIndex + 1;
                selectedIndex = nextIndex;
                var prevItem = main.GalleryLstbox.Items[nextIndex] as Image;
                NameTxtblockFrame.Text = prevItem.Name + " " + prevItem.Date.ToShortDateString();
                fsImage.Source = new BitmapImage(new Uri(prevItem.ImagePath, UriKind.Relative));
                detailsTxtblck.Text = prevItem.Details;
            }
            catch (Exception)
            {
                MessageBox.Show("There is no next image");
            }
        }
    }
}
