
namespace CV_generator
{
    partial class ExperiencePopup
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
            this.Position_Label = new System.Windows.Forms.Label();
            this.Company_Label = new System.Windows.Forms.Label();
            this.Additional_Box = new System.Windows.Forms.TextBox();
            this.Position_Box = new System.Windows.Forms.TextBox();
            this.Company_Box = new System.Windows.Forms.TextBox();
            this.To_Label = new System.Windows.Forms.Label();
            this.From_Label = new System.Windows.Forms.Label();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.OK_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // To_Box
            // 
            this.To_Box.Location = new System.Drawing.Point(143, 31);
            this.To_Box.Name = "To_Box";
            this.To_Box.Size = new System.Drawing.Size(200, 20);
            this.To_Box.TabIndex = 25;
            // 
            // From_Box
            // 
            this.From_Box.Location = new System.Drawing.Point(143, 6);
            this.From_Box.Name = "From_Box";
            this.From_Box.Size = new System.Drawing.Size(200, 20);
            this.From_Box.TabIndex = 24;
            // 
            // AdditionalInfo_Label
            // 
            this.AdditionalInfo_Label.AutoSize = true;
            this.AdditionalInfo_Label.Location = new System.Drawing.Point(12, 109);
            this.AdditionalInfo_Label.Name = "AdditionalInfo_Label";
            this.AdditionalInfo_Label.Size = new System.Drawing.Size(116, 13);
            this.AdditionalInfo_Label.TabIndex = 23;
            this.AdditionalInfo_Label.Text = "Dodatkowe informacje:";
            // 
            // Position_Label
            // 
            this.Position_Label.AutoSize = true;
            this.Position_Label.Location = new System.Drawing.Point(12, 83);
            this.Position_Label.Name = "Position_Label";
            this.Position_Label.Size = new System.Drawing.Size(65, 13);
            this.Position_Label.TabIndex = 22;
            this.Position_Label.Text = "Stanowisko:";
            // 
            // Company_Label
            // 
            this.Company_Label.AutoSize = true;
            this.Company_Label.Location = new System.Drawing.Point(12, 57);
            this.Company_Label.Name = "Company_Label";
            this.Company_Label.Size = new System.Drawing.Size(89, 13);
            this.Company_Label.TabIndex = 21;
            this.Company_Label.Text = "Przedsiębiorstwo:";
            // 
            // Additional_Box
            // 
            this.Additional_Box.Location = new System.Drawing.Point(143, 106);
            this.Additional_Box.Name = "Additional_Box";
            this.Additional_Box.Size = new System.Drawing.Size(200, 20);
            this.Additional_Box.TabIndex = 20;
            // 
            // Position_Box
            // 
            this.Position_Box.Location = new System.Drawing.Point(143, 80);
            this.Position_Box.Name = "Position_Box";
            this.Position_Box.Size = new System.Drawing.Size(201, 20);
            this.Position_Box.TabIndex = 19;
            // 
            // Company_Box
            // 
            this.Company_Box.Location = new System.Drawing.Point(143, 54);
            this.Company_Box.Name = "Company_Box";
            this.Company_Box.Size = new System.Drawing.Size(201, 20);
            this.Company_Box.TabIndex = 18;
            // 
            // To_Label
            // 
            this.To_Label.AutoSize = true;
            this.To_Label.Location = new System.Drawing.Point(12, 34);
            this.To_Label.Name = "To_Label";
            this.To_Label.Size = new System.Drawing.Size(24, 13);
            this.To_Label.TabIndex = 17;
            this.To_Label.Text = "Do:";
            // 
            // From_Label
            // 
            this.From_Label.AutoSize = true;
            this.From_Label.Location = new System.Drawing.Point(12, 9);
            this.From_Label.Name = "From_Label";
            this.From_Label.Size = new System.Drawing.Size(24, 13);
            this.From_Label.TabIndex = 16;
            this.From_Label.Text = "Od:";
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_Button.Location = new System.Drawing.Point(269, 141);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(75, 23);
            this.Cancel_Button.TabIndex = 15;
            this.Cancel_Button.Text = "Anuluj";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            // 
            // OK_Button
            // 
            this.OK_Button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK_Button.Location = new System.Drawing.Point(143, 141);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(75, 23);
            this.OK_Button.TabIndex = 14;
            this.OK_Button.Text = "OK";
            this.OK_Button.UseVisualStyleBackColor = true;
            // 
            // ExperiencePopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 183);
            this.Controls.Add(this.To_Box);
            this.Controls.Add(this.From_Box);
            this.Controls.Add(this.AdditionalInfo_Label);
            this.Controls.Add(this.Position_Label);
            this.Controls.Add(this.Company_Label);
            this.Controls.Add(this.Additional_Box);
            this.Controls.Add(this.Position_Box);
            this.Controls.Add(this.Company_Box);
            this.Controls.Add(this.To_Label);
            this.Controls.Add(this.From_Label);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.OK_Button);
            this.Name = "ExperiencePopup";
            this.Text = "Doświadczenie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox To_Box;
        public System.Windows.Forms.TextBox From_Box;
        private System.Windows.Forms.Label AdditionalInfo_Label;
        private System.Windows.Forms.Label Position_Label;
        private System.Windows.Forms.Label Company_Label;
        public System.Windows.Forms.TextBox Additional_Box;
        public System.Windows.Forms.TextBox Position_Box;
        public System.Windows.Forms.TextBox Company_Box;
        private System.Windows.Forms.Label To_Label;
        private System.Windows.Forms.Label From_Label;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Button OK_Button;
    }
}