using System;
using MvvmCross.Core.ViewModels;

namespace Core.Models
{
	public class MenuModel
	{
		public String Title {
			get;
			set;
		}

		public MvxCommand<Type> Navigate {
			get;
			set;
		}
	}
}

