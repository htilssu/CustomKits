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
            panelKits1 = new Kits.PanelKits();
            buttonKits1 = new Kits.ButtonKits();
            SuspendLayout();
            // 
            // panelKits1
            // 
            panelKits1.BackColor = SystemColors.HighlightText;
            panelKits1.BorderColor = Color.Transparent;
            panelKits1.BorderRadius = 49F;
            panelKits1.BorderWidth = 0F;
            panelKits1.Location = new Point(252, 176);
            panelKits1.MinimumSize = new Size(200, 50);
            panelKits1.Name = "panelKits1";
            panelKits1.Size = new Size(250, 90);
            panelKits1.TabIndex = 0;
            // 
            // buttonKits1
            // 
            buttonKits1.BackColor = Color.FromArgb(91, 137, 255);
            buttonKits1.BorderColor = Color.Empty;
            buttonKits1.BorderRadius = 0;
            buttonKits1.BorderWidth = 0F;
            buttonKits1.Fill = true;
            buttonKits1.FlatAppearance.BorderSize = 0;
            buttonKits1.FlatStyle = FlatStyle.Flat;
            buttonKits1.HoverColor = Color.Yellow;
            buttonKits1.Location = new Point(347, 76);
            buttonKits1.MinimumSize = new Size(200, 50);
            buttonKits1.Name = "buttonKits1";
            buttonKits1.Size = new Size(229, 89);
            buttonKits1.TabIndex = 1;
            buttonKits1.Text = "buttonKits1";
            buttonKits1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(706, 400);
            Controls.Add(buttonKits1);
            Controls.Add(panelKits1);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "2";
            Paint += Painting;
            ResumeLayout(false);
        }

        #endregion

        private Kits.PanelKits panelKits1;
        private Kits.ButtonKits buttonKits1;
    }
}