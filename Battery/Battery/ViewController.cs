using System;
using UIKit;
using Xamarin.Essentials;

namespace Battery
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

            // Register for battery changes, be sure to unsubscribe when needed
            Xamarin.Essentials.Battery.BatteryInfoChanged += Battery_BatteryInfoChanged;

            // Perform any additional setup after loading the view, typically from a nib.

            var level = Xamarin.Essentials.Battery.ChargeLevel; // returns 0.0 to 1.0 or 1.0 when on AC or no battery.

            var state= Xamarin.Essentials.Battery.State;

            switch (state)
            {
                case BatteryState.Charging:
                    // Currently charging
                   // txtStatus.Text = "Charging";
                    break;
                case BatteryState.Full:
                    // Battery is full
                    //txtStatus.Text = "Full";
                    break;
                case BatteryState.Discharging:
                case BatteryState.NotCharging:
                    // Currently discharging battery or not being charged
                    //txtStatus.Text = "Not Charging";
                    break;
                case BatteryState.NotPresent:
                    // Battery doesn't exist in device (desktop computer)
                    //txtStatus.Text = "Batter doesn't exist";
                    break;
                case BatteryState.Unknown:
                    // Unable to detect battery state
                    //txtStatus.Text = "Unable to detect battery state";
                    break;
            }

            var source = Xamarin.Essentials.Battery.PowerSource;

            switch (source)
            {
                case BatteryPowerSource.Battery:
                    // Being powered by the battery
                    //txtSource.Text = "PowerSource is battery";
                    break;
                case BatteryPowerSource.AC:
                    // Being powered by A/C unit
                    //txtSource.Text = "PowerSource is A/C Unit";
                    break;
                case BatteryPowerSource.Usb:
                    // Being powered by USB cable
                    //txtSource.Text = "PowerSource is USB Cable";
                    break;
                case BatteryPowerSource.Wireless:
                    // Powered via wireless charging
                    //txtSource.Text = "PowerSource is Wireless Charging";
                    break;
                case BatteryPowerSource.Unknown:
                    // Unable to detect power source
                    //txtSource.Text = "PowerSource is not able to detect";
                    break;
            }
        }

        private void Battery_BatteryInfoChanged(object sender, BatteryInfoChangedEventArgs e)
        {
            txtSource.Text = Convert.ToString(e.PowerSource);
            txtStatus.Text = Convert.ToString(e.State);
            txtChargeLevel.Text = Convert.ToString(e.ChargeLevel);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
