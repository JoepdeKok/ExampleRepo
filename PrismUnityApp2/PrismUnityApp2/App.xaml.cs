using Prism.Unity;
using PrismUnityApp2.Views;

namespace PrismUnityApp2
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            NavigationService.NavigateAsync("MasterDetail/Navigation/MainPage");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<MainPage>();
            Container.RegisterTypeForNavigation<Page1>();
            Container.RegisterTypeForNavigation<Page2>();
            Container.RegisterTypeForNavigation<MasterDetail>();
            Container.RegisterTypeForNavigation<Navigation>();
        }
    }
}
