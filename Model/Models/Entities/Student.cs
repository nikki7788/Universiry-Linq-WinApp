using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities
{
    [Table("Student")]
    public class Student
    {
        public Student()
        {

        }

        [Column("student#")]
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StudentID { get; set; }

        [MaxLength(30)]
        [Required]
        [Column("student name")]
        public string StudentName { get; set; }

        //[MinLength(2), MaxLength(4)]
        [Column("start year")]
        [Required]
        public int StartYear { get; set; }

        [Column("field#")]
        [Required]
        public int FieldID { get; set; }

        //تنظیم کلید خارجی 
        //سمت چند
        [ForeignKey("FieldID")]
        public virtual Field Field { get; set; }


        //تنظیم مرجع  کلید خارجی  فیلد استیدنت ای دی در جدول استیدونت
        //سمت یک
        public virtual ICollection<G> Ge_s { get; set; }


    }

}
