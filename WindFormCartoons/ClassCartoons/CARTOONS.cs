//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassCartoons
{
    using System;
    using System.Collections.Generic;
    
    public partial class CARTOONS
    {
        public CARTOONS()
        {
            this.COMPANY_CARTOONS = new HashSet<COMPANY_CARTOONS>();
            this.DIRACTORS_CARTOONS = new HashSet<DIRACTORS_CARTOONS>();
            this.GENRE_CARTOONS = new HashSet<GENRE_CARTOONS>();
        }
    
        public int CR_ID { get; set; }
        public string CR_NAME { get; set; }
        public string CR_ANNOTATION { get; set; }
        public Nullable<int> CR_YEAR { get; set; }
        public Nullable<float> CR_RATING { get; set; }
        public Nullable<int> CR_DURATION { get; set; }
        public int CR_CS { get; set; }
        public string CR_ADRESS { get; set; }
    
        public virtual DIC_CARTOON_STATUSES DIC_CARTOON_STATUSES { get; set; }
        public virtual ICollection<COMPANY_CARTOONS> COMPANY_CARTOONS { get; set; }
        public virtual ICollection<DIRACTORS_CARTOONS> DIRACTORS_CARTOONS { get; set; }
        public virtual ICollection<GENRE_CARTOONS> GENRE_CARTOONS { get; set; }
    }
}
