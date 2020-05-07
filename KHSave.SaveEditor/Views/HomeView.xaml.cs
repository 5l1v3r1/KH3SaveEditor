using KHSave.SaveEditor.Services;
using KHSave.SaveEditor.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace KHSave.SaveEditor.Views
{
    /// <summary>
    /// Interaction logic for UnloadedView.xaml
    /// </summary>
    public partial class HomeView : UserControl
    {
        public HomeView()
        {
            InitializeComponent();
        }

        private void Hyperlink_RequestNavigate(object sender, System.Windows.Navigation.RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }

        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);

            patronList.Children.Add(new Label()
            {
                Content = "Fetching the list of funders from the internet..."
            });

#if !DEBUG
            Task.Run(FetchAndPopulateSponsors());
#endif
        }

        private Func<Task> FetchAndPopulateSponsors()
        {
            return async () =>
            {
                try
                {
                    var patreonInfo = await new PatreonService(new DesktopAppIdentity()).GetPatreonInfo();
                    Application.Current.Dispatcher.Invoke(() => SetServerResponse(patreonInfo));
                }
                catch
                {
                    Application.Current.Dispatcher.Invoke(() =>
                    {
                        patronList.Children.Clear();
                        patronList.Children.Add(new Label()
                        {
                            Content = "Unable to retrieve the list of funders form internet."
                        });
                    });
                }
            };
        }

        private void SetServerResponse(Models.PatreonInfo patreonInfo)
        {
            var vm = DataContext as HomeViewModel;
            SetFundLink(vm, patreonInfo.PatreonUrl);
            SetSponsorList(vm, patreonInfo.Patrons);
            SetSponsorshipInfo(vm, patreonInfo.SponsorshipInfo);
        }

        private void SetFundLink(HomeViewModel vm, string fundUrl) =>
            vm.FundLink = fundUrl;

        private void SetSponsorList(HomeViewModel vm, IEnumerable<Models.PatronModel> sponsors)
        {
            var patronViews = sponsors
                .Select((patron, i) =>
                {
                    return new PatronView((i + 1) / 32.0, patron.Glow)
                    {
                        DataContext = new PatronViewModel(patron)
                    };
                })
                .Where(x => x != null);

            patronList.Children.Clear();
            foreach (var patronView in patronViews)
                patronList.Children.Add(patronView);
        }

        private void SetSponsorshipInfo(HomeViewModel vm, Models.SponsorshipInfo info)
        {
            vm.SponsorHeaderInfo = info.Title;
            vm.SponsorGoalDetails = info.Description;
            vm.SponsorStartGoal = info.StartGoal;
            vm.SponsorEndGoal = info.EndGoal;
            vm.SponsorCount = info.Count;
        }
    }
}
