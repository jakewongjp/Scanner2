// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Scanner
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		UIKit.UIButton abc { get; set; }

		[Outlet]
		UIKit.UIButton btnScan { get; set; }

		[Outlet]
		UIKit.UIButton efg { get; set; }

		[Outlet]
		UIKit.UILabel outputlabel { get; set; }

		[Outlet]
		UIKit.UIButton xxx { get; set; }

		[Action ("btnClick_Scan:")]
		partial void btnClick_Scan (Foundation.NSObject sender);

		[Action ("ButtonCLick3:")]
		partial void ButtonCLick3 (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (abc != null) {
				abc.Dispose ();
				abc = null;
			}

			if (btnScan != null) {
				btnScan.Dispose ();
				btnScan = null;
			}

			if (efg != null) {
				efg.Dispose ();
				efg = null;
			}

			if (outputlabel != null) {
				outputlabel.Dispose ();
				outputlabel = null;
			}

			if (xxx != null) {
				xxx.Dispose ();
				xxx = null;
			}
		}
	}
}
