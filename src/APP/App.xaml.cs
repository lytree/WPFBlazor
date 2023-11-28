using APP.Helper;
using HandyControl.Tools;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace APP
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class AppStart : Application
	{
#pragma warning disable IDE0052
		[SuppressMessage("ReSharper", "NotAccessedField.Local")]
		private static Mutex AppMutex;
#pragma warning restore IDE0052
		public AppStart()
		{

			var cachePath = $"{AppDomain.CurrentDomain.BaseDirectory}Cache";
			if (!Directory.Exists(cachePath))
			{
				Directory.CreateDirectory(cachePath);
			}
			ProfileOptimization.SetProfileRoot(cachePath);
			ProfileOptimization.StartProfile("Profile");


		}
		protected override void OnStartup(StartupEventArgs e)
		{
			AppMutex = new Mutex(true, "APP", out var createdNew);
			if (!createdNew)
			{
				var current = Process.GetCurrentProcess();

				foreach (var process in Process.GetProcessesByName(current.ProcessName))
				{
					if (process.Id != current.Id)
					{
						Win32Helper.SetForegroundWindow(process.MainWindowHandle);
						break;
					}
				}
				Shutdown();
			}
			else
			{
				var splashScreen = new SplashScreen("Resources/Img/Cover.png");
				splashScreen.Show(true);

				base.OnStartup(e);

				ApplicationHelper.IsSingleInstance();

				ShutdownMode = ShutdownMode.OnMainWindowClose;

				ConfigHelper.Instance.SetWindowDefaultStyle();
				ConfigHelper.Instance.SetNavigationWindowDefaultStyle();


				ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
			}

			base.OnStartup(e);
		}
		protected override void OnExit(ExitEventArgs e)
		{

			base.OnExit(e);
		}
	}
}
