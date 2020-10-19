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
using DemoDBDataAccessLayer.DB;
using DemoDBDataAccessLayer.Data;
using System.Diagnostics.PerformanceData;
using DemoDBDataAccessLayer.Models;
using System.Collections.ObjectModel;
using System.Reflection;

namespace Demo_DB_UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        System.IO.DirectoryInfo ParentDirectory = new System.IO.DirectoryInfo(@"C:\Users\FIAE\Downloads\DemoDbMappe\DemoDBDataAccessLayer\Data\");
        public MainWindow()
        {
            InitializeComponent();
            getData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LoadData.Visibility = Visibility.Visible;
        }

        private void getData()
        {
            foreach (System.IO.FileInfo f in ParentDirectory.GetFiles())
            {
                if (f.Name.Contains("_") || f.Name.StartsWith("I"))
                    continue;
                createAndAddLabel(f.Name.Remove(f.Name.Length - 3));
            }
        }

        private void createAndAddLabel(string cName)
        {
            Label data = new Label();
            data.Content = cName;
            data.MouseDoubleClick += new MouseButtonEventHandler(LabelData_Click);
            data.MouseEnter += new MouseEventHandler(addLabelBorderOnOver);
            data.MouseLeave += new MouseEventHandler(clearLabelBorder);
            data.BorderThickness = new Thickness(4, 4, 4, 4);
            LoadData.Children.Add(data);
        }

        private void getDbConnection()
        {

        }

        private void LabelData_Click(object sender, EventArgs e)
        {
            string data = ((Label)sender).Content.ToString();
            switch (data)
            {
                case "AddressData":
                    insertInDataGrid(new AddressData());
                    break;
                case "PersonData":
                    insertInDataGrid(new PersonData());
                    break;
                case "CompanyData":
                    insertInDataGrid(new CompanyData());
                    break;
                default:
                    break;
            }
            dbData.Visibility = Visibility.Visible;
        }

        private void insertInDataGrid(IData data)
        {
            dbData.ItemsSource = data.SelectAll<dynamic>();
        }

        private void addLabelBorderOnOver(object sender, EventArgs e) { ((Label)sender).BorderBrush = Brushes.Black; }
        private void clearLabelBorder(object sender, EventArgs e) { ((Label)sender).BorderBrush = Brushes.Transparent; }
        
        private void test()
        {

        }
    }
    
}
