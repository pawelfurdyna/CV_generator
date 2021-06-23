
namespace CV_generator
{
    partial class CoursesPopup
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
            this.To_Box = new System.Windows.Forms.TextBox();
            this.From_Box = new System.Windows.Forms.TextBox();
            this.AdditionalInfo_Label = new System.Windows.Forms.Label();
            this.Course_Label = new System.Windows.Forms.Label();
            this.AdditionalInfo_Box = new System.Windows.Forms.TextBox();
            this.Course_Box = new System.Windows.Forms.TextBox();
            this.To_Label = new System.Windows.Forms.Label();
            this.From_Label = new System.Windows.Forms.Label();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.OK_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // To_Box
            // 
            this.To_Box.Location = new System.Drawing.Point(103, 31);
            this.To_Box.Name = "To_Box";
            this.To_Box.Size = new System.Drawing.Size(200, 20);
            this.To_Box.TabIndex = 25;
            // 
            // From_Box
            // 
            this.From_Box.Location = new System.Drawing.Point(103, 6);
            this.From_Box.Name = "From_Box";
            this.From_Box.Size = new System.Drawing.Size(200, 20);
            this.From_Box.TabIndex = 24;
            // 
            // AdditionalInfo_Label
            // 
            this.AdditionalInfo_Label.AutoSize = true;
            this.AdditionalInfo_Label.Location = new System.Drawing.Point(12, 83);
            this.AdditionalInfo_Label.Name = "AdditionalInfo_Label";
            this.AdditionalInfo_Label.Size = new System.Drawing.Size(77, 13);
            this.AdditionalInfo_Label.TabIndex = 22;
            this.AdditionalInfo_Label.Text = "Additional Info:";
            // 
            // Course_Label
            // 
            this.Course_Label.AutoSize = true;
            this.Course_Label.Location = new System.Drawing.Point(12, 57);
            this.Course_Label.Name = "Course_Label";
            this.Course_Label.Size = new System.Drawing.Size(43, 13);
            this.Course_Label.TabIndex = 21;
            this.Course_Label.Text = "Course:";
            // 
            // AdditionalInfo_Box
            // 
            this.AdditionalInfo_Box.Location = new System.Drawing.Point(103, 80);
            this.AdditionalInfo_Box.Name = "AdditionalInfo_Box";
            this.AdditionalInfo_Box.Size = new System.Drawing.Size(201, 20);
            this.AdditionalInfo_Box.TabIndex = 19;
            // 
            // Course_Box
            // 
            this.Course_Box.Location = new System.Drawing.Point(103, 54);
            this.Course_Box.Name = "Course_Box";
            this.Course_Box.Size = new System.Drawing.Size(201, 20);
            this.Course_Box.TabIndex = 18;
            // 
            // To_Label
            // 
            this.To_Label.AutoSize = true;
            this.To_Label.Location = new System.Drawing.Point(12, 34);
            this.To_Label.Name = "To_Label";
            this.To_Label.Size = new System.Drawing.Size(23, 13);
            this.To_Label.TabIndex = 17;
            this.To_Label.Text = "To:";
            // 
            // From_Label
            // 
            this.From_Label.AutoSize = true;
            this.From_Label.Location = new System.Drawing.Point(12, 9);
            this.From_Label.Name = "From_Label";
            this.From_Label.Size = new System.Drawing.Size(33, 13);
            this.From_Label.TabIndex = 16;
            this.From_Label.Text = "From:";
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_Button.Location = new System.Drawing.Point(229, 106);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(75, 23);
            this.Cancel_Button.TabIndex = 15;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            // 
            // OK_Button
            // 
            this.OK_Button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK_Button.Location = new System.Drawing.Point(103, 106);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(75, 23);
            this.OK_Button.TabIndex = 14;
            this.OK_Button.Text = "OK";
            this.OK_Button.UseVisualStyleBackColor = true;
            // 
            // CoursesPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 151);
            this.Controls.Add(this.To_Box);
            this.Controls.Add(this.From_Box);
            this.Controls.Add(this.AdditionalInfo_Label);
            this.Controls.Add(this.Course_Label);
            this.Controls.Add(this.AdditionalInfo_Box);
            this.Controls.Add(this.Course_Box);
            this.Controls.Add(this.To_Label);
            this.Controls.Add(this.From_Label);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.OK_Button);
            this.Name = "CoursesPopup";
            this.Text = "CoursesPopup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox To_Box;
        public System.Windows.Forms.TextBox From_Box;
        private System.Windows.Forms.Label AdditionalInfo_Label;
        private System.Windows.Forms.Label Course_Label;
        public System.Windows.Forms.TextBox AdditionalInfo_Box;
        public System.Windows.Forms.TextBox Course_Box;
        private System.Windows.Forms.Label To_Label;
        private System.Windows.Forms.Label From_Label;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Button OK_Button;
    }
}