using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using GalaSoft.MvvmLight;

namespace MVVMHobby.Model
{
    public class Hobby : INotifyPropertyChanged
    {
        private string categorieValue;
        public string Categorie
        {
            get { return categorieValue; }
            set
            {
                categorieValue = value;
                RaisePropertyChanged("Categorie");
            }
        }
        private string activiteitValue;
        public string Activiteit
        {
            get { return activiteitValue; }
            set
            {
                activiteitValue = value;
                RaisePropertyChanged("Activiteit");
            }
        }
        public BitmapImage Symbool { get; set; }

        public Hobby(string categorie, string activiteit, BitmapImage symbool)
        {
            Categorie = categorie;
            Activiteit = activiteit;
            Symbool = symbool;
        }
        private void RaisePropertyChanged(string info)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(info));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
