
namespace Szoftech2_U945X9_Beadandó
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridViewRendelttermék = new System.Windows.Forms.DataGridView();
            this.névDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mennyiségDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.árDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rendelésAzonosítóDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rendeltTermékekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxújmennyiség = new System.Windows.Forms.TextBox();
            this.comboBoxTermékkategoria = new System.Windows.Forms.ComboBox();
            this.textBoxösszeszerelés = new System.Windows.Forms.TextBox();
            this.textBoxÁr = new System.Windows.Forms.TextBox();
            this.buttonlevétel = new System.Windows.Forms.Button();
            this.buttonhozáadás = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSúly = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxTermékek = new System.Windows.Forms.ListBox();
            this.termékBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listBoxrendelésdátum = new System.Windows.Forms.ListBox();
            this.rendelésBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxnévkereső = new System.Windows.Forms.TextBox();
            this.listBoxnévfelsoroló = new System.Windows.Forms.ListBox();
            this.vásárlóBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRendelttermék)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rendeltTermékekBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.termékBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rendelésBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vásárlóBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 17);
            this.label12.TabIndex = 43;
            this.label12.Text = "Nevek:";
            // 
            // dataGridViewRendelttermék
            // 
            this.dataGridViewRendelttermék.AllowUserToAddRows = false;
            this.dataGridViewRendelttermék.AllowUserToDeleteRows = false;
            this.dataGridViewRendelttermék.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewRendelttermék.AutoGenerateColumns = false;
            this.dataGridViewRendelttermék.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRendelttermék.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.névDataGridViewTextBoxColumn,
            this.mennyiségDataGridViewTextBoxColumn,
            this.árDataGridViewTextBoxColumn,
            this.rendelésAzonosítóDataGridViewTextBoxColumn});
            this.dataGridViewRendelttermék.DataSource = this.rendeltTermékekBindingSource;
            this.dataGridViewRendelttermék.Location = new System.Drawing.Point(406, 92);
            this.dataGridViewRendelttermék.Name = "dataGridViewRendelttermék";
            this.dataGridViewRendelttermék.ReadOnly = true;
            this.dataGridViewRendelttermék.RowHeadersWidth = 51;
            this.dataGridViewRendelttermék.RowTemplate.Height = 24;
            this.dataGridViewRendelttermék.Size = new System.Drawing.Size(401, 435);
            this.dataGridViewRendelttermék.TabIndex = 42;
            // 
            // névDataGridViewTextBoxColumn
            // 
            this.névDataGridViewTextBoxColumn.DataPropertyName = "Név";
            this.névDataGridViewTextBoxColumn.HeaderText = "Név";
            this.névDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.névDataGridViewTextBoxColumn.Name = "névDataGridViewTextBoxColumn";
            this.névDataGridViewTextBoxColumn.ReadOnly = true;
            this.névDataGridViewTextBoxColumn.Width = 125;
            // 
            // mennyiségDataGridViewTextBoxColumn
            // 
            this.mennyiségDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.mennyiségDataGridViewTextBoxColumn.DataPropertyName = "Mennyiség";
            this.mennyiségDataGridViewTextBoxColumn.HeaderText = "Mennyiség";
            this.mennyiségDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mennyiségDataGridViewTextBoxColumn.Name = "mennyiségDataGridViewTextBoxColumn";
            this.mennyiségDataGridViewTextBoxColumn.ReadOnly = true;
            this.mennyiségDataGridViewTextBoxColumn.Width = 105;
            // 
            // árDataGridViewTextBoxColumn
            // 
            this.árDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.árDataGridViewTextBoxColumn.DataPropertyName = "Ár";
            this.árDataGridViewTextBoxColumn.HeaderText = "Ár";
            this.árDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.árDataGridViewTextBoxColumn.Name = "árDataGridViewTextBoxColumn";
            this.árDataGridViewTextBoxColumn.ReadOnly = true;
            this.árDataGridViewTextBoxColumn.Width = 6;
            // 
            // rendelésAzonosítóDataGridViewTextBoxColumn
            // 
            this.rendelésAzonosítóDataGridViewTextBoxColumn.DataPropertyName = "RendelésAzonosító";
            this.rendelésAzonosítóDataGridViewTextBoxColumn.HeaderText = "RendelésAzonosító";
            this.rendelésAzonosítóDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rendelésAzonosítóDataGridViewTextBoxColumn.Name = "rendelésAzonosítóDataGridViewTextBoxColumn";
            this.rendelésAzonosítóDataGridViewTextBoxColumn.ReadOnly = true;
            this.rendelésAzonosítóDataGridViewTextBoxColumn.Visible = false;
            this.rendelésAzonosítóDataGridViewTextBoxColumn.Width = 125;
            // 
            // rendeltTermékekBindingSource
            // 
            this.rendeltTermékekBindingSource.DataSource = typeof(Szoftech2_U945X9_Beadandó.RendeltTermékek);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(839, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 17);
            this.label11.TabIndex = 41;
            this.label11.Text = "Kategoriák:";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(403, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 17);
            this.label10.TabIndex = 40;
            this.label10.Text = "Rendelt termékek:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(948, 567);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 17);
            this.label8.TabIndex = 39;
            this.label8.Text = "db.";
            // 
            // textBoxújmennyiség
            // 
            this.textBoxújmennyiség.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxújmennyiség.Location = new System.Drawing.Point(842, 564);
            this.textBoxújmennyiség.Name = "textBoxújmennyiség";
            this.textBoxújmennyiség.Size = new System.Drawing.Size(100, 22);
            this.textBoxújmennyiség.TabIndex = 38;
            this.textBoxújmennyiség.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxújmennyiség_Validating);
            this.textBoxújmennyiség.Validated += new System.EventHandler(this.textBoxújmennyiség_Validated);
            // 
            // comboBoxTermékkategoria
            // 
            this.comboBoxTermékkategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxTermékkategoria.FormattingEnabled = true;
            this.comboBoxTermékkategoria.Location = new System.Drawing.Point(838, 38);
            this.comboBoxTermékkategoria.Name = "comboBoxTermékkategoria";
            this.comboBoxTermékkategoria.Size = new System.Drawing.Size(188, 24);
            this.comboBoxTermékkategoria.TabIndex = 37;
            this.comboBoxTermékkategoria.SelectedIndexChanged += new System.EventHandler(this.comboBoxTermékkategoria_SelectedIndexChanged_1);
            // 
            // textBoxösszeszerelés
            // 
            this.textBoxösszeszerelés.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxösszeszerelés.Location = new System.Drawing.Point(563, 613);
            this.textBoxösszeszerelés.Name = "textBoxösszeszerelés";
            this.textBoxösszeszerelés.Size = new System.Drawing.Size(174, 22);
            this.textBoxösszeszerelés.TabIndex = 36;
            // 
            // textBoxÁr
            // 
            this.textBoxÁr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxÁr.Location = new System.Drawing.Point(563, 585);
            this.textBoxÁr.Name = "textBoxÁr";
            this.textBoxÁr.Size = new System.Drawing.Size(174, 22);
            this.textBoxÁr.TabIndex = 35;
            // 
            // buttonlevétel
            // 
            this.buttonlevétel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonlevétel.Location = new System.Drawing.Point(842, 647);
            this.buttonlevétel.Name = "buttonlevétel";
            this.buttonlevétel.Size = new System.Drawing.Size(184, 43);
            this.buttonlevétel.TabIndex = 33;
            this.buttonlevétel.Text = "Levétel";
            this.buttonlevétel.UseVisualStyleBackColor = true;
            this.buttonlevétel.Click += new System.EventHandler(this.buttonlevétel_Click_1);
            // 
            // buttonhozáadás
            // 
            this.buttonhozáadás.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonhozáadás.Location = new System.Drawing.Point(842, 598);
            this.buttonhozáadás.Name = "buttonhozáadás";
            this.buttonhozáadás.Size = new System.Drawing.Size(184, 43);
            this.buttonhozáadás.TabIndex = 34;
            this.buttonhozáadás.Text = "Hozzáadás";
            this.buttonhozáadás.UseVisualStyleBackColor = true;
            this.buttonhozáadás.Click += new System.EventHandler(this.buttonhozáadás_Click_1);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(743, 588);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "Ft";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(743, 561);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "Kg.";
            // 
            // textBoxSúly
            // 
            this.textBoxSúly.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSúly.Location = new System.Drawing.Point(563, 556);
            this.textBoxSúly.Name = "textBoxSúly";
            this.textBoxSúly.Size = new System.Drawing.Size(174, 22);
            this.textBoxSúly.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(451, 616);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 17);
            this.label6.TabIndex = 29;
            this.label6.Text = "Összeszerelés:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(459, 588);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "Rendelés ára:";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(839, 541);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 17);
            this.label9.TabIndex = 27;
            this.label9.Text = "Kívánt mennyiség:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(447, 561);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Rendelés súlya:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(212, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "Rendelés dátuma:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Név kereső:";
            // 
            // listBoxTermékek
            // 
            this.listBoxTermékek.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxTermékek.DataSource = this.termékBindingSource;
            this.listBoxTermékek.DisplayMember = "TermékNév";
            this.listBoxTermékek.FormattingEnabled = true;
            this.listBoxTermékek.ItemHeight = 16;
            this.listBoxTermékek.Location = new System.Drawing.Point(838, 91);
            this.listBoxTermékek.Name = "listBoxTermékek";
            this.listBoxTermékek.Size = new System.Drawing.Size(188, 436);
            this.listBoxTermékek.TabIndex = 23;
            // 
            // termékBindingSource
            // 
            this.termékBindingSource.DataSource = typeof(Szoftech2_U945X9_Beadandó.Termék);
            // 
            // listBoxrendelésdátum
            // 
            this.listBoxrendelésdátum.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxrendelésdátum.DataSource = this.rendelésBindingSource;
            this.listBoxrendelésdátum.DisplayMember = "Rendelés_Dátum";
            this.listBoxrendelésdátum.FormattingEnabled = true;
            this.listBoxrendelésdátum.ItemHeight = 16;
            this.listBoxrendelésdátum.Location = new System.Drawing.Point(215, 93);
            this.listBoxrendelésdátum.Name = "listBoxrendelésdátum";
            this.listBoxrendelésdátum.Size = new System.Drawing.Size(147, 436);
            this.listBoxrendelésdátum.TabIndex = 22;
            this.listBoxrendelésdátum.SelectedIndexChanged += new System.EventHandler(this.listBoxrendelésdátum_SelectedIndexChanged_1);
            // 
            // rendelésBindingSource
            // 
            this.rendelésBindingSource.DataSource = typeof(Szoftech2_U945X9_Beadandó.Rendelés);
            // 
            // textBoxnévkereső
            // 
            this.textBoxnévkereső.Location = new System.Drawing.Point(19, 39);
            this.textBoxnévkereső.Name = "textBoxnévkereső";
            this.textBoxnévkereső.Size = new System.Drawing.Size(145, 22);
            this.textBoxnévkereső.TabIndex = 21;
            this.textBoxnévkereső.TextChanged += new System.EventHandler(this.textBoxnévkereső_TextChanged);
            // 
            // listBoxnévfelsoroló
            // 
            this.listBoxnévfelsoroló.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxnévfelsoroló.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.listBoxnévfelsoroló.DataSource = this.vásárlóBindingSource;
            this.listBoxnévfelsoroló.DisplayMember = "Név";
            this.listBoxnévfelsoroló.FormattingEnabled = true;
            this.listBoxnévfelsoroló.ItemHeight = 16;
            this.listBoxnévfelsoroló.Location = new System.Drawing.Point(19, 92);
            this.listBoxnévfelsoroló.Name = "listBoxnévfelsoroló";
            this.listBoxnévfelsoroló.Size = new System.Drawing.Size(145, 436);
            this.listBoxnévfelsoroló.TabIndex = 20;
            this.listBoxnévfelsoroló.SelectedIndexChanged += new System.EventHandler(this.listBoxnévfelsoroló_SelectedIndexChanged_1);
            // 
            // vásárlóBindingSource
            // 
            this.vásárlóBindingSource.DataSource = typeof(Szoftech2_U945X9_Beadandó.Vásárló);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dataGridViewRendelttermék);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxújmennyiség);
            this.Controls.Add(this.comboBoxTermékkategoria);
            this.Controls.Add(this.textBoxösszeszerelés);
            this.Controls.Add(this.textBoxÁr);
            this.Controls.Add(this.buttonlevétel);
            this.Controls.Add(this.buttonhozáadás);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSúly);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxTermékek);
            this.Controls.Add(this.listBoxrendelésdátum);
            this.Controls.Add(this.textBoxnévkereső);
            this.Controls.Add(this.listBoxnévfelsoroló);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1046, 708);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.Enter += new System.EventHandler(this.UserControl1_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRendelttermék)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rendeltTermékekBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.termékBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rendelésBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vásárlóBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataGridViewRendelttermék;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxújmennyiség;
        private System.Windows.Forms.ComboBox comboBoxTermékkategoria;
        private System.Windows.Forms.TextBox textBoxösszeszerelés;
        private System.Windows.Forms.TextBox textBoxÁr;
        private System.Windows.Forms.Button buttonlevétel;
        private System.Windows.Forms.Button buttonhozáadás;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSúly;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxTermékek;
        private System.Windows.Forms.ListBox listBoxrendelésdátum;
        private System.Windows.Forms.TextBox textBoxnévkereső;
        private System.Windows.Forms.ListBox listBoxnévfelsoroló;
        private System.Windows.Forms.BindingSource rendeltTermékekBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn névDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mennyiségDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn árDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rendelésAzonosítóDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vásárlóBindingSource;
        private System.Windows.Forms.BindingSource rendelésBindingSource;
        private System.Windows.Forms.BindingSource termékBindingSource;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
