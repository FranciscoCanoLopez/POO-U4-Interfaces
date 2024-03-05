namespace Interfazes
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
            btnDOG = new Button();
            btnCAT = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnDOG
            // 
            btnDOG.Location = new Point(95, 145);
            btnDOG.Name = "btnDOG";
            btnDOG.Size = new Size(211, 98);
            btnDOG.TabIndex = 0;
            btnDOG.Text = "DOG";
            btnDOG.UseVisualStyleBackColor = true;
            btnDOG.Click += btnDOG_Click;
            // 
            // btnCAT
            // 
            btnCAT.Location = new Point(427, 145);
            btnCAT.Name = "btnCAT";
            btnCAT.Size = new Size(211, 98);
            btnCAT.TabIndex = 1;
            btnCAT.Text = "CAT";
            btnCAT.UseVisualStyleBackColor = true;
            btnCAT.Click += btnCAT_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(311, 80);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 2;
            label1.Text = "Animals sounds";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnCAT);
            Controls.Add(btnDOG);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDOG;
        private Button btnCAT;
        private Label label1;
    }
}
