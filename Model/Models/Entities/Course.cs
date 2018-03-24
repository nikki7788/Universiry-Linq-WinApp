using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities
{
    [Table("Course")]
    public class Course
    {

        public Course()
        {


        }
        [Column("course#")]
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }

        [MaxLength(40)]
        [Required]
        [Column("course Name")]
        public string CourseName { get; set; }

        [Required]
        [Column("unit")]
       // [Range(0,2)]
       //[RegularExpression(@"\d{1,2}")]
        public int Unit { get; set; }

        [Required]
        [Column("type#")]

        public int TypeID { get; set; }



        // مرجع کلید خارجی برای جدول سی اف
        //سمت یک
        public virtual ICollection<CF> CF_s { get; set; }
        //تنظیم مرجع  کلید خارجی  فیلد ای دی در جدول جی
        //سمت یک
        public virtual ICollection<G> Ge_s { get; set; }

        //تنظیم مرجع  کلید خارجی  فیلد ای دی در جدول پر
        //سمت یک
        public virtual ICollection<Pre> Pre_s { get; set; }

        //تنظیم مرجع  کلید خارجی  فیلد کورس ای دی در جدول پی سی
        //سمت یک
        public virtual ICollection<PC> PC_s { get; set; }


        //کلید خارجی
        //سمت چند
        [ForeignKey("TypeID")]
        public virtual TypeU TypeU { get; set; }

    }
}
