using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities
{
    [Table("Type")]
    public class TypeU
    {


        public TypeU()
        {

        }
        [Column("type#")]
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]

        public int TypeID { get; set; }

        [Column("typeName")]
        [MaxLength(30)]
        [Required]
        public string TypeName { get; set; }

        //[Column("fee",TypeName = "decimal(9, 2)")]
        [Column("fee")]
        [Required]
        //[DataType("decimal(16 ,3)")]
    // [Range(7,2)]
        public decimal Fee { get; set; }

        //مرجع کلید خارجی در جدول کورس
        //سمت یک
        public virtual ICollection<Course> Courses { get; set; }
    }
}
