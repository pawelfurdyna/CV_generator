
namespace CV_generator
{
    partial class LanguagesPopup
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
            this.Language_Box = new System.Windows.Forms.TextBox();
            this.Knowledge_Label = new System.Windows.Forms.Label();
            this.Language_Label = new System.Windows.Forms.Label();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.OK_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Knowledge_Box
            // 
            this.Knowledge_Box.Location = new System.Drawing.Point(103, 31);
            this.Knowledge_Box.Name = "Knowledge_Box";
            this.Knowledge_Box.Size = new System.Drawing.Size(200, 20);
            this.Knowledge_Box.TabIndex = 25;
            // 
            // Language_Box
            // 
            this.Language_Box.Location = new System.Drawing.Point(103, 6);
            this.Language_Box.Name = "Language_Box";
            this.Language_Box.Size = new System.Drawing.Size(200, 20);
            this.Language_Box.TabIndex = 24;
            // 
            // Knowledge_Label
            // 
            this.Knowledge_Label.AutoSize = true;
            this.Knowledge_Label.Location = new System.Drawing.Point(12, 34);
            this.Knowledge_Label.Name = "Knowledge_Label";
            this.Knowledge_Label.Size = new System.Drawing.Size(62, 13);
            this.Knowledge_Label.TabIndex = 17;
            this.Knowledge_Label.Text = "Znajomość:";
            // 
            // Language_Label
            // 
            this.Language_Label.AutoSize = true;
            this.Language_Label.Location = new System.Drawing.Point(12, 9);
            this.Language_Label.Name = "Language_Label";
            this.Language_Label.Size = new System.Drawing.Size(37, 13);
            this.Language_Label.TabIndex = 16;
            this.Language_Label.Text = "Język:";
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_Button.Location = new System.Drawing.Point(228, 57);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(75, 23);
            this.Cancel_Button.TabIndex = 15;
            this.Cancel_Button.Text = "Anuluj";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            // 
            // OK_Button
            // 
            this.OK_Button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK_Button.Location = new System.Drawing.Point(103, 57);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(75, 23);
            this.OK_Button.TabIndex = 14;
            this.OK_Button.Text = "OK";
            this.OK_Button.UseVisualStyleBackColor = true;
            // 
            // LanguagesPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 96);
            this.Controls.Add(this.Knowledge_Box);
            this.Controls.Add(this.Language_Box);
            this.Controls.Add(this.Knowledge_Label);
            this.Controls.Add(this.Language_Label);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.OK_Button);
            this.Name = "LanguagesPopup";
            this.Text = "Języki";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox Knowledge_Box;
        public System.Windows.Forms.TextBox Language_Box;
        private System.Windows.Forms.Label Knowledge_Label;
        private System.Windows.Forms.Label Language_Label;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Button OK_Button;
    }
}