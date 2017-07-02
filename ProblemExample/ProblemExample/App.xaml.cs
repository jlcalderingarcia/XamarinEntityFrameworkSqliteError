using DataAccessTest;
using Xamarin.Forms;

namespace ProblemExample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();


            var databasePath = System.IO.Path.Combine(DependencyService.Get<Abstractions.IBasePathProvider>().BasePath, "rr.db");
            TestDatabase.TestDatabasePermissions(databasePath);


            MainPage = new ProblemExamplePage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
