using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities
{
    /// <summary>
    /// جدول شهریه
    /// </summary>
    public class Tution
    {

        public Tution()
        {


        }

        [Key]
        [Required]
        [Column("field#", Order = 0)]
        public int FieldID { get; set; }

        [Key]
        [Column("start year", Order = 1)]
        [Required]
        
        
        public int StartYear { get; set; }
        
        //[Column("constution", TypeName = "numeric(18,2)")]
        [Required]
        [Column("constution")]
        
        //شهریه ثابت
        public decimal ConstTtion { get; set; }


        //تنظیم کلید خارجی 
        //سمت چند
        [ForeignKey("FieldID")]
        public virtual Field Field { get; set; }



    }
}
