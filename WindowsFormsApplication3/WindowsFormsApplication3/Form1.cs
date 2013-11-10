using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmdCheck_Click(object sender, EventArgs e)
        {



            string op1,op2,op3,op4,op5,op6;
            if (apt1.Checked == true)
            {
                op1= "มาก" ;


            }
            else if (radioButton2.Checked == true)
            {
                op1= "ปานกลาง" ;

            }
            else  
            {
                op1= "น้อย" ;

            }


            //
            if (bpt1.Checked == true)
            {
                op2= "มาก" ;
            }
            else if (bpt2.Checked == true)
            {
                op2= "ปานกลาง" ;
            }
            else  
            {
                op2= "น้อย" ;

            }


         //
            if (cpt1.Checked == true)
            {
               op3= "มาก" ;
            }
            else if (cpt2.Checked == true)
            {
                op3= "ปานกลาง" ;
            }
            else 
            {
                op3= "น้อย" ;

            }

        //    str = str + "4.ความปลอดภัยในการใช้บริการรถเมล์มหาวิทยาลัยพะเยา == ";
            if (dpt1.Checked == true)
            {
                op4= "มาก" ;
            }
            else  if (dpt2.Checked == true)
            {
                op4= "ปานกลาง" ;
            }
            else 
            {
               op4= "น้อย" ;
            }
         //   str = str + "5.ความเหมาะสมของการวางรูปแบบที่นั่งบนรถ == ";
            if (radioButton9.Checked == true)
            {
                op5= "มาก" ;
            }
            
                else if (radioButton8.Checked == true)
                {
                   op5= "ปานกลาง" ;
                }
            
            else 
                op5= "น้อย" ;
            {
              }
           // str = str + "6.ความเหมาะสมของเวลาในการหมุนเวียนรับส่งนักศึกษา == " ;
            if (radioButton10.Checked == true)
            {
               op6= "มาก" ;
            }
            
                else  if (radioButton7.Checked == true)
                {
                    op6= "ปานกลาง" ;
                }
            
                else
            {
                op6= "น้อย" ;
            }
            Form2 frm = new Form2(op1,op2,op3,op4,op5,op6 );
            frm.Show();



            
        }

        private void optMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void apt2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void apt1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cpt2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

