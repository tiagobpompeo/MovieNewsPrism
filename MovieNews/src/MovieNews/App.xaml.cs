using System.Threading.Tasks;
using MovieNews.Views;
using Prism;
using Prism.Ioc;
using Unity;
using Prism.Unity;
using Prism.Logging;
using Xamarin.Forms;

namespace MovieNews
{
    public partial class App : PrismApplication
    {
       

        public App(IPlatformInitializer initializer): base(initializer)
        {
        }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("NavigationPage/MainPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            //containerRegistry.RegisterForNavigation<TabbedPage>();
            containerRegistry.RegisterForNavigation<MainPage>();
            containerRegistry.RegisterForNavigation<MoviesDetails>();
        }
     
    }
}
