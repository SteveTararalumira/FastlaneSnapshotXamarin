// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace FastlaneSnapshotXamarin
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton ReverseButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField ReverseTextField { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (ReverseButton != null) {
                ReverseButton.Dispose ();
                ReverseButton = null;
            }

            if (ReverseTextField != null) {
                ReverseTextField.Dispose ();
                ReverseTextField = null;
            }
        }
    }
}