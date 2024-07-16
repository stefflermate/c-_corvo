
namespace Szoftech2_U945X9_Beadandó
{
    partial class termékek
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(termékek));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.termékSKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.termékNévDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategoriaFKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.márkaFKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.árDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elemszámDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.súlyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.méretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.márkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rendeltTermékDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.termékBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.termékBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.YellowGreen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.termékSKDataGridViewTextBoxColumn,
            this.termékNévDataGridViewTextBoxColumn,
            this.kategoriaFKDataGridViewTextBoxColumn,
            this.márkaFKDataGridViewTextBoxColumn,
            this.árDataGridViewTextBoxColumn,
            this.elemszámDataGridViewTextBoxColumn,
            this.súlyDataGridViewTextBoxColumn,
            this.méretDataGridViewTextBoxColumn,
            this.kategoriaDataGridViewTextBoxColumn,
            this.márkaDataGridViewTextBoxColumn,
            this.rendeltTermékDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.termékBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridView1.Location = new System.Drawing.Point(0, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(741, 519);
            this.dataGridView1.TabIndex = 0;
            // 
            // termékSKDataGridViewTextBoxColumn
            // 
            this.termékSKDataGridViewTextBoxColumn.DataPropertyName = "TermékSK";
            this.termékSKDataGridViewTextBoxColumn.HeaderText = "TermékSK";
            this.termékSKDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.termékSKDataGridViewTextBoxColumn.Name = "termékSKDataGridViewTextBoxColumn";
            this.termékSKDataGridViewTextBoxColumn.Visible = false;
            this.termékSKDataGridViewTextBoxColumn.Width = 125;
            // 
            // termékNévDataGridViewTextBoxColumn
            // 
            this.termékNévDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.termékNévDataGridViewTextBoxColumn.DataPropertyName = "TermékNév";
            this.termékNévDataGridViewTextBoxColumn.HeaderText = "TermékNév";
            this.termékNévDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.termékNévDataGridViewTextBoxColumn.Name = "termékNévDataGridViewTextBoxColumn";
            this.termékNévDataGridViewTextBoxColumn.Width = 110;
            // 
            // kategoriaFKDataGridViewTextBoxColumn
            // 
            this.kategoriaFKDataGridViewTextBoxColumn.DataPropertyName = "KategoriaFK";
            this.kategoriaFKDataGridViewTextBoxColumn.HeaderText = "KategoriaFK";
            this.kategoriaFKDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kategoriaFKDataGridViewTextBoxColumn.Name = "kategoriaFKDataGridViewTextBoxColumn";
            this.kategoriaFKDataGridViewTextBoxColumn.Visible = false;
            this.kategoriaFKDataGridViewTextBoxColumn.Width = 125;
            // 
            // márkaFKDataGridViewTextBoxColumn
            // 
            this.márkaFKDataGridViewTextBoxColumn.DataPropertyName = "MárkaFK";
            this.márkaFKDataGridViewTextBoxColumn.HeaderText = "MárkaFK";
            this.márkaFKDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.márkaFKDataGridViewTextBoxColumn.Name = "márkaFKDataGridViewTextBoxColumn";
            this.márkaFKDataGridViewTextBoxColumn.Visible = false;
            this.márkaFKDataGridViewTextBoxColumn.Width = 125;
            // 
            // árDataGridViewTextBoxColumn
            // 
            this.árDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.árDataGridViewTextBoxColumn.DataPropertyName = "Ár";
            this.árDataGridViewTextBoxColumn.HeaderText = "Ár";
            this.árDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.árDataGridViewTextBoxColumn.Name = "árDataGridViewTextBoxColumn";
            this.árDataGridViewTextBoxColumn.Width = 51;
            // 
            // elemszámDataGridViewTextBoxColumn
            // 
            this.elemszámDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.elemszámDataGridViewTextBoxColumn.DataPropertyName = "Elemszám";
            this.elemszámDataGridViewTextBoxColumn.HeaderText = "Elemszám";
            this.elemszámDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.elemszámDataGridViewTextBoxColumn.Name = "elemszámDataGridViewTextBoxColumn";
            this.elemszámDataGridViewTextBoxColumn.Width = 101;
            // 
            // súlyDataGridViewTextBoxColumn
            // 
            this.súlyDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.súlyDataGridViewTextBoxColumn.DataPropertyName = "Súly";
            this.súlyDataGridViewTextBoxColumn.HeaderText = "Súly";
            this.súlyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.súlyDataGridViewTextBoxColumn.Name = "súlyDataGridViewTextBoxColumn";
            this.súlyDataGridViewTextBoxColumn.Width = 64;
            // 
            // méretDataGridViewTextBoxColumn
            // 
            this.méretDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.méretDataGridViewTextBoxColumn.DataPropertyName = "Méret";
            this.méretDataGridViewTextBoxColumn.HeaderText = "Méret";
            this.méretDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.méretDataGridViewTextBoxColumn.Name = "méretDataGridViewTextBoxColumn";
            this.méretDataGridViewTextBoxColumn.Width = 73;
            // 
            // kategoriaDataGridViewTextBoxColumn
            // 
            this.kategoriaDataGridViewTextBoxColumn.DataPropertyName = "Kategoria";
            this.kategoriaDataGridViewTextBoxColumn.HeaderText = "Kategoria";
            this.kategoriaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kategoriaDataGridViewTextBoxColumn.Name = "kategoriaDataGridViewTextBoxColumn";
            this.kategoriaDataGridViewTextBoxColumn.Visible = false;
            this.kategoriaDataGridViewTextBoxColumn.Width = 125;
            // 
            // márkaDataGridViewTextBoxColumn
            // 
            this.márkaDataGridViewTextBoxColumn.DataPropertyName = "Márka";
            this.márkaDataGridViewTextBoxColumn.HeaderText = "Márka";
            this.márkaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.márkaDataGridViewTextBoxColumn.Name = "márkaDataGridViewTextBoxColumn";
            this.márkaDataGridViewTextBoxColumn.Visible = false;
            this.márkaDataGridViewTextBoxColumn.Width = 125;
            // 
            // rendeltTermékDataGridViewTextBoxColumn
            // 
            this.rendeltTermékDataGridViewTextBoxColumn.DataPropertyName = "Rendelt_Termék";
            this.rendeltTermékDataGridViewTextBoxColumn.HeaderText = "Rendelt_Termék";
            this.rendeltTermékDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rendeltTermékDataGridViewTextBoxColumn.Name = "rendeltTermékDataGridViewTextBoxColumn";
            this.rendeltTermékDataGridViewTextBoxColumn.Visible = false;
            this.rendeltTermékDataGridViewTextBoxColumn.Width = 125;
            // 
            // termékBindingSource
            // 
            this.termékBindingSource.DataSource = typeof(Szoftech2_U945X9_Beadandó.Termék);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BackColor = System.Drawing.Color.YellowGreen;
            this.bindingNavigator1.BindingSource = this.termékBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripButton1});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(741, 27);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // termékek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "termékek";
            this.Size = new System.Drawing.Size(741, 549);
            this.Load += new System.EventHandler(this.termékek_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.termékBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource termékBindingSource;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridViewTextBoxColumn termékSKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn termékNévDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategoriaFKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn márkaFKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn árDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn elemszámDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn súlyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn méretDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn márkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rendeltTermékDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}
