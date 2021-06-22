using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CV_generator
{
    public partial class CV_Generator_Form : Form
    {
        public CV_Generator_Form()
        {
            InitializeComponent();
            
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EducationAdd_Button_Click(object sender, EventArgs e)
        {
            EducationPopup edupopup = new EducationPopup();
            DialogResult dialogresult = edupopup.ShowDialog();

            if (dialogresult == DialogResult.OK)
            {

                Edu_Data.Rows.Add(new object[] {edupopup.From_Box.Text, edupopup.To_Box.Text, edupopup.School_Box.Text, edupopup.Degree_Box.Text, edupopup.Field_Box.Text});

            }
            else if (dialogresult == DialogResult.Cancel)
            {
                
            }
            edupopup.Dispose();
        }

        private void ExperienceAdd_Button_Click(object sender, EventArgs e)
        {
            ExperiencePopup exppopup = new ExperiencePopup();
            DialogResult dialogresult = exppopup.ShowDialog();

            if (dialogresult == DialogResult.OK)
            {

                Exp_Data.Rows.Add(new object[] { exppopup.From_Box.Text, exppopup.To_Box.Text, exppopup.Company_Box.Text, exppopup.Position_Box.Text, exppopup.Additional_Box.Text });

            }
            else if (dialogresult == DialogResult.Cancel)
            {

            }
            exppopup.Dispose();
        }
    }
}
