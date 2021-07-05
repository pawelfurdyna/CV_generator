
namespace CV_generator
{
    partial class ProjectsPopup
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
            this.AdditionalInfo_Box = new System.Windows.Forms.TextBox();
            this.Project_Box = new System.Windows.Forms.TextBox();
            this.AdditionalInfo_Label = new System.Windows.Forms.Label();
            this.Project_Label = new System.Windows.Forms.Label();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.OK_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AdditionalInfo_Box
            // 
            this.AdditionalInfo_Box.Location = new System.Drawing.Point(153, 31);
            this.AdditionalInfo_Box.Name = "AdditionalInfo_Box";
            this.AdditionalInfo_Box.Size = new System.Drawing.Size(200, 20);
            this.AdditionalInfo_Box.TabIndex = 25;
            // 
            // Project_Box
            // 
            this.Project_Box.Location = new System.Drawing.Point(153, 6);
            this.Project_Box.Name = "Project_Box";
            this.Project_Box.Size = new System.Drawing.Size(200, 20);
            this.Project_Box.TabIndex = 24;
            // 
            // AdditionalInfo_Label
            // 
            this.AdditionalInfo_Label.AutoSize = true;
            this.AdditionalInfo_Label.Location = new System.Drawing.Point(12, 34);
            this.AdditionalInfo_Label.Name = "AdditionalInfo_Label";
            this.AdditionalInfo_Label.Size = new System.Drawing.Size(116, 13);
            this.AdditionalInfo_Label.TabIndex = 17;
            this.AdditionalInfo_Label.Text = "Dodatkowe informacje:";
            // 
            // Project_Label
            // 
            this.Project_Label.AutoSize = true;
            this.Project_Label.Location = new System.Drawing.Point(12, 9);
            this.Project_Label.Name = "Project_Label";
            this.Project_Label.Size = new System.Drawing.Size(43, 13);
            this.Project_Label.TabIndex = 16;
            this.Project_Label.Text = "Projekt:";
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_Button.Location = new System.Drawing.Point(278, 57);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(75, 23);
            this.Cancel_Button.TabIndex = 15;
            this.Cancel_Button.Text = "Anuluj";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            // 
            // OK_Button
            // 
            this.OK_Button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK_Button.Location = new System.Drawing.Point(153, 57);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(75, 23);
            this.OK_Button.TabIndex = 14;
            this.OK_Button.Text = "OK";
            this.OK_Button.UseVisualStyleBackColor = true;
            // 
            // ProjectsPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 100);
            this.Controls.Add(this.AdditionalInfo_Box);
            this.Controls.Add(this.Project_Box);
            this.Controls.Add(this.AdditionalInfo_Label);
            this.Controls.Add(this.Project_Label);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.OK_Button);
            this.Name = "ProjectsPopup";
            this.Text = "Projekty";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox AdditionalInfo_Box;
        public System.Windows.Forms.TextBox Project_Box;
        private System.Windows.Forms.Label AdditionalInfo_Label;
        private System.Windows.Forms.Label Project_Label;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Button OK_Button;
    }
}