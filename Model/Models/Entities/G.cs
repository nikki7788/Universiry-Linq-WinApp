using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class G
    {

        public G()
        {


        }

        //[Column(TypeName = "numeric(4,2)")]
        [Required]
        //[MaxLength(4)]
        public decimal Grade { get; set; }
        [Key]
        [Column("std#", Order = 0)]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StudentID { get; set; }

        [Key]
        [Column("course#", Order = 1)]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }

        [Key]
        [Column("term#", Order = 2)]
        [Required]
        //  [RegularExpression(@"\d{3}")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]

        public int Term { get; set; }


        //تنظیم کلید خارجی 
        //سمت چند
        [ForeignKey("StudentID")]
        public virtual Student Student { get; set; }

        //تنظیم کلید خارجی 
        //سمت چند
        [ForeignKey("CourseID")]
        public virtual Course Course { get; set; }
    }

}
