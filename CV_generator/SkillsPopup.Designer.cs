
namespace CV_generator
{
    partial class SkillsPopup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Knowledge_Box = new System.Windows.Forms.TextBox();
            this.Skill_Box = new System.Windows.Forms.TextBox();
            this.AdditionalInfo_Label = new System.Windows.Forms.Label();
            this.AdditionalInfo_Box = new System.Windows.Forms.TextBox();
            this.Knowledge_Label = new System.Windows.Forms.Label();
            this.Skill_Label = new System.Windows.Forms.Label();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.OK_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Knowledge_Box
            // 
            this.Knowledge_Box.Location = new System.Drawing.Point(154, 32);
            this.Knowledge_Box.Name = "Knowledge_Box";
            this.Knowledge_Box.Size = new System.Drawing.Size(200, 20);
            this.Knowledge_Box.TabIndex = 25;
            // 
            // Skill_Box
            // 
            this.Skill_Box.Location = new System.Drawing.Point(154, 6);
            this.Skill_Box.Name = "Skill_Box";
            this.Skill_Box.Size = new System.Drawing.Size(200, 20);
            this.Skill_Box.TabIndex = 24;
            // 
            // AdditionalInfo_Label
            // 
            this.AdditionalInfo_Label.AutoSize = true;
            this.AdditionalInfo_Label.Location = new System.Drawing.Point(12, 61);
            this.AdditionalInfo_Label.Name = "AdditionalInfo_Label";
            this.AdditionalInfo_Label.Size = new System.Drawing.Size(116, 13);
            this.AdditionalInfo_Label.TabIndex = 21;
            this.AdditionalInfo_Label.Text = "Dodatkowe informacje:";
            // 
            // AdditionalInfo_Box
            // 
            this.AdditionalInfo_Box.Location = new System.Drawing.Point(153, 58);
            this.AdditionalInfo_Box.Name = "AdditionalInfo_Box";
            this.AdditionalInfo_Box.Size = new System.Drawing.Size(201, 20);
            this.AdditionalInfo_Box.TabIndex = 18;
            // 
            // Knowledge_Label
            // 
            this.Knowledge_Label.AutoSize = true;
            this.Knowledge_Label.Location = new System.Drawing.Point(12, 35);
            this.Knowledge_Label.Name = "Knowledge_Label";
            this.Knowledge_Label.Size = new System.Drawing.Size(62, 13);
            this.Knowledge_Label.TabIndex = 17;
            this.Knowledge_Label.Text = "Znajomość:";
            // 
            // Skill_Label
            // 
            this.Skill_Label.AutoSize = true;
            this.Skill_Label.Location = new System.Drawing.Point(12, 9);
            this.Skill_Label.Name = "Skill_Label";
            this.Skill_Label.Size = new System.Drawing.Size(68, 13);
            this.Skill_Label.TabIndex = 16;
            this.Skill_Label.Text = "Umiejętność:";
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_Button.Location = new System.Drawing.Point(279, 84);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(75, 23);
            this.Cancel_Button.TabIndex = 15;
            this.Cancel_Button.Text = "Anuluj";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            // 
            // OK_Button
            // 
            this.OK_Button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK_Button.Location = new System.Drawing.Point(153, 84);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(75, 23);
            this.OK_Button.TabIndex = 14;
            this.OK_Button.Text = "OK";
            this.OK_Button.UseVisualStyleBackColor = true;
            // 
            // SkillsPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 120);
            this.Controls.Add(this.Knowledge_Box);
            this.Controls.Add(this.Skill_Box);
            this.Controls.Add(this.AdditionalInfo_Label);
            this.Controls.Add(this.AdditionalInfo_Box);
            this.Controls.Add(this.Knowledge_Label);
            this.Controls.Add(this.Skill_Label);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.OK_Button);
            this.Name = "SkillsPopup";
            this.Text = "Umiejętności";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox Knowledge_Box;
        public System.Windows.Forms.TextBox Skill_Box;
        private System.Windows.Forms.Label AdditionalInfo_Label;
        public System.Windows.Forms.TextBox AdditionalInfo_Box;
        private System.Windows.Forms.Label Knowledge_Label;
        private System.Windows.Forms.Label Skill_Label;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Button OK_Button;
    }
}