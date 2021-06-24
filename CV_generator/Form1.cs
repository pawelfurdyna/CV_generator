using System;
using System.Collections.Generic;
using System.IO;
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
        bool loadedFile = false;
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

                Edu_Data.Rows.Add(new object[] { edupopup.From_Box.Text, edupopup.To_Box.Text, edupopup.School_Box.Text, edupopup.Degree_Box.Text, edupopup.Field_Box.Text });

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
                Skills_Data.Rows.Add(new object[] { skillspopup.Skill_Box.Text, skillspopup.Knowledge_Box.Text, skillspopup.AdditionalInfo_Box.Text, "Yes" });

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

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Name_Box.Text = "";
            Second_Name_Box.Text = "";
            Surname_Box.Text = "";
            Address_Box.Text = "";
            City_Box.Text = "";
            Telephone_Box.Text = "";
            Email_Box.Text = "";
            Facebook_Box.Text = "";
            LinkedIn_Box.Text = "";
            GitHub_Box.Text = "";
            Website_Box.Text = "";
            Edu_Data.Rows.Clear();
            Exp_Data.Rows.Clear();
            Skills_Data.Rows.Clear();
            Courses_Data.Rows.Clear();
            Projects_Data.Rows.Clear();
            Languages_Data.Rows.Clear();
            Interests_Data.Rows.Clear();
            AdditionalInfo_Data.Rows.Clear();
            Footer_RichBox.Clear();
            loadedFile = false;

        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream ms;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "txt files (*.txt)|*.txt";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((ms = openFileDialog1.OpenFile()) != null)
                {
                    loadedFile = true;
                    StreamReader sr = new StreamReader(ms);
                    generalLoad(sr, Name_Box, Name_Check);
                    generalLoad(sr, Second_Name_Box, Second_Name_Check);
                    generalLoad(sr, Surname_Box, Surname_Check);
                    generalLoad(sr, Address_Box, Address_Check);
                    generalLoad(sr, City_Box, City_Check);
                    generalLoad(sr, Telephone_Box, Telephone_Check);
                    generalLoad(sr, Email_Box, Email_Check);
                    generalLoad(sr, Facebook_Box, Facebook_Check);
                    generalLoad(sr, LinkedIn_Box, LinkedIn_Check);
                    generalLoad(sr, GitHub_Box, GitHub_Check);
                    generalLoad(sr, Website_Box, Website_Check);
                    sr.ReadLine();
                    string[] s = sr.ReadLine().Split(',');
                    Array.Resize(ref s, s.Length - 1);
                    for (int i = 0; i < s.Length; i += 5)
                    {
                        Edu_Data.Rows.Add(new object[] { s[i], s[i + 1], s[i + 2], s[i + 3], s[i + 4] });
                    }
                    s = sr.ReadLine().Split(',');
                    Array.Resize(ref s, s.Length - 1);
                    for (int i = 0; i < s.Length; i += 5)
                    {
                        Exp_Data.Rows.Add(new object[] { s[i], s[i + 1], s[i + 2], s[i + 3], s[i + 4] });
                    }
                    s = sr.ReadLine().Split(',');
                    Array.Resize(ref s, s.Length - 1);
                    for (int i = 0; i < s.Length; i += 4)
                    {
                        Skills_Data.Rows.Add(new object[] { s[i], s[i + 1], s[i + 2], s[i + 3] });
                    }
                    s = sr.ReadLine().Split(',');
                    Array.Resize(ref s, s.Length - 1);
                    for (int i = 0; i < s.Length; i += 5)
                    {
                        Courses_Data.Rows.Add(new object[] { s[i], s[i + 1], s[i + 2], s[i + 3], s[i + 4] });
                    }
                    s = sr.ReadLine().Split(',');
                    Array.Resize(ref s, s.Length - 1);
                    for (int i = 0; i < s.Length; i += 3)
                    {
                        Projects_Data.Rows.Add(new object[] { s[i], s[i + 1], s[i + 2] });
                    }
                    s = sr.ReadLine().Split(',');
                    Array.Resize(ref s, s.Length - 1);
                    for (int i = 0; i < s.Length; i += 2)
                    {
                        Languages_Data.Rows.Add(new object[] { s[i], s[i + 1]});
                    }
                    s = sr.ReadLine().Split(',');
                    Array.Resize(ref s, s.Length - 1);
                    for (int i = 0; i < s.Length; i += 2)
                    {
                        Interests_Data.Rows.Add(new object[] { s[i], s[i + 1] });
                    }
                    s = sr.ReadLine().Split(',');
                    Array.Resize(ref s, s.Length - 1);
                    for (int i = 0; i < s.Length; i += 2)
                    {
                        AdditionalInfo_Data.Rows.Add(new object[] { s[i], s[i + 1] });
                    }
                    Footer_RichBox.Text = sr.ReadLine();
                    sr.Close();
                }
            }

            openFileDialog1.Dispose();
        }

        private void saveToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (loadedFile == true)
            {

            }
            else
            {

            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream ms;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((ms = saveFileDialog1.OpenFile()) != null)
                {
                    StreamWriter sw = new StreamWriter(ms);
                    sw.WriteLine(Name_Box.Text + "," + generalCheck(Name_Check));
                    sw.WriteLine(Second_Name_Box.Text + "," + generalCheck(Second_Name_Check));
                    sw.WriteLine(Surname_Box.Text + "," + generalCheck(Surname_Check));
                    sw.WriteLine(Address_Box.Text + "," + generalCheck(Address_Check));
                    sw.WriteLine(City_Box.Text + "," + generalCheck(City_Check));
                    sw.WriteLine(Telephone_Box.Text + "," + generalCheck(Telephone_Check));
                    sw.WriteLine(Email_Box.Text + "," + generalCheck(Email_Check));
                    sw.WriteLine(Facebook_Box.Text + "," + generalCheck(Facebook_Check));
                    sw.WriteLine(LinkedIn_Box.Text + "," + generalCheck(LinkedIn_Check));
                    sw.WriteLine(GitHub_Box.Text + "," + generalCheck(GitHub_Check));
                    sw.WriteLine(Website_Box.Text + "," + generalCheck(Website_Check));
                    sw.WriteLine("");
                    saveData(readData(Edu_Data), sw);
                    sw.WriteLine("");
                    saveData(readData(Exp_Data), sw);
                    sw.WriteLine("");
                    saveData(readData(Skills_Data), sw);
                    sw.WriteLine("");
                    saveData(readData(Courses_Data), sw);
                    sw.WriteLine("");
                    saveData(readData(Projects_Data), sw);
                    sw.WriteLine("");
                    saveData(readData(Languages_Data), sw);
                    sw.WriteLine("");
                    saveData(readData(Interests_Data), sw);
                    sw.WriteLine("");
                    saveData(readData(AdditionalInfo_Data), sw);
                    sw.WriteLine("");
                    sw.WriteLine(Footer_RichBox.Text);

                    sw.Close();
                }

            }
            saveFileDialog1.Dispose();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public string[] readData(DataGridView data)
        {
            List<string> dataList = new List<string>();
            for (int rows = 0; rows < data.Rows.Count - 1; rows++)
            {
                for (int col = 0; col < data.Rows[rows].Cells.Count; col++)
                {
                    string value = "";
                    if (data.Rows[rows].Cells[col].Value != null)
                    {
                        value = data.Rows[rows].Cells[col].Value.ToString();
                    }

                    dataList.Add(value);
                }
            }
            string[] str = dataList.ToArray();
            return str;
        }

        private void saveData(string[] dataTable, StreamWriter sw)
        {
            foreach (string data in dataTable)
            {
                sw.Write(data + ",");
            }
        }

        public string generalCheck(CheckBox checkbox)
        {
            if (checkbox.Checked == true)
            {
                return "Yes";
            }
            else
            {
                return "No";
            }
        }

        public void stringToCheck (CheckBox checkbox, string check)
        {
            if (check == "Yes")
            {
                checkbox.Checked = true;
            }
            else
            {
                checkbox.Checked = false;
            }
        }   
         
        public void generalLoad(StreamReader sr, TextBox box, CheckBox check)
        {
            string[] s = sr.ReadLine().Split(',');
            box.Text = s[0];
            stringToCheck(check, s[1]);
        }

    }
}
