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
    
    public partial class DIC_COMPANY
    {
        public DIC_COMPANY()
        {
            this.COMPANY_CARTOONS = new HashSet<COMPANY_CARTOONS>();
        }
    
        public int CP_ID { get; set; }
        public string CP_NAME { get; set; }
        public string CP_INFO { get; set; }
        public int CP_CT { get; set; }
    
        public virtual ICollection<COMPANY_CARTOONS> COMPANY_CARTOONS { get; set; }
        public virtual DIC_COUNRTY DIC_COUNRTY { get; set; }
    }
}
