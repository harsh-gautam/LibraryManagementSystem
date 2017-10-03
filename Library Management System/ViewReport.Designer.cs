namespace Library_Management_System
{
    partial class ViewReport
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lib_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.std_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.std_brnch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bk_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bk_auth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_issue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_return = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.penalty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lib_Id,
            this.std_name,
            this.std_brnch,
            this.bk_name,
            this.bk_auth,
            this.date_issue,
            this.date_return,
            this.penalty});
            this.dataGridView1.Location = new System.Drawing.Point(2, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(837, 406);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(355, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Report";
            // 
            // lib_Id
            // 
            this.lib_Id.HeaderText = "Library ID";
            this.lib_Id.Name = "lib_Id";
            // 
            // std_name
            // 
            this.std_name.HeaderText = "Student Name";
            this.std_name.Name = "std_name";
            // 
            // std_brnch
            // 
            this.std_brnch.HeaderText = "Branch";
            this.std_brnch.Name = "std_brnch";
            // 
            // bk_name
            // 
            this.bk_name.HeaderText = "Book Name";
            this.bk_name.Name = "bk_name";
            // 
            // bk_auth
            // 
            this.bk_auth.HeaderText = "Author";
            this.bk_auth.Name = "bk_auth";
            // 
            // date_issue
            // 
            this.date_issue.HeaderText = "Issuing Date";
            this.date_issue.Name = "date_issue";
            // 
            // date_return
            // 
            this.date_return.HeaderText = "Returning Date";
            this.date_return.Name = "date_return";
            // 
            // penalty
            // 
            this.penalty.HeaderText = "Penalty";
            this.penalty.Name = "penalty";
            this.penalty.Width = 98;
            // 
            // ViewReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 478);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ViewReport";
            this.Text = "ViewReport";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lib_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn std_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn std_brnch;
        private System.Windows.Forms.DataGridViewTextBoxColumn bk_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn bk_auth;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_issue;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_return;
        private System.Windows.Forms.DataGridViewTextBoxColumn penalty;
    }
}