//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Timetable
{
    using System;
    using System.Collections.Generic;
    
    public partial class Uchitel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Uchitel()
        {
            this.UchitelKlassPredmet = new HashSet<UchitelKlassPredmet>();
            this.Urok = new HashSet<Urok>();
        }
    
        public int ID_Uchitel { get; set; }
        public string Familia { get; set; }
        public string Imya { get; set; }
        public string Otchestvo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UchitelKlassPredmet> UchitelKlassPredmet { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Urok> Urok { get; set; }
        public override string ToString() => Familia + " " + Imya + " " + Otchestvo;
    }
}
