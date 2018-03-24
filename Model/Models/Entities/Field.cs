using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    [Table("Field")]
    public class Field
    {
        public Field()
        {

        }

        [Key]
        [Required]
      [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("Field#")]
        public int FieldID { get; set; }

        [Required]
        [MaxLength(50)]
        [Column("fieldName")]
        public string FieldName { get; set; }


        //تنظیم مرجع  کلید خارجی  فیلد ای دی در جدول استیدونت
        //سمت یک
        public virtual ICollection<Student> Students { get; set; }

        //تنظیم مرجع  کلید خارجی  فیلد فیلدای دی در جدول استیدونت
        //سمت یک
        public virtual ICollection<CF> CF_s { get; set; }


        //تنظیم مرجع  کلید خارجی  فیلد فیلدای دی در جدول تیوشن
        //سمت یک
        public virtual ICollection<Tution> Tutions { get; set; }
    }
}

