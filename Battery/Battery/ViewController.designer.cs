// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace Battery
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblLevel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblPowerSource { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblStatus { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtChargeLevel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtSource { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtStatus { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (lblLevel != null) {
                lblLevel.Dispose ();
                lblLevel = null;
            }

            if (lblPowerSource != null) {
                lblPowerSource.Dispose ();
                lblPowerSource = null;
            }

            if (lblStatus != null) {
                lblStatus.Dispose ();
                lblStatus = null;
            }

            if (txtChargeLevel != null) {
                txtChargeLevel.Dispose ();
                txtChargeLevel = null;
            }

            if (txtSource != null) {
                txtSource.Dispose ();
                txtSource = null;
            }

            if (txtStatus != null) {
                txtStatus.Dispose ();
                txtStatus = null;
            }
        }
    }
}