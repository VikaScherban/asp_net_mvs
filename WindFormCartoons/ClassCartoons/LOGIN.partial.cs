using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace ClassCartoons
{
    [MetadataType(typeof(LOGINMD))]
    partial class LOGIN
    {
        public class LOGINMD
        {
            [Display(Name = "Логін")]
            public string LG_LOGIN { get; set; }

            [Display(Name = "Пароль")]
            [DataType(DataType.Password)]
            public string LG_PASSWORD { get; set; }
        }
    }
}
