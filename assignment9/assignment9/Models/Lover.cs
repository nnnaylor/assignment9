using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace assignment9.Models
{
    public class Lover
    {
        public int LoverID { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Favorite Hot Dog")]
        [StringLength(60, MinimumLength = 3)]
        public string FavDog { get; set; }
        [Display(Name = "Last Hot Dog")]
        [StringLength(60, MinimumLength = 3)]
        public string LastDog { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }
        [Required]
        [Display(Name = "Biography")]
        [StringLength(500, MinimumLength = 3)]
        public string Bio { get; set; }
        [Display(Name = "Past Hot Dogs")]
        [StringLength(60, MinimumLength = 3)]
        public string PastDog { get; set; }
    }
}