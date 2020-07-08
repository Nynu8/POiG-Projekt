using POiG_Projekt.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace POiG_Projekt.ViewModel
{
    class CoursesViewModel : ViewModelBase
    {
        //mini model do prób
        public class Kurs
        {
            public string Przedmiot { get; set; }
            public string Grupa { get; set; }
            public string Semestr { get; set; }

            public Kurs(string p, string g, string s)
            {
                Przedmiot = p;
                Grupa = g;
                Semestr = s;
            }
        }

        List<Kurs> kursy = new List<Kurs>();

        public List<Kurs> Kursy
        {
            get
            {
                return kursy;
            }
            set
            {
                kursy = value;
                OnPropertyChanged(nameof(Kursy));
            }
        }
        public CoursesViewModel() 
        {
            Kurs k1 = new Kurs("Sieci", "1C", "4");
            Kursy.Add(k1);
            Kursy.Add(new Kurs("Bazy", "2F", "6"));
            Kursy.Add(new Kurs("POiG", "3H", "4"));
        }




    }
}
