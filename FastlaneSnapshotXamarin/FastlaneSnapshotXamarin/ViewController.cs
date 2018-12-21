using System;

using UIKit;
using System.Linq;

namespace FastlaneSnapshotXamarin
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr intPtr) : base(intPtr)
        {

        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            ReverseButton.TouchUpInside += ReverseButton_TouchUpInside;
        }

        public override void ViewDidUnload()
        {
            base.ViewDidUnload();
            ReverseButton.TouchUpInside += ReverseButton_TouchUpInside;
        }

        private void ReverseButton_TouchUpInside(object sender, EventArgs e)
        {
            var originalText = ReverseTextField.Text;
            var reversedText = Reverse(originalText);

            ShowDialog(originalText, reversedText);
        }

        private String Reverse(String source)
        {
            var result = new String(source.Reverse().ToArray());
            return result;
        }

        private void ShowDialog(String originalString, String reversedString)
        {
            var alertView = CreateAlertView(originalString, reversedString);
            alertView.Show();
        }

        private UIAlertView CreateAlertView(String originalString, String reversedString)
        {
            var alertView = new UIAlertView();
            alertView.Title = "Result";
            alertView.Message = $"Original string: {originalString} \n Reversed string: {reversedString}";
            alertView.AddButton("OK");

            return alertView;
        }
    }
}
