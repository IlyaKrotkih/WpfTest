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

        public MainWindow()
        {
            number = 0;
            InitializeComponent();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnClickMe_Click(object sender, RoutedEventArgs e)
        {
            lstList.Items.Add("Добавлено значение " + (++number).ToString());
            slider.Maximum = lstList.Items.Count;
        }

        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lstList.SelectedIndex = Convert.ToInt32(slider.Value);
        }
    }

    class SimpleObject
    {
        public string Value { get; }

        public SimpleObject(string value)
        {
            Value = value;
        }

        public override string ToString()
        {
            return "Значение объекта \"" + Value + "\"";
        }
    }
}
