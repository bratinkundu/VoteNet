namespace Voting
{
    partial class result
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(result));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.candidateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.votesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headboyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.votingDataSet9 = new Voting.votingDataSet9();
            this.headboyTableAdapter = new Voting.votingDataSet9TableAdapters.HeadboyTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.candidateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.votesDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voteDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headgirlBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.votingDataSet10 = new Voting.votingDataSet10();
            this.headgirlTableAdapter = new Voting.votingDataSet10TableAdapters.HeadgirlTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headboyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.votingDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headgirlBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.votingDataSet10)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "RESULT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(200, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 23);
            this.label2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(25, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "<<Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.candidateDataGridViewTextBoxColumn,
            this.votesDataGridViewTextBoxColumn,
            this.voteDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.headboyBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlText;
            this.dataGridView1.Location = new System.Drawing.Point(113, 162);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.Size = new System.Drawing.Size(324, 100);
            this.dataGridView1.TabIndex = 4;
            // 
            // candidateDataGridViewTextBoxColumn
            // 
            this.candidateDataGridViewTextBoxColumn.DataPropertyName = "candidate";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.candidateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.candidateDataGridViewTextBoxColumn.FillWeight = 200F;
            this.candidateDataGridViewTextBoxColumn.HeaderText = "candidate";
            this.candidateDataGridViewTextBoxColumn.Name = "candidateDataGridViewTextBoxColumn";
            this.candidateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // votesDataGridViewTextBoxColumn
            // 
            this.votesDataGridViewTextBoxColumn.DataPropertyName = "votes";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.votesDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.votesDataGridViewTextBoxColumn.HeaderText = "votes";
            this.votesDataGridViewTextBoxColumn.Name = "votesDataGridViewTextBoxColumn";
            this.votesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // voteDataGridViewTextBoxColumn
            // 
            this.voteDataGridViewTextBoxColumn.DataPropertyName = "vote %";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voteDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.voteDataGridViewTextBoxColumn.HeaderText = "vote %";
            this.voteDataGridViewTextBoxColumn.Name = "voteDataGridViewTextBoxColumn";
            this.voteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // headboyBindingSource
            // 
            this.headboyBindingSource.DataMember = "Headboy";
            this.headboyBindingSource.DataSource = this.votingDataSet9;
            // 
            // votingDataSet9
            // 
            this.votingDataSet9.DataSetName = "votingDataSet9";
            this.votingDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // headboyTableAdapter
            // 
            this.headboyTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.candidateDataGridViewTextBoxColumn1,
            this.votesDataGridViewTextBoxColumn1,
            this.voteDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.headgirlBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(113, 301);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView2.Size = new System.Drawing.Size(324, 102);
            this.dataGridView2.TabIndex = 5;
            // 
            // candidateDataGridViewTextBoxColumn1
            // 
            this.candidateDataGridViewTextBoxColumn1.DataPropertyName = "candidate";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.candidateDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle4;
            this.candidateDataGridViewTextBoxColumn1.HeaderText = "candidate";
            this.candidateDataGridViewTextBoxColumn1.Name = "candidateDataGridViewTextBoxColumn1";
            this.candidateDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // votesDataGridViewTextBoxColumn1
            // 
            this.votesDataGridViewTextBoxColumn1.DataPropertyName = "votes";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.votesDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle5;
            this.votesDataGridViewTextBoxColumn1.HeaderText = "votes";
            this.votesDataGridViewTextBoxColumn1.Name = "votesDataGridViewTextBoxColumn1";
            this.votesDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // voteDataGridViewTextBoxColumn1
            // 
            this.voteDataGridViewTextBoxColumn1.DataPropertyName = "vote %";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voteDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle6;
            this.voteDataGridViewTextBoxColumn1.HeaderText = "vote %";
            this.voteDataGridViewTextBoxColumn1.Name = "voteDataGridViewTextBoxColumn1";
            this.voteDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // headgirlBindingSource
            // 
            this.headgirlBindingSource.DataMember = "Headgirl";
            this.headgirlBindingSource.DataSource = this.votingDataSet10;
            // 
            // votingDataSet10
            // 
            this.votingDataSet10.DataSetName = "votingDataSet10";
            this.votingDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // headgirlTableAdapter
            // 
            this.headgirlTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(148, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total votes:-   ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(278, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 22);
            this.label4.TabIndex = 7;
            // 
            // result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(544, 421);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "result";
            this.Text = "result";
            this.Load += new System.EventHandler(this.result_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headboyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.votingDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headgirlBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.votingDataSet10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private votingDataSet9 votingDataSet9;
        private System.Windows.Forms.BindingSource headboyBindingSource;
        private votingDataSet9TableAdapters.HeadboyTableAdapter headboyTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private votingDataSet10 votingDataSet10;
        private System.Windows.Forms.BindingSource headgirlBindingSource;
        private votingDataSet10TableAdapters.HeadgirlTableAdapter headgirlTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn candidateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn votesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn voteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn candidateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn votesDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn voteDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}