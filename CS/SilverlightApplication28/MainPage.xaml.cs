using System.Windows;
using System.Windows.Controls;
using DevExpress.Xpf.Grid;
using DevExpress.Xpf.Printing;

namespace SilverlightApplication28 {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e) {
            var link = new PrintableControlLink((TableView)gridControl1.View);
            var model = new LinkPreviewModel(link);
            documentPreview1.Model = model;
            link.CreateDocument(true);
        }
    }
}
