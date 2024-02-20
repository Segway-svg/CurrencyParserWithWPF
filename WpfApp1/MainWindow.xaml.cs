using System.ComponentModel;
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
using WpfApp1.Models;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BindingList<ValueParserModel> _valueParserData;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ValueParserList_Loaded(object sender, RoutedEventArgs e)
        {
            _valueParserData = new BindingList<ValueParserModel>()
            {
                new ValueParserModel() { charCode = "USD", value = ValueParserModel.GetCurrencyData("USD")["USD"] },
                new ValueParserModel() { charCode = "EUR", value = ValueParserModel.GetCurrencyData("EUR")["EUR"] },
                new ValueParserModel() { charCode = "CNY", value = ValueParserModel.GetCurrencyData("CNY")["CNY"] }
            };

            ValueParserList.ItemsSource = _valueParserData;
        }
    }
}