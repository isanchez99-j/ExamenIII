using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Supabase;

namespace NotasApp
{
    public partial class App : Application
    {
        static Client supabase;
        static string key;
        static string url;

        async void InitSupa()
        {
            var options = new SupabaseOptions
            {
                AutoConnectRealtime = true
            };

            supabase = new Client(App.Url, App.Key, options);
            await supabase.InitializeAsync();
        }
        public static Client Supa

        { get { return supabase; } }
        public static string Key
        { get { return key; } }
        public static string Url
        { get { return url; } }

        public App()
        {
            InitializeComponent();
            url = "https://obgwukvrsqrlibiiqpgi.supabase.co";
            key = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6Im9iZ3d1a3Zyc3FybGliaWlxcGdpIiwicm9sZSI6ImFub24iLCJpYXQiOjE2ODE0MTA0MzMsImV4cCI6MTk5Njk4NjQzM30.Bh-l7Cffj8N-FWfyNpLSOyDJ5V-aTsJ6jt7NE5fLOiE";
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            base.OnStart();
            InitSupa();
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
