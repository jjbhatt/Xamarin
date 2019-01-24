using System;
using NetworkExtension;
using UIKit;

namespace ConnectWifi
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

        partial void BtnConnect_TouchUpInside(UIButton sender)
        {
            int response = 0;

            response = ConnectWpa("Your SSID", "Your Pass");

            if(response >0)
            {
                lblStatus.Text = "Connected!";
                lblStatus.TextColor = UIColor.Green;

            }
            else
            {
                lblStatus.Text = "Not Connected!";
                lblStatus.TextColor = UIColor.Red;
            }
        }

        private int ConnectWpa(string ssid, string pass)
        {
            try
            {
                var wifiConfig = new NEHotspotConfiguration(ssid, pass, false) { JoinOnce = true };
                var wifiManager = new NEHotspotConfigurationManager();

                wifiManager.ApplyConfiguration(wifiConfig, (error) => { 
                
                    if(error !=null)
                    {
                        Console.WriteLine($"Error while connecting Wifi network {ssid}:{error}" );
                    }
                });

                Console.WriteLine("Connected!");
                return 1;
            }
            catch(Foundation.NSErrorException ext)
            {
                Console.WriteLine(ext.ToString());
                return 0;
            }
            catch(Exception ext)
            {
                Console.WriteLine(ext.ToString());
                return 0;
            }
        }
    }
}
