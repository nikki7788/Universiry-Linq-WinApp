using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Model.Entities
{
  public  class PC
    {
        #region#######  constructors  ################
        /// <summary>
        /// default constructors: !!!! Must be written
        /// </summary>
        public PC()
        {

        }
        #endregion

        #region########## properties in Entity =columns in sql sever ############

        [Key]
        [Required]
        [Column("prof#",Order =0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProfID { get; set; }

        [Key]
        [Required]
        [Column("course#", Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }

        [Key]
        [Required]
        [Column("term#", Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Term { get; set; }

        #endregion

        //تنظیم کلید خارجی 
        //سمت چند
        [ForeignKey("ProfID")]
        public virtual Prof Prof { get; set; }

        //تنظیم کلید خارجی 
        //سمت چند
        [ForeignKey("CourseID")]
        public virtual Course Course { get; set; }






    }
 
}
