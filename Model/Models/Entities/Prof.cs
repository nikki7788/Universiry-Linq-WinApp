using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections;

namespace Model.Entities
{
    public class Prof
    {

        public Prof()
        {


        }

        #region#########properties in C# = column in sql server ##########################
        [Key]
        [Required]
        [Column("prof#")]
       [DatabaseGenerated(DatabaseGeneratedOption.None)]
        /// <summary>
        /// شماره منحصر به فردبرای  هر استاد
        /// </summary>
        public int ProfID { get; set; }

        [Required]
        [Column("prof Name")]
        [MaxLength(30)]
        //نام استاد
        public string ProfName { get; set; }


        //[MaxLength(1)]
        //L=لیسانس    F= فوق لیانس    D= لیسانس
        //[RegularExpression(@"D|F|L(i)")]
        //آخرین مدرک تحصیلی
        [Required]
        [Column("degree")]

        //  public MyDegree Degree { get; set; }
        public int Degree { get; set; }
        // public int Degree { get; set; }
        // [NotMapped]
        //public MyDegree Deg
        //{
        //    get { return (MyDegree)this.Degree; }
        //    set { this.Degree = (int)value; }
        //}

        #endregion

        //تنظیم مرجع  کلید خارجی  فیلد پروف ای دی در جدول پی سی
        //سمت یک
        public virtual ICollection<PC> PC_S { get; set; }

        //public enum MyDegree
        //{
        //    d = 0, f = 1, l = 2
        //}

        //[Flags]
        //public enum MyDegree:byte
        //{
        //    d = 0, f = 1, l = 2
        //}




    }
}
