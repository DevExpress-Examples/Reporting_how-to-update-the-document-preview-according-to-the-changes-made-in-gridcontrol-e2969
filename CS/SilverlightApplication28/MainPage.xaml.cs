using System;
using System.Windows;
using System.Windows.Controls;
using DevExpress.Xpf.Printing;
using DevExpress.Xpf.Grid;

namespace SilverlightApplication28 {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e) {
            PrintableControlLink link = new PrintableControlLink((TableView)gridControl1.View);
            LinkPreviewModel model = new LinkPreviewModel(link);
            documentPreview1.Model = model;
            link.CreateDocument(true);
        }
    }
}
