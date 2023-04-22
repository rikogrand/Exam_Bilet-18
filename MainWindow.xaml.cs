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

namespace exam_Korondenko
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public JewerlyDB jewerlyData
        {
            get; set;
        }
        = new JewerlyDB();
        public MainWindow()
        {
            InitializeComponent();
            jewerlyData.Initialize();
            DataContext = this;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var search = jewerlyData.jewerlyList.Where(s => s.Name.ToLower().Contains(searchTextBox.Text.ToLower()));
            jewerlyGrid.ItemsSource = search;
        }
    }
}
