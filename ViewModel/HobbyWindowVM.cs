using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;
using MVVMHobby.Model;
using GalaSoft.MvvmLight.Command;
using System.Windows.Media.Imaging;

namespace MVVMHobby.ViewModel
{
    public class HobbyWindowVM : ViewModelBase
    {
        private Hobby selectedHobby;
        public Hobby SelectedHobby
        {
            get { return selectedHobby; }
            set
            {
                selectedHobby = value;
                RaisePropertyChanged("SelectedHobby");
            }
        }

        private ObservableCollection<Hobby> loadedHobbies = new ObservableCollection<Hobby>();
        public ObservableCollection<Hobby> LoadedHobbies
        {
            get { return loadedHobbies; }
            set
            {
                loadedHobbies = value;
                RaisePropertyChanged("LoadedHobbies");
            }
        }
        public HobbyWindowVM(List<Hobby> eenHobbyLijst)
        {
            if (eenHobbyLijst != null)
                foreach (var h in eenHobbyLijst)
                    LoadedHobbies.Add(h);
        }

        public RelayCommand LoadHobbiesCommand
        {
            get { return new RelayCommand(LoadHobbies); }
        }
        private void LoadHobbies()
        {
            LoadedHobbies.Add(new Hobby("muziek", "trompet", new BitmapImage(new Uri(@"\Images\trompet.jpg",
                UriKind.Relative))));
            LoadedHobbies.Add(new Hobby("muziek", "drum", new BitmapImage(new Uri(@"\Images\drum.jpg",
                UriKind.Relative))));
        }
        public RelayCommand DeleteHobbyCommand
        {
            get { return new RelayCommand(DeleteHobby); }
        }
        private void DeleteHobby()
        {
            LoadedHobbies.Remove(SelectedHobby);
        }
        public RelayCommand ChangeHobbyCommand
        {
            get { return new RelayCommand(ChangeHobby); }
        }
        private void ChangeHobby()
        {
            Hobby tennis = LoadedHobbies.FirstOrDefault(x => x.Activiteit.Equals("tennis"));
            if (tennis != null)
                tennis.Activiteit = "squash";
        }
        public RelayCommand NewListCommand
        {
            get { return new RelayCommand(NewList); }
        }
        private void NewList()
        {
            LoadedHobbies = new ObservableCollection<Hobby>();
            LoadedHobbies.Add(new Hobby("muziek", "gitaar", new BitmapImage(new Uri(@"\Images\gitaar.jpg",
                UriKind.Relative))));
            LoadedHobbies.Add(new Hobby("muziek", "piano", new BitmapImage(new Uri(@"\Images\piano.jpg",
                UriKind.Relative))));
        }
    }
}
