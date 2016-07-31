using System;
using System.Threading.Tasks;
using UIKit;

namespace Scanner
{
	public partial class ViewController : UIViewController
	{
		protected ViewController(IntPtr handle) : base(handle)
		{
			
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			// Second method----------------------------------
			// Need to create: void ClickABC(object sender, EventArgs e)
			// GO TO DECLARATION TO KNOW THE SIGNATURE
			abc.TouchDown += ClickABC;

			efg.TouchDown += (object sender, EventArgs e) =>
			{

				var tt = new UIAlertView("fgf", "fgdgfdfd", new UIAlertViewDelegate(), "b1", "b2", "b3");



				tt.Show();

			};





			xxx.TouchDown += (object sender, EventArgs e) => {

				nint result = 0;
				var alert = new UIAlertView
				{
					Title = "Title",
					Message = "MESSAGE"
				};

				alert.AddButton("OK");
				alert.AddButton("CANCEL");


				alert.Clicked += (s2, e2) => {



				
						outputlabel.Text = e2.ButtonIndex.ToString();
				
				
				};


				alert.Show();


			};




			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}


		void ClickABC(object sender, EventArgs e)
		{
			UIAlertView tt = new UIAlertView();
			tt.Title = "ABC";
			tt.Show();

		}



		// we used ACTION (iAction) the outlet method and print
		partial void ButtonCLick3(Foundation.NSObject sender)
		{
			UIAlertView tt = new UIAlertView();
			tt.Title = "test";
			tt.Show();
		}



		partial void btnClick_Scan(Foundation.NSObject sender)
		{

			var scanner = new ZXing.Mobile.MobileBarcodeScanner();
			var result = scanner.Scan();






			var ss = "dffdd;dffdfd;dfd";








		}




	}
}

