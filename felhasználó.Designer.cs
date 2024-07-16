
namespace Szoftech2_U945X9_Beadandó
{
    partial class felhasználó
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxnév = new System.Windows.Forms.TextBox();
            this.textBoxcim = new System.Windows.Forms.TextBox();
            this.textBoxemailcim = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.névDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.címDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emailcím = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VásárlóFK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vásárlókBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttontörlés = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxFizetés = new System.Windows.Forms.ComboBox();
            this.fizetésiMódBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxÖsszeszereéls = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vásárlókBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fizetésiMódBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Név:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cím:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Emailcím:";
            // 
            // textBoxnév
            // 
            this.textBoxnév.Location = new System.Drawing.Point(101, 87);
            this.textBoxnév.Name = "textBoxnév";
            this.textBoxnév.Size = new System.Drawing.Size(167, 22);
            this.textBoxnév.TabIndex = 1;
            // 
            // textBoxcim
            // 
            this.textBoxcim.Location = new System.Drawing.Point(101, 115);
            this.textBoxcim.Name = "textBoxcim";
            this.textBoxcim.Size = new System.Drawing.Size(167, 22);
            this.textBoxcim.TabIndex = 1;
            // 
            // textBoxemailcim
            // 
            this.textBoxemailcim.Location = new System.Drawing.Point(101, 146);
            this.textBoxemailcim.Name = "textBoxemailcim";
            this.textBoxemailcim.Size = new System.Drawing.Size(167, 22);
            this.textBoxemailcim.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(101, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "Felvétel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.névDataGridViewTextBoxColumn,
            this.címDataGridViewTextBoxColumn,
            this.Emailcím,
            this.VásárlóFK});
            this.dataGridView1.DataSource = this.vásárlókBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(309, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(599, 273);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // névDataGridViewTextBoxColumn
            // 
            this.névDataGridViewTextBoxColumn.DataPropertyName = "Név";
            this.névDataGridViewTextBoxColumn.HeaderText = "Név";
            this.névDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.névDataGridViewTextBoxColumn.Name = "névDataGridViewTextBoxColumn";
            this.névDataGridViewTextBoxColumn.Width = 125;
            // 
            // címDataGridViewTextBoxColumn
            // 
            this.címDataGridViewTextBoxColumn.DataPropertyName = "Cím";
            this.címDataGridViewTextBoxColumn.HeaderText = "Cím";
            this.címDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.címDataGridViewTextBoxColumn.Name = "címDataGridViewTextBoxColumn";
            this.címDataGridViewTextBoxColumn.Width = 125;
            // 
            // Emailcím
            // 
            this.Emailcím.DataPropertyName = "Emailcím";
            this.Emailcím.HeaderText = "Emailcím";
            this.Emailcím.MinimumWidth = 6;
            this.Emailcím.Name = "Emailcím";
            this.Emailcím.Width = 125;
            // 
            // VásárlóFK
            // 
            this.VásárlóFK.DataPropertyName = "VásárlóFK";
            this.VásárlóFK.HeaderText = "VásárlóFK";
            this.VásárlóFK.MinimumWidth = 6;
            this.VásárlóFK.Name = "VásárlóFK";
            this.VásárlóFK.Visible = false;
            this.VásárlóFK.Width = 125;
            // 
            // vásárlókBindingSource
            // 
            this.vásárlókBindingSource.DataSource = typeof(Szoftech2_U945X9_Beadandó.vásárlók);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Adatok:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(537, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Felhasználók:";
            // 
            // buttontörlés
            // 
            this.buttontörlés.Location = new System.Drawing.Point(101, 315);
            this.buttontörlés.Name = "buttontörlés";
            this.buttontörlés.Size = new System.Drawing.Size(167, 45);
            this.buttontörlés.TabIndex = 2;
            this.buttontörlés.Text = "Törlés";
            this.buttontörlés.UseVisualStyleBackColor = true;
            this.buttontörlés.Click += new System.EventHandler(this.buttontörlés_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(87, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Kiválasztott vásárló törlése:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(124, 390);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Rendelés felvétel:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 426);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Rendelés Dátuma:";
            // 
            // comboBoxFizetés
            // 
            this.comboBoxFizetés.DataSource = this.fizetésiMódBindingSource;
            this.comboBoxFizetés.DisplayMember = "Mód";
            this.comboBoxFizetés.FormattingEnabled = true;
            this.comboBoxFizetés.Location = new System.Drawing.Point(168, 507);
            this.comboBoxFizetés.Name = "comboBoxFizetés";
            this.comboBoxFizetés.Size = new System.Drawing.Size(180, 24);
            this.comboBoxFizetés.TabIndex = 8;
            // 
            // fizetésiMódBindingSource
            // 
            this.fizetésiMódBindingSource.DataSource = typeof(Szoftech2_U945X9_Beadandó.FizetésiMód);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(57, 510);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "Fizetési mód:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(43, 467);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Összeszerelés:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(101, 556);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 45);
            this.button2.TabIndex = 2;
            this.button2.Text = "Felvétel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxÖsszeszereéls
            // 
            this.textBoxÖsszeszereéls.Location = new System.Drawing.Point(168, 467);
            this.textBoxÖsszeszereéls.Name = "textBoxÖsszeszereéls";
            this.textBoxÖsszeszereéls.Size = new System.Drawing.Size(86, 22);
            this.textBoxÖsszeszereéls.TabIndex = 6;
            this.textBoxÖsszeszereéls.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxÖsszeszereéls_Validating);
            this.textBoxÖsszeszereéls.Validated += new System.EventHandler(this.textBoxÖsszeszereéls_Validated);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(423, 423);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(134, 212);
            this.listBox1.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(420, 390);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 17);
            this.label11.TabIndex = 5;
            this.label11.Text = "Rendelései:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(-19, -19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(264, 467);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "true / false";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(168, 426);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(180, 22);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // felhasználó
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBoxFizetés);
            this.Controls.Add(this.textBoxÖsszeszereéls);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttontörlés);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxemailcim);
            this.Controls.Add(this.textBoxcim);
            this.Controls.Add(this.textBoxnév);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "felhasználó";
            this.Size = new System.Drawing.Size(1047, 708);
            this.Load += new System.EventHandler(this.felhasználó_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vásárlókBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fizetésiMódBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxnév;
        private System.Windows.Forms.TextBox textBoxcim;
        private System.Windows.Forms.TextBox textBoxemailcim;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn névDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn címDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emailcím;
        private System.Windows.Forms.DataGridViewTextBoxColumn VásárlóFK;
        private System.Windows.Forms.BindingSource vásárlókBindingSource;
        private System.Windows.Forms.Button buttontörlés;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxFizetés;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource fizetésiMódBindingSource;
        private System.Windows.Forms.TextBox textBoxÖsszeszereéls;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
