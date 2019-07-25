using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinDemo.ViewModels;

namespace XamarinDemo
{
    public partial class StupidPage : ContentPage
    {
        public StupidPage()
        {
            InitializeComponent();
            BindingContext = new StupidPageViewModel();
        }
    }
}
