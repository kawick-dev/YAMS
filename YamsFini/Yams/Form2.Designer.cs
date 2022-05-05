
namespace Yams
{
    partial class Form2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.yamsGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_textJoueur1 = new System.Windows.Forms.Label();
            this.label_joueur1 = new System.Windows.Forms.Label();
            this.label_joueur2 = new System.Windows.Forms.Label();
            this.label_textJoueur2 = new System.Windows.Forms.Label();
            this.panel_des5 = new System.Windows.Forms.Panel();
            this.panel_des4 = new System.Windows.Forms.Panel();
            this.panel_des3 = new System.Windows.Forms.Panel();
            this.panel_des2 = new System.Windows.Forms.Panel();
            this.panel_des1 = new System.Windows.Forms.Panel();
            this.button_throwDice = new System.Windows.Forms.Button();
            this.label_joueurActuel = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button_back = new System.Windows.Forms.Button();
            this.button_replay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.yamsGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // yamsGrid
            // 
            this.yamsGrid.AllowUserToAddRows = false;
            this.yamsGrid.AllowUserToDeleteRows = false;
            this.yamsGrid.AllowUserToResizeColumns = false;
            this.yamsGrid.AllowUserToResizeRows = false;
            this.yamsGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.yamsGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.yamsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.yamsGrid.ColumnHeadersHeight = 46;
            this.yamsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.yamsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.yamsGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.yamsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yamsGrid.Location = new System.Drawing.Point(0, 0);
            this.yamsGrid.Margin = new System.Windows.Forms.Padding(0);
            this.yamsGrid.MultiSelect = false;
            this.yamsGrid.Name = "yamsGrid";
            this.yamsGrid.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.yamsGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.yamsGrid.RowHeadersVisible = false;
            this.yamsGrid.RowHeadersWidth = 51;
            this.yamsGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.yamsGrid.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.yamsGrid.RowTemplate.Height = 42;
            this.yamsGrid.Size = new System.Drawing.Size(300, 721);
            this.yamsGrid.TabIndex = 0;
            this.yamsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.yamsGrid_CellContentClick);
            this.yamsGrid.SelectionChanged += new System.EventHandler(this.yamsGrid_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.HeaderText = "Combinaison";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column2.HeaderText = "Joueur 1";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.Width = 86;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column3.HeaderText = "Joueur 2";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.Width = 86;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.yamsGrid);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(706, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 721);
            this.panel1.TabIndex = 1;
            // 
            // label_textJoueur1
            // 
            this.label_textJoueur1.BackColor = System.Drawing.Color.Transparent;
            this.label_textJoueur1.Font = new System.Drawing.Font("Papyrus", 14.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_textJoueur1.ForeColor = System.Drawing.Color.White;
            this.label_textJoueur1.Location = new System.Drawing.Point(0, 70);
            this.label_textJoueur1.Name = "label_textJoueur1";
            this.label_textJoueur1.Size = new System.Drawing.Size(150, 30);
            this.label_textJoueur1.TabIndex = 3;
            this.label_textJoueur1.Text = "Joueur 1 :";
            this.label_textJoueur1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_joueur1
            // 
            this.label_joueur1.BackColor = System.Drawing.Color.Transparent;
            this.label_joueur1.Font = new System.Drawing.Font("Papyrus", 14.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_joueur1.ForeColor = System.Drawing.Color.White;
            this.label_joueur1.Location = new System.Drawing.Point(0, 100);
            this.label_joueur1.Name = "label_joueur1";
            this.label_joueur1.Size = new System.Drawing.Size(150, 30);
            this.label_joueur1.TabIndex = 4;
            this.label_joueur1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_joueur2
            // 
            this.label_joueur2.BackColor = System.Drawing.Color.Transparent;
            this.label_joueur2.Font = new System.Drawing.Font("Papyrus", 14.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_joueur2.ForeColor = System.Drawing.Color.White;
            this.label_joueur2.Location = new System.Drawing.Point(556, 631);
            this.label_joueur2.Name = "label_joueur2";
            this.label_joueur2.Size = new System.Drawing.Size(150, 30);
            this.label_joueur2.TabIndex = 5;
            this.label_joueur2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_textJoueur2
            // 
            this.label_textJoueur2.BackColor = System.Drawing.Color.Transparent;
            this.label_textJoueur2.Font = new System.Drawing.Font("Papyrus", 14.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_textJoueur2.ForeColor = System.Drawing.Color.White;
            this.label_textJoueur2.Location = new System.Drawing.Point(556, 591);
            this.label_textJoueur2.Name = "label_textJoueur2";
            this.label_textJoueur2.Size = new System.Drawing.Size(150, 30);
            this.label_textJoueur2.TabIndex = 4;
            this.label_textJoueur2.Text = "Joueur 2 :";
            this.label_textJoueur2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_des5
            // 
            this.panel_des5.BackColor = System.Drawing.Color.Black;
            this.panel_des5.BackgroundImage = global::Yams.Properties.Resources.Dés5;
            this.panel_des5.Location = new System.Drawing.Point(533, 310);
            this.panel_des5.Name = "panel_des5";
            this.panel_des5.Size = new System.Drawing.Size(75, 75);
            this.panel_des5.TabIndex = 14;
            this.panel_des5.Visible = false;
            this.panel_des5.Click += new System.EventHandler(this.panel_des5_Click);
            // 
            // panel_des4
            // 
            this.panel_des4.BackColor = System.Drawing.Color.Black;
            this.panel_des4.BackgroundImage = global::Yams.Properties.Resources.Dés4;
            this.panel_des4.Location = new System.Drawing.Point(423, 310);
            this.panel_des4.Name = "panel_des4";
            this.panel_des4.Size = new System.Drawing.Size(75, 75);
            this.panel_des4.TabIndex = 14;
            this.panel_des4.Visible = false;
            this.panel_des4.Click += new System.EventHandler(this.panel_des4_Click);
            // 
            // panel_des3
            // 
            this.panel_des3.BackColor = System.Drawing.Color.Black;
            this.panel_des3.BackgroundImage = global::Yams.Properties.Resources.Dés3;
            this.panel_des3.Location = new System.Drawing.Point(313, 310);
            this.panel_des3.Name = "panel_des3";
            this.panel_des3.Size = new System.Drawing.Size(75, 75);
            this.panel_des3.TabIndex = 14;
            this.panel_des3.Visible = false;
            this.panel_des3.Click += new System.EventHandler(this.panel_des3_Click);
            // 
            // panel_des2
            // 
            this.panel_des2.BackColor = System.Drawing.Color.Black;
            this.panel_des2.BackgroundImage = global::Yams.Properties.Resources.Dés2;
            this.panel_des2.Location = new System.Drawing.Point(203, 310);
            this.panel_des2.Name = "panel_des2";
            this.panel_des2.Size = new System.Drawing.Size(75, 75);
            this.panel_des2.TabIndex = 14;
            this.panel_des2.Visible = false;
            this.panel_des2.Click += new System.EventHandler(this.panel_des2_Click);
            // 
            // panel_des1
            // 
            this.panel_des1.BackColor = System.Drawing.Color.Black;
            this.panel_des1.BackgroundImage = global::Yams.Properties.Resources.Dés1;
            this.panel_des1.Location = new System.Drawing.Point(93, 310);
            this.panel_des1.Name = "panel_des1";
            this.panel_des1.Size = new System.Drawing.Size(75, 75);
            this.panel_des1.TabIndex = 14;
            this.panel_des1.Visible = false;
            this.panel_des1.Click += new System.EventHandler(this.panel_des1_Click);
            // 
            // button_throwDice
            // 
            this.button_throwDice.Font = new System.Drawing.Font("Papyrus", 14.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_throwDice.Location = new System.Drawing.Point(253, 335);
            this.button_throwDice.Name = "button_throwDice";
            this.button_throwDice.Size = new System.Drawing.Size(200, 51);
            this.button_throwDice.TabIndex = 6;
            this.button_throwDice.Text = "Lancer  les  dés";
            this.button_throwDice.UseVisualStyleBackColor = true;
            this.button_throwDice.Click += new System.EventHandler(this.button_throwDice_Click);
            // 
            // label_joueurActuel
            // 
            this.label_joueurActuel.BackColor = System.Drawing.Color.Transparent;
            this.label_joueurActuel.Font = new System.Drawing.Font("Papyrus", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label_joueurActuel.ForeColor = System.Drawing.Color.White;
            this.label_joueurActuel.Location = new System.Drawing.Point(203, 220);
            this.label_joueurActuel.Name = "label_joueurActuel";
            this.label_joueurActuel.Size = new System.Drawing.Size(300, 50);
            this.label_joueurActuel.TabIndex = 5;
            this.label_joueurActuel.Text = "Joueur 1, à toi de jouer";
            this.label_joueurActuel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::Yams.Properties.Resources.fond;
            this.panel5.Controls.Add(this.button_back);
            this.panel5.Controls.Add(this.button_replay);
            this.panel5.Controls.Add(this.label_joueur2);
            this.panel5.Controls.Add(this.label_joueur1);
            this.panel5.Controls.Add(this.label_textJoueur2);
            this.panel5.Controls.Add(this.label_textJoueur1);
            this.panel5.Controls.Add(this.panel_des1);
            this.panel5.Controls.Add(this.panel_des2);
            this.panel5.Controls.Add(this.panel_des3);
            this.panel5.Controls.Add(this.panel_des5);
            this.panel5.Controls.Add(this.panel_des4);
            this.panel5.Controls.Add(this.label_joueurActuel);
            this.panel5.Controls.Add(this.button_throwDice);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(706, 721);
            this.panel5.TabIndex = 6;
            // 
            // button_back
            // 
            this.button_back.Font = new System.Drawing.Font("Papyrus", 14.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_back.Location = new System.Drawing.Point(373, 335);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(200, 51);
            this.button_back.TabIndex = 16;
            this.button_back.Text = "Retour";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Visible = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // button_replay
            // 
            this.button_replay.Font = new System.Drawing.Font("Papyrus", 14.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_replay.Location = new System.Drawing.Point(133, 335);
            this.button_replay.Name = "button_replay";
            this.button_replay.Size = new System.Drawing.Size(200, 51);
            this.button_replay.TabIndex = 15;
            this.button_replay.Text = "Rejouer";
            this.button_replay.UseVisualStyleBackColor = true;
            this.button_replay.Visible = false;
            this.button_replay.Click += new System.EventHandler(this.button_replay_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.yamsGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView yamsGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn Column3;
        private System.Windows.Forms.Label label_textJoueur1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label_textJoueur2;
        private System.Windows.Forms.Label label_joueurActuel;
        private System.Windows.Forms.Button button_throwDice;
        private System.Windows.Forms.Label label_joueur1;
        private System.Windows.Forms.Label label_joueur2;
        private System.Windows.Forms.Panel panel_des1;
        private System.Windows.Forms.Panel panel_des5;
        private System.Windows.Forms.Panel panel_des4;
        private System.Windows.Forms.Panel panel_des3;
        private System.Windows.Forms.Panel panel_des2;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Button button_replay;
    }
}