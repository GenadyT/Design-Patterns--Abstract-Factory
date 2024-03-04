namespace FactoryTest
{
    partial class frmRunFactory
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
            textBox1 = new TextBox();
            btnRunFactory = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.SeaShell;
            textBox1.Location = new Point(12, 55);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(531, 698);
            textBox1.TabIndex = 0;
            // 
            // btnRunFactory
            // 
            btnRunFactory.BackColor = Color.FromArgb(139, 193, 217);
            btnRunFactory.FlatAppearance.BorderColor = Color.Red;
            btnRunFactory.FlatStyle = FlatStyle.Flat;
            btnRunFactory.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRunFactory.Location = new Point(12, 15);
            btnRunFactory.Name = "btnRunFactory";
            btnRunFactory.Size = new Size(85, 25);
            btnRunFactory.TabIndex = 1;
            btnRunFactory.Text = "Run Factory";
            btnRunFactory.UseVisualStyleBackColor = false;
            btnRunFactory.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(555, 765);
            Controls.Add(btnRunFactory);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Factory Design Pattern";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button btnRunFactory;
    }
}