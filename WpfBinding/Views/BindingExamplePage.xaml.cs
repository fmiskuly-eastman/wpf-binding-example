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
using WpfBinding.ViewModels;

namespace WpfBinding.Views
{
    /// <summary>
    /// Interaction logic for BindingExamplePage.xaml
    /// </summary>
    public partial class BindingExamplePage : Page
    {
        public BindingExampleViewModel ViewModel { get; set; }
        public BindingExamplePage(BindingExampleViewModel bindingExampleViewModel)
        {
            ViewModel = bindingExampleViewModel;
            DataContext = ViewModel;
            InitializeComponent();
        }
    }
}
