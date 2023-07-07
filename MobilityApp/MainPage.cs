using Mobility.Data.Context;
using MobilityApp.Pages;
using MobilityApp.Pages.EfCore;
using MobilityApp.Pages.ExternalService;

namespace MobilityApp
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        //Create

        private void EF_Core_Crud_Click(object sender, EventArgs e)
        {
        }

        private void External_Service_Click(object sender, EventArgs e)
        {
        }


        private void GoEfCore_Click(object sender, EventArgs e)
        {
            EfCorePage efCorePage = new EfCorePage();
            efCorePage.Show();
        }

        private void GoExternalService_Click(object sender, EventArgs e)
        {
            ExternalServicePage externalServicePage = new ExternalServicePage();
            externalServicePage.Show();
        }
    }
}