using Cirrious.MvvmCross.Binding.BindingContext;
using Cirrious.MvvmCross.Touch.Views;
using DwxDemo.Core.ViewModels;
using UIKit;

namespace DwxDemo.iOS.Views
{
    public partial class FirstView : MvxViewController
    {
        public FirstView() : base("FirstView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var set = this.CreateBindingSet<FirstView, FirstViewModel>();
            set.Bind(UiLabel).To(vm => vm.MyProperty);
            set.Bind(UiTextField).To(vm => vm.MyProperty);
            set.Bind(UiButton).To(vm => vm.MyCommand);
            set.Apply();

            var tap = new UITapGestureRecognizer(() => UiTextField.ResignFirstResponder());
            View.AddGestureRecognizer(tap);
        }
    }
}