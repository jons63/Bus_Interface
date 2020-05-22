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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Bus_Interface
{
    /// <summary>
    /// Interaction logic for Serial.xaml
    /// </summary>
    public partial class Serial : Page
    {
        public Serial()
        {
            InitializeComponent();
        }
        // Custom constructor to pass expense report data
        public Serial(object data) : this()
        {
            // Bind to expense report data.
            this.DataContext = data;
        }
    }
}
