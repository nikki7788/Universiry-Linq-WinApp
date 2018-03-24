using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model.Entities;
using Model.DAL;
namespace winAppUniversity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // ایجاد یک شی از کلاس دیتا بیس کانتکست
            DatabaseContext oDatabaseContext = null;

            //try
            //{

            //نیو کردن دیتا بیس کانتکست
            oDatabaseContext = new DatabaseContext();
            //ایجاد یک شی از کلاس کانتری

            Course oCourse = null;
            oCourse = new Course()
            {
                CourseID = 1100,
                CourseName = "ادبیات",
                Unit = 2,
                TypeID = 1
            };

            //oCourse.CourseID = 1100;
            //oCourse.CourseName = "ادبیات";
            //oCourse.Unit = 2;
            //oCourse.TypeID = 1;
            oDatabaseContext.Course.Add(oCourse);

            oCourse = new Course()
            {
                CourseID = 1105,
                CourseName = "تربیت بدنی",
                Unit = 1,
                TypeID = 2
            };
            oDatabaseContext.Course.Add(oCourse);

            oCourse = new Course()
            {
                CourseID = 1400,
                CourseName = "برنامه سازی ۱",
                Unit = 3,
                TypeID = 1
            };
            oDatabaseContext.Course.Add(oCourse);

            oCourse = new Course()
            {
                CourseID = 1401,
                CourseName = "ساختمان داده ها",
                Unit = 3,
                TypeID = 1
            };
            oDatabaseContext.Course.Add(oCourse);

            oCourse = new Course()
            {
                CourseID = 1402,
                CourseName = "برنامه سازی ۲",
                Unit = 3,
                TypeID = 1
            };
            oDatabaseContext.Course.Add(oCourse);

            oCourse = new Course()
            {
                CourseID = 1403,
                CourseName = "بازیابی و ذخیره",
                Unit = 3,
                TypeID = 1
            };
            oDatabaseContext.Course.Add(oCourse);

            oCourse = new Course()
            {
                CourseID = 1407,
                CourseName = "پایگاه داده ها",
                Unit = 3,
                TypeID = 1
            };
            oDatabaseContext.Course.Add(oCourse);

            oCourse = new Course()
            {
                CourseID = 1500,
                CourseName = "ریاضی 1",
                Unit = 3,
                TypeID = 1
            };
            oDatabaseContext.Course.Add(oCourse);

            oCourse = new Course()
            {
                CourseID = 1600,
                CourseName = "زبان پیش نیاز",
                Unit = 2,
                TypeID = 1
            };
            oDatabaseContext.Course.Add(oCourse);

            // ------------------------
            CF oCf = null;
            oCf = new CF
            {
                CourseID = 1100,
                FieldID = 1,
                Kind = (int)KindType.O
            };
            oDatabaseContext.CF.Add(oCf);

            oCf = new CF
            {
                CourseID = 1100,
                FieldID = 2,
                Kind = (int)KindType.O
            };
            oDatabaseContext.CF.Add(oCf);

            oCf = new CF
            {
                CourseID = 1100,
                FieldID = 3,
                Kind = (int)KindType.O
            };
            oDatabaseContext.CF.Add(oCf);

            oCf = new CF
            {
                CourseID = 1105,
                FieldID = 1,
                Kind = (int)KindType.O
            };
            oDatabaseContext.CF.Add(oCf);

            oCf = new CF
            {
                CourseID = 1105,
                FieldID = 2,
                Kind = (int)KindType.O
            };
            oDatabaseContext.CF.Add(oCf);

            oCf = new CF
            {
                CourseID = 1105,
                FieldID = 3,
                Kind = (int)KindType.O
            };
            oDatabaseContext.CF.Add(oCf);

            //oCf = new CF
            //{
            //    CourseID = 1100,
            //    FieldID = 1,
            //    Kind = (int)KindType.O
            //};
            //oDatabaseContext.CF.Add(oCf);

            oCf = new CF
            {
                CourseID = 1400,
                FieldID = 1,
                Kind = (int)KindType.T
            };
            oDatabaseContext.CF.Add(oCf);

            oCf = new CF
            {
                CourseID = 1400,
                FieldID = 2,
                Kind = (int)KindType.E
            };
            oDatabaseContext.CF.Add(oCf);

            oCf = new CF
            {
                CourseID = 1400,
                FieldID = 3,
                Kind = (int)KindType.E
            };
            oDatabaseContext.CF.Add(oCf);

            oCf = new CF
            {
                CourseID = 1402,
                FieldID = 1,
                Kind = (int)KindType.T
            };
            oDatabaseContext.CF.Add(oCf);

            oCf = new CF
            {
                CourseID = 1403,
                FieldID = 1,
                Kind = (int)KindType.T
            };
            oDatabaseContext.CF.Add(oCf);

            oCf = new CF
            {
                CourseID = 1407,
                FieldID = 1,
                Kind = (int)KindType.T
            };
            oDatabaseContext.CF.Add(oCf);

            oCf = new CF
            {
                CourseID = 1500,
                FieldID = 1,
                Kind = (int)KindType.p
            };
            oDatabaseContext.CF.Add(oCf);

            oCf = new CF
            {
                CourseID = 1500,
                FieldID = 2,
                Kind = (int)KindType.p
            };
            oDatabaseContext.CF.Add(oCf);

            oCf = new CF
            {
                CourseID = 1500,
                FieldID = 3,
                Kind = (int)KindType.p
            };
            oDatabaseContext.CF.Add(oCf);
            // -----------------------------------

            Field oField = null;
            oField = new Field()
            {
                FieldID = 1,
                FieldName = "مهندسی کامپیوتر"

            };
            oDatabaseContext.Field.Add(oField);

            oField = new Field()
            {
                FieldID = 2,
                FieldName = "مهندسی الکترونیک"

            };
            oDatabaseContext.Field.Add(oField);

            oField = new Field()
            {
                FieldID = 3,
                FieldName = "ریاضی محض"

            };
            oDatabaseContext.Field.Add(oField);
            // ---------------------------------------
            TypeU oType = null;
            oType = new TypeU()
            {
                TypeID = 1,
                TypeName = "نطری",
                Fee = 5000
            };
            oDatabaseContext.TypeU.Add(oType);

            oType = new TypeU()
            {
                TypeID = 2,
                TypeName = "عملی",
                Fee = 20000
            };
            oDatabaseContext.TypeU.Add(oType);

            oType = new TypeU()
            {
                TypeID = 3,
                TypeName = "آزمایشگاه",
                Fee = 30000
            };
            oDatabaseContext.TypeU.Add(oType);

            // --------------------------------------------------
            Tution oTution = null;
            oTution = new Tution()
            {
                FieldID = 1,
                StartYear = 80,
                ConstTtion = 75000
            };
            oDatabaseContext.Tution.Add(oTution);

            oTution = new Tution()
            {
                FieldID = 1,
                StartYear = 81,
                ConstTtion = 80000
            };
            oDatabaseContext.Tution.Add(oTution);

            oTution = new Tution()
            {
                FieldID = 1,
                StartYear = 82,
                ConstTtion = 90000
            };
            oDatabaseContext.Tution.Add(oTution);

            oTution = new Tution()
            {
                FieldID = 2,
                StartYear = 81,
                ConstTtion = 80000
            };
            oDatabaseContext.Tution.Add(oTution);

            oTution = new Tution()
            {
                FieldID = 2,
                StartYear = 82,
                ConstTtion = 90000
            };
            oDatabaseContext.Tution.Add(oTution);

            oTution = new Tution()
            {
                FieldID = 3,
                StartYear = 82,
                ConstTtion = 75000
            };
            oDatabaseContext.Tution.Add(oTution);

            //-------------------------------
            Student oStudent = null;

            oStudent = new Student()
            {
                StudentID = 8001,
                StudentName = "آرش راد",
                StartYear = 80,
                FieldID = 1
            };
            oDatabaseContext.Student.Add(oStudent);

            oStudent = new Student()
            {
                StudentID = 8002,
                StudentName = "عسل شاملو",
                StartYear = 80,
                FieldID = 3
            };
            oDatabaseContext.Student.Add(oStudent);

            oStudent = new Student()
            {
                StudentID = 8003,
                StudentName = "سیاوش آزاد",
                StartYear = 80,
                FieldID = 1
            };
            oDatabaseContext.Student.Add(oStudent);

            oStudent = new Student()
            {
                StudentID = 8101,
                StudentName = "ساغر راد",
                StartYear = 81,
                FieldID = 1
            };
            oDatabaseContext.Student.Add(oStudent);

            oStudent = new Student()
            {
                StudentID = 8102,
                StudentName = "علی نیکی",
                StartYear = 81,
                FieldID = 1
            };
            oDatabaseContext.Student.Add(oStudent);

            oStudent = new Student()
            {
                StudentID = 8111,
                StudentName = "فرامرز نیکی",
                StartYear = 81,
                FieldID = 1
            };
            oDatabaseContext.Student.Add(oStudent);

            oStudent = new Student()
            {
                StudentID = 8112,
                StudentName = "علی رضایی",
                StartYear = 81,
                FieldID = 2
            };
            oDatabaseContext.Student.Add(oStudent);

         
            // -----------------------
            Pre oPre = null;
            oPre = new Pre()
            {
                CourseID = 1400,
                PreID = 1500
            };
            oDatabaseContext.Pre.Add(oPre);

            oPre = new Pre()
            {
                CourseID = 1402,
                PreID = 1400
            };
            oDatabaseContext.Pre.Add(oPre);

            oPre = new Pre()
            {
                CourseID = 1407,
                PreID = 1402
            };
            oDatabaseContext.Pre.Add(oPre);

            oPre = new Pre()
            {
                CourseID = 1407,
                PreID = 1403
            };
            oDatabaseContext.Pre.Add(oPre);
           // ------------------------------------------
            G oG = null;
            oG = new G()
            {
                StudentID = 8001,
                CourseID = 1400,
                Term = 811,
                Grade = 9
            };
            oDatabaseContext.G.Add(oG);

            oG = new G()
            {
                StudentID = 8001,
                CourseID = 1400,
                Term = 812,
                Grade = 13
            };
            oDatabaseContext.G.Add(oG);

            oG = new G()
            {
                StudentID = 8001,
                CourseID = 1401,
                Term = 811,
                Grade =13
            };
            oDatabaseContext.G.Add(oG);

            oG = new G()
            {
                StudentID = 8101,
                CourseID = 1400,
                Term = 821,
                Grade = 19
            };
            oDatabaseContext.G.Add(oG);

            oG = new G()
            {
                StudentID = 8101,
                CourseID = 1500,
                Term = 821,
                Grade = 14
            };
            oDatabaseContext.G.Add(oG);

            oG = new G()
            {
                StudentID = 8111,
                CourseID = 1400,
                Term = 811,
                Grade = 12
            };
            oDatabaseContext.G.Add(oG);

            oG = new G()
            {
                StudentID = 8111,
                CourseID = 1401,
                Term = 811,
                Grade = 20
            };
            oDatabaseContext.G.Add(oG);

            //-----------------------------------------------
            
            Prof oProf = null;
            oProf = new Prof()
            {
                ProfID = 101,
                ProfName = "فرانک شایسته",
                Degree = (int)MyDegree.l
            };
            oDatabaseContext.Prof.Add(oProf);

            oProf = new Prof()
            {
                ProfID = 102,
                ProfName = "علی پیامی",
                Degree = (int)MyDegree.f
            };
            oDatabaseContext.Prof.Add(oProf);

            oProf = new Prof()
            {
                ProfID = 106,
                ProfName = "آزاده نیکوکار",
                Degree = (int)MyDegree.f
            };
            oDatabaseContext.Prof.Add(oProf);

            oProf = new Prof()
            {
                ProfID = 107,
                ProfName = "سیامک فرزانه",
                Degree = (int)MyDegree.d
            };
            oDatabaseContext.Prof.Add(oProf);

            oProf = new Prof()
            {
                ProfID = 108,
                ProfName = "علی نادر نژاد",
                Degree = (int)MyDegree.f
            };
            oDatabaseContext.Prof.Add(oProf);


            //----------------------------------------------
            PC oPc = null;
            oPc = new PC()
            {
                ProfID = 101,
                CourseID = 1400,
                Term = 801
            };
            oDatabaseContext.PC.Add(oPc);

            oPc = new PC()
            {
                ProfID = 101,
                CourseID = 1400,
                Term = 802
            };
            oDatabaseContext.PC.Add(oPc);

            oPc = new PC()
            {
                ProfID = 101,
                CourseID = 1402,
                Term = 801
            };
            oDatabaseContext.PC.Add(oPc);

            oPc = new PC()
            {
                ProfID = 102,
                CourseID = 1400,
                Term = 801
            };
            oDatabaseContext.PC.Add(oPc);

            oPc = new PC()
            {
                ProfID = 108,
                CourseID = 1500,
                Term = 811
            };
            oDatabaseContext.PC.Add(oPc);

            oPc = new PC()
            {
                ProfID = 101,
                CourseID = 1400,
                Term = 811
            };
            oDatabaseContext.PC.Add(oPc);

         //   ---------------------------------------------
            //ایجاد بانک اطلاعاتی در دیتا بیس
            oDatabaseContext.SaveChanges();
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //اگر دیتابیس کانتکست نال نبود آنرا نال میکنیم
            if (oDatabaseContext != null)
            {
                oDatabaseContext.Dispose();
                oDatabaseContext = null;
            }
            //}
        }
        public enum KindType
        {
            p, A, T, O, E,
        }
        public enum MyDegree
        {
            d = 0, f = 1, l = 2
        }
    }

}
