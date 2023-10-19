using APP.Extensions;
using APP.Infrastructure.Constant;
using APP.Infrastructure.Events;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using CommunityToolkit.Mvvm.Messaging;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Fast.Components.FluentUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace APP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {


            var serviceCollection = new ServiceCollection();
            serviceCollection.AddWpfBlazorWebView();
            serviceCollection.AddBlazorWebViewDeveloperTools();
            serviceCollection.AddFluentUIComponents();
            var builder = new ContainerBuilder();

            builder.Populate(serviceCollection);
            builder.AddAppService();
            var autofac = new AutofacServiceProvider(builder.Build());
            Resources.Add("services", autofac);
            double x1 = SystemParameters.PrimaryScreenWidth * 0.6;//得到屏幕整体宽度
            double y1 = SystemParameters.PrimaryScreenHeight * 0.6;//得到屏幕整体高度
            this.Width = x1;//设置窗体宽度
            this.Height = y1;//设置窗体高度
            WindowsVariable.MainWindowHeight = this.Height;
            WindowsVariable.MainWindowWidth = this.Width;
            SizeChanged += OnWindowSizeChanged;
            AppDomain.CurrentDomain.UnhandledException += (sender, error) =>
            {
                System.Windows.MessageBox.Show($"程序崩溃请重启{error}", "Error");

            };
            InitializeComponent();
        }
        protected void OnWindowSizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (e.PreviousSize.Height != 0)
            {
                if (e.HeightChanged)
                {
                    WeakReferenceMessenger.Default.Send(new HeightChange(e.NewSize.Height));
                    WindowsVariable.MainWindowHeight = e.NewSize.Height;
                }
            }
            if (e.PreviousSize.Width != 0)
            {
                if (e.WidthChanged)
                {
                    WeakReferenceMessenger.Default.Send(new WidthChange(e.NewSize.Width));
                    WindowsVariable.MainWindowWidth = e.NewSize.Width;
                }
            }

        }
    }
}
