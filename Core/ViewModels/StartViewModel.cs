using MvvmCross.Core.ViewModels;

namespace Core.ViewModels
{
    public class StartViewModel: MvxViewModel
    {
        public void ShowMainView()
        {
            ShowViewModel<MainViewModel>();
        }
    }
}