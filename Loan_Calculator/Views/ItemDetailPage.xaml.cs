using Loan_Calculator.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Loan_Calculator.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}