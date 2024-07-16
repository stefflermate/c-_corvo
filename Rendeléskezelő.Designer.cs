
namespace Szoftech2_U945X9_Beadandó
{
    partial class Rendeléskezelő
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
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxrendelésdátum = new System.Windows.Forms.ListBox();
            this.rendelésBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxnévkereső = new System.Windows.Forms.TextBox();
            this.listBoxnévfelsoroló = new System.Windows.Forms.ListBox();
            this.vásárlóBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttontörlés = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rendelésBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vásárlóBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 17);
            this.label12.TabIndex = 49;
            this.label12.Text = "Nevek:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(212, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 17);
            this.label7.TabIndex = 48;
            this.label7.Text = "Rendelés dátuma:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 47;
            this.label1.Text = "Név kereső:";
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
            this.listBoxrendelésdátum.Location = new System.Drawing.Point(215, 83);
            this.listBoxrendelésdátum.Name = "listBoxrendelésdátum";
            this.listBoxrendelésdátum.Size = new System.Drawing.Size(147, 436);
            this.listBoxrendelésdátum.TabIndex = 46;
            // 
            // rendelésBindingSource
            // 
            this.rendelésBindingSource.DataSource = typeof(Szoftech2_U945X9_Beadandó.Rendelés);
            // 
            // textBoxnévkereső
            // 
            this.textBoxnévkereső.Location = new System.Drawing.Point(19, 29);
            this.textBoxnévkereső.Name = "textBoxnévkereső";
            this.textBoxnévkereső.Size = new System.Drawing.Size(145, 22);
            this.textBoxnévkereső.TabIndex = 45;
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
            this.listBoxnévfelsoroló.Location = new System.Drawing.Point(19, 82);
            this.listBoxnévfelsoroló.Name = "listBoxnévfelsoroló";
            this.listBoxnévfelsoroló.Size = new System.Drawing.Size(145, 436);
            this.listBoxnévfelsoroló.TabIndex = 44;
            this.listBoxnévfelsoroló.SelectedIndexChanged += new System.EventHandler(this.listBoxnévfelsoroló_SelectedIndexChanged);
            // 
            // vásárlóBindingSource
            // 
            this.vásárlóBindingSource.DataSource = typeof(Szoftech2_U945X9_Beadandó.Vásárló);
            // 
            // buttontörlés
            // 
            this.buttontörlés.Location = new System.Drawing.Point(449, 248);
            this.buttontörlés.Name = "buttontörlés";
            this.buttontörlés.Size = new System.Drawing.Size(148, 50);
            this.buttontörlés.TabIndex = 50;
            this.buttontörlés.Text = "törlés";
            this.buttontörlés.UseVisualStyleBackColor = true;
            this.buttontörlés.Click += new System.EventHandler(this.buttontörlés_Click);
            // 
            // Rendeléskezelő
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.Controls.Add(this.buttontörlés);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxrendelésdátum);
            this.Controls.Add(this.textBoxnévkereső);
            this.Controls.Add(this.listBoxnévfelsoroló);
            this.Name = "Rendeléskezelő";
            this.Size = new System.Drawing.Size(685, 601);
            this.Load += new System.EventHandler(this.Rendeléskezelő_Load);
            this.Enter += new System.EventHandler(this.Rendeléskezelő_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.rendelésBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vásárlóBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxrendelésdátum;
        private System.Windows.Forms.TextBox textBoxnévkereső;
        private System.Windows.Forms.ListBox listBoxnévfelsoroló;
        private System.Windows.Forms.BindingSource rendelésBindingSource;
        private System.Windows.Forms.BindingSource vásárlóBindingSource;
        private System.Windows.Forms.Button buttontörlés;
    }
}
