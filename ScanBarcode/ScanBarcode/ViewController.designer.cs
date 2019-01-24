// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace ScanBarcode
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnScanBarcode { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtBarcodeText { get; set; }

        [Action ("BtnScanBarcode_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BtnScanBarcode_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnScanBarcode != null) {
                btnScanBarcode.Dispose ();
                btnScanBarcode = null;
            }

            if (txtBarcodeText != null) {
                txtBarcodeText.Dispose ();
                txtBarcodeText = null;
            }
        }
    }
}