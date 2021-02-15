using System;
using System.Collections.Generic;
using System.IO;
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

namespace SimpleFileShredder
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var fileCtr = new FileController();

            if (!fileCtr.Find("C:\\Users\\SAI-HOME\\Desktop\\Books"))
            {
                MessageBox.Show("Can't be found");
            }

            foreach (var file in fileCtr.GetFiles())
            {
                PathList.Items.Add(file);
            }
        }
    }
}
