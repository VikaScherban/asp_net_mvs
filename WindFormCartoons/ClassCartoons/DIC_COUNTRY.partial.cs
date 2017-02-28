using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace ClassCartoons
{
    [MetadataType(typeof(COUNTRYMD))]

partial class DIC_COUNTRY
    {
        public class COUNTRYMD
        {
            [HiddenInput(DisplayValue = false)]
            public int CT_ID { get; set; }

            [Display(Name = "Назва")]
            public string CT_NAME { get; set; }

            [Display(Name = "Інформація")]
            public string CT_INFO { get; set; }
        }
    }
}
