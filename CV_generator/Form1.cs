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

        private void SkillsAdd_Button_Click(object sender, EventArgs e)
        {
            SkillsPopup skillspopup = new SkillsPopup();
            DialogResult dialogresult = skillspopup.ShowDialog();

            if (dialogresult == DialogResult.OK)
            {
                CheckBox Skillcheck = new CheckBox();
                Skills_Data.Rows.Add(new object[] {skillspopup.Skill_Box.Text, skillspopup.Knowledge_Box.Text , skillspopup.AdditionalInfo_Box.Text, "Yes" });

            }
            else if (dialogresult == DialogResult.Cancel)
            {

            }
            skillspopup.Dispose();
        }

        private void CoursesAdd_Button_Click(object sender, EventArgs e)
        {
            CoursesPopup coursespopup = new CoursesPopup();
            DialogResult dialogresult = coursespopup.ShowDialog();

            if (dialogresult == DialogResult.OK)
            {
                CheckBox Skillcheck = new CheckBox();
                Courses_Data.Rows.Add(new object[] { coursespopup.From_Box.Text, coursespopup.To_Box.Text, coursespopup.Course_Box.Text, coursespopup.AdditionalInfo_Box.Text, "Yes" });

            }
            else if (dialogresult == DialogResult.Cancel)
            {

            }
            coursespopup.Dispose();
        }

        private void ProjectsAdd_Button_Click(object sender, EventArgs e)
        {
            ProjectsPopup projectspopup = new ProjectsPopup();
            DialogResult dialogresult = projectspopup.ShowDialog();

            if (dialogresult == DialogResult.OK)
            {
                CheckBox Skillcheck = new CheckBox();
                Projects_Data.Rows.Add(new object[] { projectspopup.Project_Box.Text, projectspopup.AdditionalInfo_Box.Text, "Yes" });

            }
            else if (dialogresult == DialogResult.Cancel)
            {

            }
            projectspopup.Dispose();
        }

        private void LanguagesAdd_Button_Click(object sender, EventArgs e)
        {
            LanguagesPopup languagespopup = new LanguagesPopup();
            DialogResult dialogresult = languagespopup.ShowDialog();

            if (dialogresult == DialogResult.OK)
            {
                CheckBox Skillcheck = new CheckBox();
                Languages_Data.Rows.Add(new object[] { languagespopup.Language_Box.Text, languagespopup.Knowledge_Box.Text });

            }
            else if (dialogresult == DialogResult.Cancel)
            {

            }
            languagespopup.Dispose();
        }

        private void InterestsAdd_Button_Click(object sender, EventArgs e)
        {
            InterestsPopup interestspopup = new InterestsPopup();
            DialogResult dialogresult = interestspopup.ShowDialog();

            if (dialogresult == DialogResult.OK)
            {
                CheckBox Skillcheck = new CheckBox();
                Interests_Data.Rows.Add(new object[] { interestspopup.Interest_Box.Text, "Yes" });

            }
            else if (dialogresult == DialogResult.Cancel)
            {

            }
            interestspopup.Dispose();
        }

        private void AdditionalInfoAdd_Button_Click(object sender, EventArgs e)
        {
            AdditionalInfoPopup additionalpopup = new AdditionalInfoPopup();
            DialogResult dialogresult = additionalpopup.ShowDialog();

            if (dialogresult == DialogResult.OK)
            {
                CheckBox Skillcheck = new CheckBox();
                AdditionalInfo_Data.Rows.Add(new object[] { additionalpopup.AdditionalInfo_Box.Text, "Yes" });

            }
            else if (dialogresult == DialogResult.Cancel)
            {

            }
            additionalpopup.Dispose();
        }
    }
}
