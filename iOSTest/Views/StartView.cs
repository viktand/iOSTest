using Core.ViewModels;
using MvvmCross.iOS.Views;

namespace iOSTest.Views
{
    public class StartView : MvxViewController<StartViewModel>
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            ViewModel.ShowMainView();
        }
    }
}