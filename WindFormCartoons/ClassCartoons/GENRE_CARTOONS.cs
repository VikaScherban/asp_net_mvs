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
    
    public partial class GENRE_CARTOONS
    {
        public int GC_CR { get; set; }
        public int GC_GR { get; set; }
        public int GC_ID { get; set; }
    
        public virtual CARTOONS CARTOONS { get; set; }
        public virtual DIC_GENRE DIC_GENRE { get; set; }
    }
}
