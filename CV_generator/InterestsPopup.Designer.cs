
namespace CV_generator
{
    partial class InterestsPopup
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
            this.Interest_Box = new System.Windows.Forms.TextBox();
            this.Interest_Label = new System.Windows.Forms.Label();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.OK_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Interest_Box
            // 
            this.Interest_Box.Location = new System.Drawing.Point(103, 6);
            this.Interest_Box.Name = "Interest_Box";
            this.Interest_Box.Size = new System.Drawing.Size(200, 20);
            this.Interest_Box.TabIndex = 28;
            // 
            // Interest_Label
            // 
            this.Interest_Label.AutoSize = true;
            this.Interest_Label.Location = new System.Drawing.Point(12, 9);
            this.Interest_Label.Name = "Interest_Label";
            this.Interest_Label.Size = new System.Drawing.Size(88, 13);
            this.Interest_Label.TabIndex = 27;
            this.Interest_Label.Text = "Zainteresowanie:";
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_Button.Location = new System.Drawing.Point(228, 32);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(75, 23);
            this.Cancel_Button.TabIndex = 26;
            this.Cancel_Button.Text = "Anuluj";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            // 
            // OK_Button
            // 
            this.OK_Button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK_Button.Location = new System.Drawing.Point(103, 32);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(75, 23);
            this.OK_Button.TabIndex = 25;
            this.OK_Button.Text = "OK";
            this.OK_Button.UseVisualStyleBackColor = true;
            // 
            // InterestsPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 73);
            this.Controls.Add(this.Interest_Box);
            this.Controls.Add(this.Interest_Label);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.OK_Button);
            this.Name = "InterestsPopup";
            this.Text = "Zainteresowania";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox Interest_Box;
        private System.Windows.Forms.Label Interest_Label;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Button OK_Button;
    }
}