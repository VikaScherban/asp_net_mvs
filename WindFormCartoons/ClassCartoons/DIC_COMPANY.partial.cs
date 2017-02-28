using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace ClassCartoons
{
    [MetadataType(typeof(COMPANYDM))]
    partial class DIC_COMPANY
    {
        public class COMPANYDM
        {
            [HiddenInput(DisplayValue = false)]
            public int CP_ID { get; set; }

            [Display(Name = "Назва")]
            public string CP_NAME { get; set; }

            [Display(Name = "Інформація")]
            public string CP_INFO { get; set; }
        }
    }
}
