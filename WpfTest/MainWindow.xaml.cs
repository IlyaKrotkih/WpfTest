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

namespace WpfTest
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int number;
        List<SimpleObject> LstItems;

        public MainWindow()
        {
            InitializeComponent();
            number = 0;
            LstItems = new List<SimpleObject>();
            lstList.ItemsSource = LstItems;
            
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnClickMe_Click(object sender, RoutedEventArgs e)
        {
            LstItems.Add(new SimpleObject(++number));
            slider.Maximum = LstItems.Count;
            lstList.ItemsSource = LstItems;
        }

        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lstList.SelectedIndex = Convert.ToInt32(slider.Value);
        }
    }

    class SimpleObject
    {
        public int Value;
        public string ValueString { get { return this.Value.ToString(); } }
        public int ValueInt { get { return this.Value; }  }

        public SimpleObject(int value)
        {
            Value = value;
        }

        public override string ToString()
        {
            return "Значение объекта \"" + Value + "\"";
        }
    }
}
