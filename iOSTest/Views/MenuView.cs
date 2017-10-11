using System.Globalization;
using Core.ViewModels;
using CoreGraphics;
using MvvmCross.iOS.Support.XamarinSidebar;
using MvvmCross.iOS.Support.XamarinSidebar.Views;
using MvvmCross.iOS.Views;
using MvvmCross.Platform;
using UIKit;

namespace iOSTest.Views
{
    [MvxSidebarPresentation(MvxPanelEnum.Left, MvxPanelHintType.PushPanel, false)]
    public class MenuView : MvxViewController<MenuViewModel>, IMvxSidebarMenu
    {
        private CGColor _borderColor = new CGColor(45, 177, 128);
        private readonly UIColor _backgroundColor = UIColor.FromRGB(140, 176, 116);
        private readonly UIColor _textColor = UIColor.Black;

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            View.BackgroundColor = _backgroundColor;
            EdgesForExtendedLayout = UIRectEdge.None;

            var label = new UILabel
            {
                Frame = new CGRect(10f, 30f, MenuWidth, 20f),
                TextColor = _textColor,
                Font = UIFont.FromName("Helvetica", 20f),
                Text = "Меню",
                TextAlignment = UITextAlignment.Center
            };
            Add(label);

            var i = 0;
            foreach (var item in ViewModel.MenuItems)
            {
                var itemButton = new UIButton();
                itemButton.Frame = new CGRect(10, 100+i, MenuWidth, 20);
                itemButton.SetTitle(item.Title, UIControlState.Normal);
                itemButton.TitleLabel.Font = UIFont.FromName("Helvetica", 20f);
                itemButton.TitleLabel.TextColor = _textColor;
                itemButton.BackgroundColor = _backgroundColor;
                itemButton.TouchUpInside += delegate
                {
                    item.Navigate.Execute();
                    Mvx.Resolve<IMvxSidebarViewController>().CloseMenu();
                };
                i += 30;
                Add(itemButton);
            }         
        }

        public void MenuWillOpen(){}

        public void MenuDidOpen(){}

        public void MenuWillClose(){}

        public void MenuDidClose(){}

        private int MaxMenuWidth = 300;
        private int MinSpaceRightOfTheMenu = 55;

        public bool AnimateMenu => true;
        public bool DisablePanGesture => false;
        public float DarkOverlayAlpha => 0;
        public bool HasDarkOverlay => false;
        public bool HasShadowing => true;
        public UIImage MenuButtonImage => new UIImage("menu.png");
        public int MenuWidth => UserInterfaceIdiomIsPhone ?
            int.Parse(UIScreen.MainScreen.Bounds.Width.ToString(CultureInfo.InvariantCulture)) - MinSpaceRightOfTheMenu : MaxMenuWidth;
        public bool ReopenOnRotate => true;
        private bool UserInterfaceIdiomIsPhone => UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone;
    }
}


