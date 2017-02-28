using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace ClassCartoons
{
    [MetadataType(typeof(GENREDM))]
    partial class DIC_GENRE
    {
        public class GENREDM
        {
            [HiddenInput(DisplayValue = false)]
            public int GR_ID { get; set; }

            [Display(Name = "Назва")]
            public string GR_NAME { get; set; }

            [Display(Name = "Інформація")]
            public string GR_INFO { get; set; }
        }
    }
}
