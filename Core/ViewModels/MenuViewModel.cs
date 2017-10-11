using System;
using System.Collections.Generic;
using Core.Models;
using MvvmCross.Core.ViewModels;

namespace Core.ViewModels
{
	public class MenuViewModel : MvxViewModel
	{
		public List<MenuModel> MenuItems
		{
			get;
		}

		public MenuViewModel()
		{
		    MenuItems = new List<MenuModel>
		    {
		        new MenuModel {Title = "Settings", Navigate = NavigateCommandSettings},
		        new MenuModel {Title = "About", Navigate = NavigateCommandAbout}
		    };
		}

		private MvxCommand<Type> _navigateCommandSettings;
		public MvxCommand<Type> NavigateCommandSettings
		{
			get
			{
			    _navigateCommandSettings = _navigateCommandSettings ?? new MvxCommand<Type>((vm) =>
                {
                    ShowViewModel<SettingsViewModel>();
                });

                return _navigateCommandSettings;
			}
		}

	    private MvxCommand<Type> _navigateCommandAbout;
	    public MvxCommand<Type> NavigateCommandAbout
	    {
	        get
	        {
	            _navigateCommandAbout = _navigateCommandAbout ?? new MvxCommand<Type>((vm) =>
	            {
	                ShowViewModel<AboutViewModel>();
	            });

	            return _navigateCommandAbout;
	        }
	    }
    }
}
