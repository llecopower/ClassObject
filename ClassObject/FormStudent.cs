using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassObject
{
    public partial class FormStudent : Form
    {

        public Student oStudent = new Student();

       
        public FormStudent()
        {
            InitializeComponent();
            buttonExit.Enabled = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {


            //store data entered at textboxed in the Object oStudent
            oStudent.StudentId = Convert.ToInt32(textBoxStudentId.Text);
            oStudent.FirstName = textBoxFirstName.Text;
            oStudent.LastName = textBoxLastName.Text;
            oStudent.PhoneNumber = textBoxPhoneNumber.Text;
            oStudent.EmailAddress = textBoxEmail.Text;

            listBoxStudentId.Items.Add(oStudent.StudentId);
            listBoxFirstName.Items.Add(oStudent.FirstName);
            listBoxLastName.Items.Add(oStudent.LastName);
            listBoxPhoneNumber.Items.Add(oStudent.PhoneNumber);
            listBoxEmail.Items.Add(oStudent.EmailAddress);


            textBoxStudentId.Clear();
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            textBoxPhoneNumber.Clear();
            textBoxEmail.Clear();
            textBoxStudentId.Focus();

           // textBoxFirstName.Text = "";


            buttonExit.Enabled = true;




         


                


        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }
    }
}
