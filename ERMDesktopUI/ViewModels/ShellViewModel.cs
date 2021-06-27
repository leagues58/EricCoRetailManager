using Caliburn.Micro;
using ERMDesktopUI.EventModels;

namespace ERMDesktopUI.ViewModels
{
    public class ShellViewModel : Conductor<object>, IHandle<LogOnEvent>
    {
        private SalesViewModel _salesViewModel;
        private SimpleContainer _container;
        private IEventAggregator _events;

        public ShellViewModel(SalesViewModel salesVM, IEventAggregator events, SimpleContainer container)
        {
            _events = events;
            _salesViewModel = salesVM;
            _container = container;

            _events.Subscribe(this);
            ActivateItem(_container.GetInstance<LoginViewModel>());
        }

        public void Handle(LogOnEvent message)
        {
            ActivateItem(_salesViewModel);
        }
    }
}
