
namespace Yams
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_joueur1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_joueur2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_start = new System.Windows.Forms.Button();
            this.label_warning = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.textBox_joueur1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 320);
            this.panel1.TabIndex = 2;
            // 
            // textBox_joueur1
            // 
            this.textBox_joueur1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_joueur1.Location = new System.Drawing.Point(201, 270);
            this.textBox_joueur1.Name = "textBox_joueur1";
            this.textBox_joueur1.Size = new System.Drawing.Size(201, 39);
            this.textBox_joueur1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Papyrus", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(201, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "Joueur 1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.textBox_joueur2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(503, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(503, 320);
            this.panel2.TabIndex = 3;
            // 
            // textBox_joueur2
            // 
            this.textBox_joueur2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_joueur2.Location = new System.Drawing.Point(101, 270);
            this.textBox_joueur2.Name = "textBox_joueur2";
            this.textBox_joueur2.Size = new System.Drawing.Size(201, 39);
            this.textBox_joueur2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Papyrus", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(101, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 50);
            this.label2.TabIndex = 3;
            this.label2.Text = "Joueur 2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_start
            // 
            this.button_start.Font = new System.Drawing.Font("Papyrus", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_start.Location = new System.Drawing.Point(403, 350);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(200, 50);
            this.button_start.TabIndex = 4;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // label_warning
            // 
            this.label_warning.BackColor = System.Drawing.Color.Transparent;
            this.label_warning.Font = new System.Drawing.Font("Papyrus", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label_warning.ForeColor = System.Drawing.Color.White;
            this.label_warning.Location = new System.Drawing.Point(303, 420);
            this.label_warning.Name = "label_warning";
            this.label_warning.Size = new System.Drawing.Size(400, 50);
            this.label_warning.TabIndex = 4;
            this.label_warning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AcceptButton = this.button_start;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Yams.Properties.Resources.fondBis;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.label_warning);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_joueur1;
        private System.Windows.Forms.TextBox textBox_joueur2;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Label label_warning;
    }
}

