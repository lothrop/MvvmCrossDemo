// --------------------------------------------------------------------------------------------------------------------
// <summary>
//    Defines the FirstView type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace DwxDemo.iOS.Views
{
    using Cirrious.MvvmCross.Binding.BindingContext;

    using Core.ViewModels;
    using CoreGraphics;
    using Foundation;
    using UIKit;

    /// <summary>
    /// Defines the FirstView type.
    /// </summary>
    [Register("FirstView")]
    public class FirstView : BaseView
    {
        /// <summary>
        /// Views the did load.
        /// </summary>
        /// <summary>
        /// Called when the View is first loaded
        /// </summary>
        public override void ViewDidLoad()
        {
            this.View = new UIView { BackgroundColor = UIColor.White };

            base.ViewDidLoad();

            UILabel uiLabel = new UILabel(new CGRect(10, 10, 300, 40));
            View.AddSubview(uiLabel);
            UITextField uiTextField = new UITextField(new CGRect(10, 50, 300, 40));
            View.AddSubview(uiTextField);
            UIButton uiButton = new UIButton(new CGRect(10, 90, 300, 40));
            uiButton.SetTitle("Download", UIControlState.Normal);
            uiButton.SetTitleColor(UIColor.Blue, UIControlState.Normal);
            View.AddSubview(uiButton);

            var set = this.CreateBindingSet<FirstView, FirstViewModel>();
            set.Bind(uiLabel).To(vm => vm.MyProperty);
            set.Bind(uiTextField).To(vm => vm.MyProperty);
            set.Bind(uiButton).To(vm => vm.MyCommand);
            set.Apply();

            UITapGestureRecognizer tap = new UITapGestureRecognizer(() => uiTextField.ResignFirstResponder());
            View.AddGestureRecognizer(tap);
        }
    }
}
