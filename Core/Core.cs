﻿using Xamarin.Forms;
using Core.Views;

namespace Core
{
	public class App : Application
	{
		public App (AppSetup setup)
		{
			AppContainer.Container = setup.CreateContainer();

			// The root page of your application
			MainPage = new NavigationPage(new ContactView());
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

