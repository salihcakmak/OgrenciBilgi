namespace OgrenciBilgi
{
    partial class datasetform
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fakulteIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fakulteAdıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fakultelerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.universite = new OgrenciBilgi.Universite();
            this.fakultelerTableAdapter = new OgrenciBilgi.UniversiteTableAdapters.FakultelerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakultelerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universite)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fakulteIDDataGridViewTextBoxColumn,
            this.fakulteAdıDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fakultelerBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 279);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 276);
            this.dataGridView1.TabIndex = 1;
            // 
            // fakulteIDDataGridViewTextBoxColumn
            // 
            this.fakulteIDDataGridViewTextBoxColumn.DataPropertyName = "fakulteID";
            this.fakulteIDDataGridViewTextBoxColumn.HeaderText = "fakulteID";
            this.fakulteIDDataGridViewTextBoxColumn.Name = "fakulteIDDataGridViewTextBoxColumn";
            this.fakulteIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fakulteAdıDataGridViewTextBoxColumn
            // 
            this.fakulteAdıDataGridViewTextBoxColumn.DataPropertyName = "FakulteAdı";
            this.fakulteAdıDataGridViewTextBoxColumn.HeaderText = "FakulteAdı";
            this.fakulteAdıDataGridViewTextBoxColumn.Name = "fakulteAdıDataGridViewTextBoxColumn";
            // 
            // fakultelerBindingSource
            // 
            this.fakultelerBindingSource.DataMember = "Fakulteler";
            this.fakultelerBindingSource.DataSource = this.universite;
            // 
            // universite
            // 
            this.universite.DataSetName = "Universite";
            this.universite.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fakultelerTableAdapter
            // 
            this.fakultelerTableAdapter.ClearBeforeFill = true;
            // 
            // datasetform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 555);
            this.Controls.Add(this.dataGridView1);
            this.Name = "datasetform";
            this.Text = "datasetform";
            this.Load += new System.EventHandler(this.datasetform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakultelerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universite)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Universite universite;
        private System.Windows.Forms.BindingSource fakultelerBindingSource;
        private UniversiteTableAdapters.FakultelerTableAdapter fakultelerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fakulteIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fakulteAdıDataGridViewTextBoxColumn;
    }
}