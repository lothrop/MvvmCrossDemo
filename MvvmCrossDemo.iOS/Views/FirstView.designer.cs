// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace MvvmCrossDemo.iOS.Views
{
	[Register ("FirstView")]
	partial class FirstView
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton UiButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel UiLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField UiTextField { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (UiButton != null) {
				UiButton.Dispose ();
				UiButton = null;
			}
			if (UiLabel != null) {
				UiLabel.Dispose ();
				UiLabel = null;
			}
			if (UiTextField != null) {
				UiTextField.Dispose ();
				UiTextField = null;
			}
		}
	}
}
