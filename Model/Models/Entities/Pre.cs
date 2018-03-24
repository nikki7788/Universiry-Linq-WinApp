using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
 public   class Pre
    {

        public Pre()
        {

        }
        [Key]
        [Column("crs#",Order =0)]
       [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }

        [Key]
        [Column("pre#", Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PreID { get; set; }


        //تنظیم کلید خارجی 
        //سمت چند
        [ForeignKey("CourseID")]
        public virtual Course Course { get; set; }




    }
}
