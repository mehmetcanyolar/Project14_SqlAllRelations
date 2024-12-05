namespace Project14_SqlAllRelations
{
    partial class Form1
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
            this.teamsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db14Project20DataSet = new Project14_SqlAllRelations.Db14Project20DataSet();
            this.teamsTableAdapter = new Project14_SqlAllRelations.Db14Project20DataSetTableAdapters.TeamsTableAdapter();
            this.db14Project20DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teamIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamCountryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.db14Project20DataSet1 = new Project14_SqlAllRelations.Db14Project20DataSet1();
            this.teamsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.teamsTableAdapter1 = new Project14_SqlAllRelations.Db14Project20DataSet1TableAdapters.TeamsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db14Project20DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db14Project20DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db14Project20DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.teamIdDataGridViewTextBoxColumn,
            this.teamNameDataGridViewTextBoxColumn,
            this.teamCountryDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.teamsBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1140, 622);
            this.dataGridView1.TabIndex = 0;
            // 
            // teamsBindingSource
            // 
            this.teamsBindingSource.DataMember = "Teams";
            this.teamsBindingSource.DataSource = this.db14Project20DataSet;
            // 
            // db14Project20DataSet
            // 
            this.db14Project20DataSet.DataSetName = "Db14Project20DataSet";
            this.db14Project20DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teamsTableAdapter
            // 
            this.teamsTableAdapter.ClearBeforeFill = true;
            // 
            // db14Project20DataSetBindingSource
            // 
            this.db14Project20DataSetBindingSource.DataSource = this.db14Project20DataSet;
            this.db14Project20DataSetBindingSource.Position = 0;
            // 
            // teamIdDataGridViewTextBoxColumn
            // 
            this.teamIdDataGridViewTextBoxColumn.DataPropertyName = "TeamId";
            this.teamIdDataGridViewTextBoxColumn.HeaderText = "TeamId";
            this.teamIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.teamIdDataGridViewTextBoxColumn.Name = "teamIdDataGridViewTextBoxColumn";
            this.teamIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // teamNameDataGridViewTextBoxColumn
            // 
            this.teamNameDataGridViewTextBoxColumn.DataPropertyName = "TeamName";
            this.teamNameDataGridViewTextBoxColumn.HeaderText = "TeamName";
            this.teamNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.teamNameDataGridViewTextBoxColumn.Name = "teamNameDataGridViewTextBoxColumn";
            // 
            // teamCountryDataGridViewTextBoxColumn
            // 
            this.teamCountryDataGridViewTextBoxColumn.DataPropertyName = "TeamCountry";
            this.teamCountryDataGridViewTextBoxColumn.HeaderText = "TeamCountry";
            this.teamCountryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.teamCountryDataGridViewTextBoxColumn.Name = "teamCountryDataGridViewTextBoxColumn";
            // 
            // db14Project20DataSet1
            // 
            this.db14Project20DataSet1.DataSetName = "Db14Project20DataSet1";
            this.db14Project20DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teamsBindingSource1
            // 
            this.teamsBindingSource1.DataMember = "Teams";
            this.teamsBindingSource1.DataSource = this.db14Project20DataSet1;
            // 
            // teamsTableAdapter1
            // 
            this.teamsTableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 622);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db14Project20DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db14Project20DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db14Project20DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Db14Project20DataSet db14Project20DataSet;
        private System.Windows.Forms.BindingSource teamsBindingSource;
        private Db14Project20DataSetTableAdapters.TeamsTableAdapter teamsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamCountryDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource db14Project20DataSetBindingSource;
        private Db14Project20DataSet1 db14Project20DataSet1;
        private System.Windows.Forms.BindingSource teamsBindingSource1;
        private Db14Project20DataSet1TableAdapters.TeamsTableAdapter teamsTableAdapter1;
    }
}

