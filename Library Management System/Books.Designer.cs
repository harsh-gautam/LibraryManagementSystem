namespace Library_Management_System
{
    partial class Books
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBkName = new System.Windows.Forms.TextBox();
            this.txtBkAuth = new System.Windows.Forms.TextBox();
            this.txtBkEdi = new System.Windows.Forms.TextBox();
            this.txtBkPgs = new System.Windows.Forms.TextBox();
            this.txtBkPub = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblBookId = new System.Windows.Forms.Label();
            this.Book_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Book_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Book_Auth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Book_Pub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Book_Edi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(126, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(100, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Book Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(137, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Author :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(133, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Edition :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(104, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Publication :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(91, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "No. of Pages :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(138, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Status :";
            // 
            // txtBkName
            // 
            this.txtBkName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBkName.Location = new System.Drawing.Point(212, 58);
            this.txtBkName.Name = "txtBkName";
            this.txtBkName.Size = new System.Drawing.Size(214, 20);
            this.txtBkName.TabIndex = 8;
            // 
            // txtBkAuth
            // 
            this.txtBkAuth.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBkAuth.Location = new System.Drawing.Point(212, 88);
            this.txtBkAuth.Name = "txtBkAuth";
            this.txtBkAuth.Size = new System.Drawing.Size(214, 20);
            this.txtBkAuth.TabIndex = 9;
            // 
            // txtBkEdi
            // 
            this.txtBkEdi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBkEdi.Location = new System.Drawing.Point(212, 119);
            this.txtBkEdi.Name = "txtBkEdi";
            this.txtBkEdi.Size = new System.Drawing.Size(214, 20);
            this.txtBkEdi.TabIndex = 10;
            // 
            // txtBkPgs
            // 
            this.txtBkPgs.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBkPgs.Location = new System.Drawing.Point(212, 180);
            this.txtBkPgs.Name = "txtBkPgs";
            this.txtBkPgs.Size = new System.Drawing.Size(214, 20);
            this.txtBkPgs.TabIndex = 12;
            // 
            // txtBkPub
            // 
            this.txtBkPub.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBkPub.Location = new System.Drawing.Point(212, 149);
            this.txtBkPub.Name = "txtBkPub";
            this.txtBkPub.Size = new System.Drawing.Size(214, 20);
            this.txtBkPub.TabIndex = 11;
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnNew.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnNew.Location = new System.Drawing.Point(557, 87);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(114, 29);
            this.btnNew.TabIndex = 13;
            this.btnNew.Text = "N&ew";
            this.btnNew.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSave.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnSave.Location = new System.Drawing.Point(557, 204);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 29);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "S&ave";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnDel.Location = new System.Drawing.Point(557, 165);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(114, 29);
            this.btnDel.TabIndex = 15;
            this.btnDel.Text = "Del&ete";
            this.btnDel.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnUpdate.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnUpdate.Location = new System.Drawing.Point(557, 127);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(114, 29);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Up&date";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // cbStatus
            // 
            this.cbStatus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Available",
            "Not-Available"});
            this.cbStatus.Location = new System.Drawing.Point(212, 212);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(214, 21);
            this.cbStatus.TabIndex = 17;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Book_Id,
            this.Book_Name,
            this.Book_Auth,
            this.Book_Pub,
            this.Book_Edi,
            this.status});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridView1.Location = new System.Drawing.Point(38, 266);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(765, 202);
            this.dataGridView1.TabIndex = 18;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSearch.Location = new System.Drawing.Point(516, 24);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(160, 20);
            this.txtSearch.TabIndex = 19;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSearch.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnSearch.Location = new System.Drawing.Point(682, 22);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // lblBookId
            // 
            this.lblBookId.AutoSize = true;
            this.lblBookId.Location = new System.Drawing.Point(216, 30);
            this.lblBookId.Name = "lblBookId";
            this.lblBookId.Size = new System.Drawing.Size(44, 13);
            this.lblBookId.TabIndex = 21;
            this.lblBookId.Text = "Book Id";
            // 
            // Book_Id
            // 
            this.Book_Id.DividerWidth = 1;
            this.Book_Id.HeaderText = "Book ID";
            this.Book_Id.Name = "Book_Id";
            this.Book_Id.ReadOnly = true;
            this.Book_Id.Width = 80;
            // 
            // Book_Name
            // 
            this.Book_Name.DividerWidth = 1;
            this.Book_Name.HeaderText = "Name";
            this.Book_Name.Name = "Book_Name";
            this.Book_Name.ReadOnly = true;
            this.Book_Name.Width = 140;
            // 
            // Book_Auth
            // 
            this.Book_Auth.DividerWidth = 1;
            this.Book_Auth.HeaderText = "Author";
            this.Book_Auth.Name = "Book_Auth";
            this.Book_Auth.ReadOnly = true;
            this.Book_Auth.Width = 120;
            // 
            // Book_Pub
            // 
            this.Book_Pub.DividerWidth = 1;
            this.Book_Pub.HeaderText = "Publication";
            this.Book_Pub.Name = "Book_Pub";
            this.Book_Pub.ReadOnly = true;
            this.Book_Pub.Width = 140;
            // 
            // Book_Edi
            // 
            this.Book_Edi.DividerWidth = 1;
            this.Book_Edi.HeaderText = "Edition";
            this.Book_Edi.Name = "Book_Edi";
            this.Book_Edi.ReadOnly = true;
            this.Book_Edi.Width = 120;
            // 
            // status
            // 
            this.status.DividerWidth = 1;
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Width = 122;
            // 
            // Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(837, 471);
            this.ControlBox = false;
            this.Controls.Add(this.lblBookId);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBkName);
            this.Controls.Add(this.txtBkPub);
            this.Controls.Add(this.txtBkPgs);
            this.Controls.Add(this.txtBkAuth);
            this.Controls.Add(this.txtBkEdi);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUpdate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Books";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Books";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Books_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBkName;
        private System.Windows.Forms.TextBox txtBkAuth;
        private System.Windows.Forms.TextBox txtBkEdi;
        private System.Windows.Forms.TextBox txtBkPub;
        private System.Windows.Forms.TextBox txtBkPgs;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblBookId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book_Auth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book_Pub;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book_Edi;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}