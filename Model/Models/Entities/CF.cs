using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities
{
    public class CF
    {
        public CF()
        {



        }
        [Key]
        [Column("course#", Order = 0)]
        [Required]

        public int CourseID { get; set; }

        [Key]
        [Column("field#", Order = 1)]
        [Required]
        public int FieldID { get; set; }

        //[MaxLength(2)]
        //[RegularExpression(@"P|A|T|O|E(i)")]
        //public string Kind { get; set; }
        //[Range(2,3)]
        [Required]
        public int Kind { get; set; }


        //کلید خارجی
        //سمت چند
        [ForeignKey("CourseID")]
        public virtual Course Course { get; set; }

        //کلید خارجی
        //سمت چند
        [ForeignKey("FieldID")]
        public virtual Field Field { get; set; }

        

      
    }

}
