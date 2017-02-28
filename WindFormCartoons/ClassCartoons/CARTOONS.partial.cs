using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace ClassCartoons
{
    [MetadataType(typeof(CARTOONSMD))]
    partial class CARTOONS
    {
        public class CARTOONSMD
        {
            [HiddenInput(DisplayValue = false)]
            public int CR_ID { get; set;}

            [Display(Name = "Назва")]
            [UIHint("String")]
            [Required(ErrorMessage = "Поле не повинно бути порожнім")]
            public string CR_NAME { get; set; }

            [Display(Name = "Короткий зміст")]
            public string CR_ANNOTATION { get; set; }

            [Display(Name = "Рік виходу")]
            public int CR_YEAR { get; set; }

            [Display(Name = "Imbd рейтинг")]
            public int CR_RATING { get; set; }

            [Display(Name = "Тривалість")]
            public int CR_DURATION { get; set; }

            [Display(Name = "Лінк")]
            [UIHint("String")]
            [Required(ErrorMessage = "Поле не повинно бути порожнім")]
            public string CR_ADRESS { get; set; }

            [Display(Name = "Статус")]
            [UIHint("Int")]
            [Required(ErrorMessage = "Поле не повинно бути порожнім")]
            public int CR_CS { get; set; }
        }
    }
}
