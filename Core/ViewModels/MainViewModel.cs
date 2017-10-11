using MvvmCross.Core.ViewModels;

namespace Core.ViewModels
{
	public class MainViewModel : MvxViewModel
	{	
		public void ShowMenu()
		{
			ShowViewModel<MenuViewModel>();
        }
    }
}

