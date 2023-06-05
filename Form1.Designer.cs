namespace CustomKits
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            userControlKits1 = new Kits.UserControlKits();
            buttonKits1 = new Kits.ButtonKits();
            SuspendLayout();
            // 
            // userControlKits1
            // 
            userControlKits1.BackColor = Color.Black;
            userControlKits1.BorderColor = SystemColors.ControlLightLight;
            userControlKits1.BorderRadius = 50;
            userControlKits1.BorderWidth = 2F;
            userControlKits1.Fill = true;
            userControlKits1.HoverColor = Color.Empty;
            userControlKits1.Location = new Point(289, 176);
            userControlKits1.Name = "userControlKits1";
            userControlKits1.Size = new Size(303, 116);
            userControlKits1.TabIndex = 0;
            // 
            // buttonKits1
            // 
            buttonKits1.BackColor = Color.FromArgb(91, 137, 255);
            buttonKits1.BorderColor = Color.Black;
            buttonKits1.BorderRadius = 50;
            buttonKits1.BorderWidth = 2F;
            buttonKits1.Fill = true;
            buttonKits1.FlatAppearance.BorderSize = 0;
            buttonKits1.FlatStyle = FlatStyle.Flat;
            buttonKits1.HoverColor = Color.Empty;
            buttonKits1.Location = new Point(446, 75);
            buttonKits1.MinimumSize = new Size(200, 50);
            buttonKits1.Name = "buttonKits1";
            buttonKits1.Size = new Size(296, 75);
            buttonKits1.TabIndex = 1;
            buttonKits1.Text = "buttonKits1";
            buttonKits1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(882, 500);
            Controls.Add(buttonKits1);
            Controls.Add(userControlKits1);
            Name = "Form1";
            Text = "2";
            Paint += Painting;
            ResumeLayout(false);
        }

        #endregion

        private Kits.UserControlKits userControlKits1;
        private Kits.ButtonKits buttonKits1;
    }
}