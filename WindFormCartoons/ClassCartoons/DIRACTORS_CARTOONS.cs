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
    
    public partial class DIRACTORS_CARTOONS
    {
        public int DK_CR { get; set; }
        public int DK_DR { get; set; }
        public int DK_ID { get; set; }
    
        public virtual CARTOONS CARTOONS { get; set; }
        public virtual DIC_DIRACTORS DIC_DIRACTORS { get; set; }
    }
}