namespace it28
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
            this.buttonpel1 = new System.Windows.Forms.Button();
            this.buttonpel2 = new System.Windows.Forms.Button();
            this.labelpel1 = new System.Windows.Forms.Label();
            this.labelpel2 = new System.Windows.Forms.Label();
            this.labelwinner = new System.Windows.Forms.Label();
            this.buttonreset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonpel1
            // 
            this.buttonpel1.Location = new System.Drawing.Point(96, 97);
            this.buttonpel1.Name = "buttonpel1";
            this.buttonpel1.Size = new System.Drawing.Size(75, 23);
            this.buttonpel1.TabIndex = 0;
            this.buttonpel1.Text = "pelaaja1";
            this.buttonpel1.UseVisualStyleBackColor = true;
            this.buttonpel1.Click += new System.EventHandler(this.buttonpel1_Click);
            // 
            // buttonpel2
            // 
            this.buttonpel2.Location = new System.Drawing.Point(195, 97);
            this.buttonpel2.Name = "buttonpel2";
            this.buttonpel2.Size = new System.Drawing.Size(75, 23);
            this.buttonpel2.TabIndex = 1;
            this.buttonpel2.Text = "pelaaja2";
            this.buttonpel2.UseVisualStyleBackColor = true;
            this.buttonpel2.Click += new System.EventHandler(this.buttonpel2_Click);
            // 
            // labelpel1
            // 
            this.labelpel1.AutoSize = true;
            this.labelpel1.Location = new System.Drawing.Point(96, 61);
            this.labelpel1.Name = "labelpel1";
            this.labelpel1.Size = new System.Drawing.Size(0, 15);
            this.labelpel1.TabIndex = 2;
            // 
            // labelpel2
            // 
            this.labelpel2.AutoSize = true;
            this.labelpel2.Location = new System.Drawing.Point(232, 61);
            this.labelpel2.Name = "labelpel2";
            this.labelpel2.Size = new System.Drawing.Size(0, 15);
            this.labelpel2.TabIndex = 3;
            // 
            // labelwinner
            // 
            this.labelwinner.AutoSize = true;
            this.labelwinner.Location = new System.Drawing.Point(163, 169);
            this.labelwinner.Name = "labelwinner";
            this.labelwinner.Size = new System.Drawing.Size(38, 15);
            this.labelwinner.TabIndex = 4;
            this.labelwinner.Text = "label1";
            // 
            // buttonreset
            // 
            this.buttonreset.Location = new System.Drawing.Point(144, 126);
            this.buttonreset.Name = "buttonreset";
            this.buttonreset.Size = new System.Drawing.Size(75, 23);
            this.buttonreset.TabIndex = 5;
            this.buttonreset.Text = "Reset";
            this.buttonreset.UseVisualStyleBackColor = true;
            this.buttonreset.Click += new System.EventHandler(this.buttonreset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonreset);
            this.Controls.Add(this.labelwinner);
            this.Controls.Add(this.labelpel2);
            this.Controls.Add(this.labelpel1);
            this.Controls.Add(this.buttonpel2);
            this.Controls.Add(this.buttonpel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonpel1;
        private System.Windows.Forms.Button buttonpel2;
        private System.Windows.Forms.Label labelpel1;
        private System.Windows.Forms.Label labelpel2;
        private System.Windows.Forms.Label labelwinner;
        private System.Windows.Forms.Button buttonreset;
    }
}
