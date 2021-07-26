using System;
using System.Collections;
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

namespace Csharp_Lecture85_Hashmap
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Hashtable hashtable;
        public MainWindow()
        {
            InitializeComponent();
            hashtable = new Hashtable();
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            //Add
            //hashtable.Add("Key1", "Value1");
            //hashtable.Add("Key2", "Value2");
            //hashtable.Add("Key3", "Value3");
            //hashtable.Add("Key4", "Value4");
            hashtable.Add(txtKey.Text, txtValue.Text);
            txtKey.Clear();
            txtValue.Clear();
        }

        private void removeBtn_Click(object sender, RoutedEventArgs e)
        {
            //Remove
            hashtable.Remove(txtKey.Text);
            txtKey.Clear();
            txtValue.Clear();
        }

        private void showallBtn_Click(object sender, RoutedEventArgs e)
        {
            ICollection icollection = hashtable.Keys;
            //Show All
            foreach (string key in icollection)
            {
                MessageBox.Show(hashtable[key].ToString());
            }
            MessageBox.Show("Count "+hashtable.Count);
        }

        private void clearBtn_Click(object sender, RoutedEventArgs e)
        {
            hashtable.Clear();
        }
    }
}
