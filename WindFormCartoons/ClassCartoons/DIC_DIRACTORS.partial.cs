using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace ClassCartoons
{
    [MetadataType(typeof(DIRACTORSMD))]
  partial class DIC_DIRACTORS
    {
        public class DIRACTORSMD
        {
            [HiddenInput(DisplayValue = false)]
            public int DR_ID { get; set; }

            [Display(Name = "Ім'я")]
            [UIHint("String")]
            [Required(ErrorMessage = "Поле не повинно бути порожнім")]
            public string DR_NAME { get; set; }

            [Display(Name = "Інформація")]
             [UIHint("MultilineText")]
            public string DR_INFO { get; set; }
        }
    }
}
