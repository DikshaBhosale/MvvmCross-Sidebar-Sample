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

namespace sidebar.iOS
{
	[Register ("MenuView")]
	partial class MenuView
	{
		[Outlet]
		UIKit.UILabel BigLabel { get; set; }

		[Outlet]
		UIKit.UITableView MenuTableView { get; set; }

		[Outlet]
		UIKit.UIImageView ProfileImage { get; set; }

		[Outlet]
		UIKit.UILabel SmallLabel { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (BigLabel != null) {
				BigLabel.Dispose ();
				BigLabel = null;
			}
			if (MenuTableView != null) {
				MenuTableView.Dispose ();
				MenuTableView = null;
			}
			if (ProfileImage != null) {
				ProfileImage.Dispose ();
				ProfileImage = null;
			}
			if (SmallLabel != null) {
				SmallLabel.Dispose ();
				SmallLabel = null;
			}
		}
	}
}
