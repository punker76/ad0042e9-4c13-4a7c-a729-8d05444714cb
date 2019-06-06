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

namespace mahappsreprotest
{
    /// <summary>
    /// Interaction logic for subhamburger.xaml
    /// </summary>
    public partial class subhamburger : UserControl
    {
        public subhamburger()
        {
            InitializeComponent();
        }

        private void HamburgerMenuControl_ItemClick(object sender, MahApps.Metro.Controls.ItemClickEventArgs e)
        {
            // set the content
            HamburgerMenuControl2.Content = e.ClickedItem;
            // close the pane
            HamburgerMenuControl2.IsPaneOpen = false;
        }
    }
}
