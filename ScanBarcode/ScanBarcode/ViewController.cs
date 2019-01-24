using System;

using UIKit;
using ZXing.Mobile;
using ZXing;

namespace ScanBarcode
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
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        async partial void BtnScanBarcode_TouchUpInside(UIButton sender)
        {
            var scanner = new MobileBarcodeScanner();             scanner.AutoFocus();             scanner.TopText = "Hold the camera up to the barcode";             scanner.BottomText = "Wait for scanner to complete the scan";                          var options = new MobileBarcodeScanningOptions();             options.UseCode39ExtendedMode = true;             options.TryHarder = true;             options.AutoRotate = false;              var result = await scanner.Scan(new MobileBarcodeScanningOptions { AutoRotate = false });              if (result != null && !string.IsNullOrEmpty(result.Text))             {                 txtBarcodeText.Text = result.Text;             } 
        }
    }
}
