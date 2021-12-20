using HandyControl.Controls;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : System.Windows.Window
    {
        public MainWindow()
        {
            InitializeComponent();
            dg.ItemsSource = new List<Model>() {
                new Model(){Index = 0 , Remark = "12345"},
                new Model(){Index = 2 , Remark = "sfdgfd"},
                new Model(){Index = 3 , Remark = "dgfdg"},
                new Model(){Index = 4 , Remark = "sfdsfdsf"},
            };
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            HandyControl.Controls.MessageBox.Show("xxxxx");
        }



    }


    public class Model
    {
        public bool IsSelected { get; set; }
        public int Index { get; set; }
        public string Remark { get; set; }
    }
}
