namespace UnoAuthTest.Presentation
{
    public class ShellViewModel
    {
        private readonly Func<IAuthenticationService> _authentication;
        private readonly IRegionManager regionManager;

        public ShellViewModel(
            Func<IAuthenticationService> authentication,
            IRegionManager regionManager)
        {
            _authentication = authentication;
            this.regionManager = regionManager;
            //_authentication.LoggedOut += LoggedOut;
            NavigateCommand = new DelegateCommand(ExecuteNavigateCommand);
            ResolveCommand = new DelegateCommand(OnResolveCommand);
        }

        public DelegateCommand NavigateCommand { get; }
        private void ExecuteNavigateCommand()
        {
            regionManager.RequestNavigate("ContentRegion", "ViewTest");
        }
        public DelegateCommand ResolveCommand { get; }
        private void OnResolveCommand()
        {
            var test = _authentication();
        }
    }
}
