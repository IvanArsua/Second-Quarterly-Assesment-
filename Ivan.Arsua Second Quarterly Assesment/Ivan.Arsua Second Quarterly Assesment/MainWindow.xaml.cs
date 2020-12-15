using System;
using System.Net;
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
using RestSharp;
using Newtonsoft.Json;

namespace Ivan.Arsua_Second_Quarterly_Assesment
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var url = "http://newsapi.org/v2/top-headlines?" +
            "country=ph&" +
            "category=business" +
            "apiKey=21abf07344d6405e8b0c8a04d2de23b8";

            var json = new WebClient().DownloadString(url);

            Console.WriteLine(json);
        }

        
        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
        
           
    }
}
