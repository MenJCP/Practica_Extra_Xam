using Practica_Extra_Xam.ViewModels;
using Practica_Extra_Xam.Views;
using Prism;
using Prism.Ioc;
using Prism.Unity;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Practica_Extra_Xam
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();
            await NavigationService.NavigateAsync(new System.Uri("/NavigationPage/HomeTabbed/HomePage", System.UriKind.Relative));
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<HomeTabbed>();
            containerRegistry.RegisterForNavigation<HomePage,HomeViewModel>();
        }
    }
}
