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

namespace Strategy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Dictionary<string, string> dictionary = new Dictionary<string, string>();
        double total = 0.0d;

        public MainWindow()
        {
            InitializeComponent();
            dictionary.Add("1", "正常收费");
            dictionary.Add("2", "满300返100");
            dictionary.Add("3", "打八折");
            cb.DisplayMemberPath = "Value";
            cb.SelectedValuePath = "Key";
            cb.ItemsSource = dictionary;
            cb.SelectedValue = "1";

            btnOK.Click += btnOK_Click;
        }

        void btnOK_Click(object sender, RoutedEventArgs e)
        {
            CashContext cc = new CashContext(cb.SelectedValue.ToString());
            double totalPrice = 0d;
            totalPrice = cc.GetResult(double.Parse(price.Text) * double.Parse(qty.Text));
            total += totalPrice;
            state.Items.Add("单价：" + price.Text + "数量：" + qty.Text + "合计：" + totalPrice);
            result.Content = total;
        }
    }
}
