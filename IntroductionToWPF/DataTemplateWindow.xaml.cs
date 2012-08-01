using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using IntroductionToWPF.Models;

namespace IntroductionToWPF
{
    /// <summary>
    /// Interaction logic for DataTemplateWindow.xaml
    /// </summary>
    public partial class DataTemplateWindow : Window
    {
        public DataTemplateWindow()
        {
            InitializeComponent();
            DataContext = new List<Task>
                              {
                                  new Task { Name = "t1", Description = "t1", Priority = "1" },
                                  new Task { Name = "t2", Description = "t2", Priority = "2" },
                                  new Task { Name = "t3", Description = "t3", Priority = "3" }
                              };
        }
    }
}
