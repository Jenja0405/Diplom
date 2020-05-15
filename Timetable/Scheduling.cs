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
        static List<int> NomerUroka = new List<int>() { };
        static List<Urok> Urok = new List<Urok>() { };

        public static List<Urok> Sapolnenie(List<Klass> K, List<Predmet> P, List<Uchitel> U, List<Kabinet> Ka, List<string> W, List<int> N, List<Urok> Ur)
        {
            Klass = K; Predmet = P; Uchitel = U; Kabinet = Ka; Weekday = W; NomerUroka = N; Urok = Ur;
            foreach (Klass k in Klass)
            {   
                foreach (Predmet pr in Predmet)  
                {
                    if (DBobjects.Entities.KlassPredmet.Where(q=>q.ID_Klass == k.ID_Klass && q.ID_Predmet == pr.ID_Predmet).Count()>0)
                    foreach (Kabinet kab in Kabinet)
                    {
                            if (DBobjects.Entities.KabinetPredmet.Where(a=>a.ID_Kabinet == kab.ID_Kabinet && a.ID_Predmet == pr.ID_Predmet).Count()>0)
                        foreach (Uchitel uc in Uchitel)
                        {
                                    if (DBobjects.Entities.UchitelKlassPredmet.Where(z=>z.KlassPredmet.ID_Predmet== pr.ID_Predmet).Count()>0)
                            foreach (string w in Weekday)
                            {
                                            if (DBobjects.Entities.Urok.Where(l => l.ID_Klass == k.ID_Klass && l.ID_Predmet==pr.ID_Predmet).Count()<pr.KlassPredmet.FirstOrDefault(f=>f.ID_Predmet==pr.ID_Predmet&&f.ID_Klass==k.ID_Klass).UrokovVNedelyu)
                              foreach (int nomer in NomerUroka)
                                { 
                                             if(DBobjects.Entities.Urok.Where(v => v.Weekday==w && v.ID_Klass== k.ID_Klass && v.ID_Predmet== pr.ID_Predmet).Count()<3)
                                    foreach (Urok ur in Urok.ToArray())
                                                        {if(DBobjects.Entities.Urok.Where(h=>h.Nomer_uroka == nomer && h.Weekday==w).Count() == 0)
                                                            {
                                                                ur.ID_Uchitel = uc.ID_Uchitel;
                                                                ur.ID_Predmet = pr.ID_Predmet;
                                                                ur.ID_Kabinet = kab.ID_Kabinet;
                                                                ur.Weekday = w;
                                                                ur.Nomer_uroka = nomer;
                                                                Urok.Add(ur);
                                                            }
                                                        }
                                }
                            }
                        }
                    }

                }

            }
            return Urok;
        }
      
    }

}  

