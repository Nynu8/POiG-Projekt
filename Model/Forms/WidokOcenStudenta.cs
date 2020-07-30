using POiG_Projekt.DAL.Encje;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace POiG_Projekt.Model.Forms
{
    class WidokOcenStudenta
    {
        public static string brakOceny = "Brak";
        public sbyte ID { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string ObecnaOcena { get; set; }
        public string NowaOcena { get; set; }
        public sbyte IdKursuOceny { get; set; } 
        public WidokOcenStudenta(Student s, sbyte id_kursu)
        {
            WidokStudenta student = new WidokStudenta(s);
            ID = student.ID;
            Imie = student.Imie;
            Nazwisko = student.Nazwisko;
            int i = 0;
            while (i<student.Oceny.Count && student.Oceny[i].Id_kurs != id_kursu)
                i++;
            if (i == student.Oceny.Count)
            {
                ObecnaOcena = brakOceny;
                NowaOcena = brakOceny;
            } 
            else
            {
                ObecnaOcena = student.Oceny[i].Wartosc;
                NowaOcena = student.Oceny[i].Wartosc;
            }
            IdKursuOceny = id_kursu;
        }
    }
}
