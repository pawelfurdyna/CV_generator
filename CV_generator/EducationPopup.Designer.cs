
namespace CV_generator
{
    partial class EducationPopup
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
            this.OK_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.From_Label = new System.Windows.Forms.Label();
            this.To_Label = new System.Windows.Forms.Label();
            this.School_Box = new System.Windows.Forms.TextBox();
            this.Degree_Box = new System.Windows.Forms.TextBox();
            this.Field_Box = new System.Windows.Forms.TextBox();
            this.School_Label = new System.Windows.Forms.Label();
            this.Degree_Label = new System.Windows.Forms.Label();
            this.Field_Label = new System.Windows.Forms.Label();
            this.From_Box = new System.Windows.Forms.TextBox();
            this.To_Box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // OK_Button
            // 
            this.OK_Button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK_Button.Location = new System.Drawing.Point(103, 141);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(75, 23);
            this.OK_Button.TabIndex = 0;
            this.OK_Button.Text = "OK";
            this.OK_Button.UseVisualStyleBackColor = true;
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_Button.Location = new System.Drawing.Point(229, 141);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(75, 23);
            this.Cancel_Button.TabIndex = 1;
            this.Cancel_Button.Text = "Anuluj";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // From_Label
            // 
            this.From_Label.AutoSize = true;
            this.From_Label.Location = new System.Drawing.Point(12, 9);
            this.From_Label.Name = "From_Label";
            this.From_Label.Size = new System.Drawing.Size(24, 13);
            this.From_Label.TabIndex = 2;
            this.From_Label.Text = "Od:";
            // 
            // To_Label
            // 
            this.To_Label.AutoSize = true;
            this.To_Label.Location = new System.Drawing.Point(12, 34);
            this.To_Label.Name = "To_Label";
            this.To_Label.Size = new System.Drawing.Size(24, 13);
            this.To_Label.TabIndex = 4;
            this.To_Label.Text = "Do:";
            // 
            // School_Box
            // 
            this.School_Box.Location = new System.Drawing.Point(103, 54);
            this.School_Box.Name = "School_Box";
            this.School_Box.Size = new System.Drawing.Size(201, 20);
            this.School_Box.TabIndex = 6;
            // 
            // Degree_Box
            // 
            this.Degree_Box.Location = new System.Drawing.Point(103, 80);
            this.Degree_Box.Name = "Degree_Box";
            this.Degree_Box.Size = new System.Drawing.Size(201, 20);
            this.Degree_Box.TabIndex = 7;
            // 
            // Field_Box
            // 
            this.Field_Box.Location = new System.Drawing.Point(103, 106);
            this.Field_Box.Name = "Field_Box";
            this.Field_Box.Size = new System.Drawing.Size(200, 20);
            this.Field_Box.TabIndex = 8;
            // 
            // School_Label
            // 
            this.School_Label.AutoSize = true;
            this.School_Label.Location = new System.Drawing.Point(12, 57);
            this.School_Label.Name = "School_Label";
            this.School_Label.Size = new System.Drawing.Size(44, 13);
            this.School_Label.TabIndex = 9;
            this.School_Label.Text = "Szkoła:";
            // 
            // Degree_Label
            // 
            this.Degree_Label.AutoSize = true;
            this.Degree_Label.Location = new System.Drawing.Point(12, 83);
            this.Degree_Label.Name = "Degree_Label";
            this.Degree_Label.Size = new System.Drawing.Size(46, 13);
            this.Degree_Label.TabIndex = 10;
            this.Degree_Label.Text = "Stopień:";
            // 
            // Field_Label
            // 
            this.Field_Label.AutoSize = true;
            this.Field_Label.Location = new System.Drawing.Point(12, 109);
            this.Field_Label.Name = "Field_Label";
            this.Field_Label.Size = new System.Drawing.Size(52, 13);
            this.Field_Label.TabIndex = 11;
            this.Field_Label.Text = "Kierunek:";
            // 
            // From_Box
            // 
            this.From_Box.Location = new System.Drawing.Point(103, 6);
            this.From_Box.Name = "From_Box";
            this.From_Box.Size = new System.Drawing.Size(200, 20);
            this.From_Box.TabIndex = 12;
            // 
            // To_Box
            // 
            this.To_Box.Location = new System.Drawing.Point(103, 31);
            this.To_Box.Name = "To_Box";
            this.To_Box.Size = new System.Drawing.Size(200, 20);
            this.To_Box.TabIndex = 13;
            // 
            // EducationPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 181);
            this.Controls.Add(this.To_Box);
            this.Controls.Add(this.From_Box);
            this.Controls.Add(this.Field_Label);
            this.Controls.Add(this.Degree_Label);
            this.Controls.Add(this.School_Label);
            this.Controls.Add(this.Field_Box);
            this.Controls.Add(this.Degree_Box);
            this.Controls.Add(this.School_Box);
            this.Controls.Add(this.To_Label);
            this.Controls.Add(this.From_Label);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.OK_Button);
            this.Name = "EducationPopup";
            this.Text = "Edukacja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OK_Button;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Label From_Label;
        private System.Windows.Forms.Label To_Label;
        public System.Windows.Forms.TextBox School_Box;
        public System.Windows.Forms.TextBox Degree_Box;
        public System.Windows.Forms.TextBox Field_Box;
        private System.Windows.Forms.Label School_Label;
        private System.Windows.Forms.Label Degree_Label;
        private System.Windows.Forms.Label Field_Label;
        public System.Windows.Forms.TextBox From_Box;
        public System.Windows.Forms.TextBox To_Box;
    }
}