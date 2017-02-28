using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace ClassCartoons
{
    [MetadataType(typeof(CARTOON_SATATUSESMD))]
    partial class DIC_CARTOON_STATUSES
    {
        public class CARTOON_SATATUSESMD
        {
            [HiddenInput(DisplayValue = false)]
            public int CS_ID { get; set; }

            [Display(Name = "Статус")]
            public string CS_NAME { get; set; }
        }
    }
}
