using Core.ViewModels;
using CoreGraphics;
using MvvmCross.iOS.Support.XamarinSidebar;
using MvvmCross.iOS.Views;
using UIKit;

namespace iOSTest.Views
{
    [MvxSidebarPresentation(MvxPanelEnum.Center, MvxPanelHintType.ResetRoot, true)]
    public class MainView : MvxViewController<MainViewModel>
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            View.BackgroundColor = UIColor.LightGray;
            var label = new UILabel
            {
                Frame = new CGRect(10, 60, 200, 50),
                TextColor = UIColor.Magenta,
                Font = UIFont.FromName("Helvetica-Bold", 20f),
                Text = "MainWiew"
            };
            Add(label);
        }
    }
}