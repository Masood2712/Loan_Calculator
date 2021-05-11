
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Loan_Calculator.Views
{
    [DesignTimeVisible(false)]
    public partial class info2 : ContentPage
    {
        public info2()
        {
            InitializeComponent();
            BindingContext = new ViewModels.info2ViewModel();
        }
    }
    
}