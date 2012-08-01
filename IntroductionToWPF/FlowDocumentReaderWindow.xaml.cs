using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace IntroductionToWPF
{
    /// <summary>
    /// Interaction logic for flowDocumentReader.xaml
    /// </summary>
    public partial class FlowDocumentReaderWindow : Window
    {
        public FlowDocumentReaderWindow()
        {
            InitializeComponent();

            // Open the file that contains the FlowDocument
            using (FileStream xamlFile = new FileStream("AFlowDocument.xaml", FileMode.Open, FileAccess.Read))
            {
                // Parse the file with the XamlReader.Load method
                FlowDocument content = XamlReader.Load(xamlFile) as FlowDocument;

                // Set the Document property to the parsed FlowDocument object
                this.flowDocumentReader.Document = content;
            }
        }
    }
}
