using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;
using MVVMHobby.Model;

namespace MVVMHobby
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            List<Hobby> hobbyLijst = new List<Hobby>();
            hobbyLijst.Add(new Hobby("sport", "voetbal", new BitmapImage(new Uri(@"\Images\voetbal.jpg",
                UriKind.Relative))));
            hobbyLijst.Add(new Hobby("sport", "atletiek", new BitmapImage(new Uri(@"\Images\atletiek.jpg",
                UriKind.Relative))));
            hobbyLijst.Add(new Hobby("sport", "basketbal", new BitmapImage(new Uri(@"\Images\basketbal.jpg",
                UriKind.Relative))));
            hobbyLijst.Add(new Hobby("sport", "tennis", new BitmapImage(new Uri(@"\Images\tennis.jpg",
                UriKind.Relative))));
            hobbyLijst.Add(new Hobby("sport", "turnen", new BitmapImage(new Uri(@"\Images\turnen.jpg",
                UriKind.Relative))));

            ViewModel.HobbyWindowVM vm = new ViewModel.HobbyWindowVM(hobbyLijst);
            View.HobbyWindow hobbyWindow = new View.HobbyWindow();
            hobbyWindow.DataContext = vm;
            hobbyWindow.Show();
        }
    }
}
