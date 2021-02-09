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


        }

        public bool ShowTree(string adr)
        {
            if (!Directory.Exists(adr))
                return false;

            var directories = Directory.GetDirectories(adr);
            foreach(var dir in directories)
            {
                // Вызвать метод для каждой папки
                // Добавить папку в лист для удаления
                // Добавить папку в дерево
            }
            var files = Directory.GetFiles(adr);
            foreach(var file in files)
            {
                // Добавить файлы в дерево
                // Добавить файлы в лист для удаления
            }
            return true;
        }
    }
}
