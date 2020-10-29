using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Demo_DB_UI
{
    /// <summary>
    /// Interaktionslogik für createLink.xaml
    /// </summary>
    public partial class createLink : Window
    {
        public createLink()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }

        public List<string> getValues()
        {
            List<string> values = new List<string>();
            values.Add(tbxLinkName.Text);
            values.Add(tbxLinkUrl.Text);
            return values;
        }
    }
}
