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
    
    public partial class DIC_GENRE
    {
        public DIC_GENRE()
        {
            this.GENRE_CARTOONS = new HashSet<GENRE_CARTOONS>();
        }
    
        public int GR_ID { get; set; }
        public string GR_NAME { get; set; }
        public string GR_INFO { get; set; }
    
        public virtual ICollection<GENRE_CARTOONS> GENRE_CARTOONS { get; set; }
    }
}
