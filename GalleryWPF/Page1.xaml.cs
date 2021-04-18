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
        private string path;

        public string Path
        {
            get { return path; }
            set { path = value; }
        }

        private string name;

        public string NameofPhoto
        {
            get { return name; }
            set { name = value; }
        }


        public Page1()
        {
            InitializeComponent();
            Window.GetWindow(this);
            //FrameImage.Source = path;
            NameTxtblockFrame.Text = NameofPhoto;
        }
    }
}
