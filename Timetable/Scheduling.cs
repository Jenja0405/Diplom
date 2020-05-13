using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timetable
{
    static class Scheduling
    {
        static List<Klass> Klass = new List<Klass>() { };
        static List<Predmet> Predmet = new List<Predmet>() { };
        static List<Uchitel> Uchitel = new List<Uchitel>() { };
        static List<Kabinet> Kabinet = new List<Kabinet>() { };
        static List<string> Weekday = new List<string>() { };
        static List<string> NomerUroka = new List<string>() { };
        static List<Urok> Urok = new List<Urok>() { };

        public static void Sapolnenie(List<Klass> K, List<Predmet> P, List<Uchitel> U, List<Kabinet> Ka, List<string> W, List<string> N, List<Urok> Ur)
        {
            Klass = K; Predmet = P; Uchitel = U; Kabinet = Ka; Weekday = W; NomerUroka = N; Urok = Ur;
            foreach (Klass k in Klass)
            {   
                foreach (Predmet p in Predmet)  
                {
                    if (DBobjects.Entities.KlassPredmet.Where(q=>q.ID_Klass == k.ID_Klass && q.ID_Predmet == p.ID_Predmet).Count()>0)
                    foreach (Kabinet kab in Kabinet)
                    {  if(DBobjects.Entities.KabinetPredmet.Where(a=>a.ID_Kabinet == kab.ID_Kabinet && a.ID_Predmet == p.ID_Predmet).Count()>0)
                        foreach (Uchitel uc in Uchitel)
                        { if(DBobjects.Entities.UchitelKlassPredmet.Where(z=>z.ID_Uchitel == uc.ID_Uchitel &&   ))
                            foreach (string w in Weekday)
                            {
                                foreach (string nomer in NomerUroka)
                                {
                                    foreach (Urok ur in Urok) { }
                                }
                            }
                        }
                    }

                }

            }
        }
    }
}  

