namespace ConnectedStu
{
    partial class Student
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
            this.dropBox = new System.Windows.Forms.ComboBox();
            this.btnShowAllStu = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textPercentage = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.textRollno = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.percentage = new System.Windows.Forms.Label();
            this.branch = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.rollno = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dropBox
            // 
            this.dropBox.FormattingEnabled = true;
            this.dropBox.Location = new System.Drawing.Point(283, 221);
            this.dropBox.Name = "dropBox";
            this.dropBox.Size = new System.Drawing.Size(69, 24);
            this.dropBox.TabIndex = 27;
            // 
            // btnShowAllStu
            // 
            this.btnShowAllStu.Location = new System.Drawing.Point(916, 420);
            this.btnShowAllStu.Name = "btnShowAllStu";
            this.btnShowAllStu.Size = new System.Drawing.Size(214, 56);
            this.btnShowAllStu.TabIndex = 26;
            this.btnShowAllStu.Text = "Show All Student";
            this.btnShowAllStu.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(707, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(619, 298);
            this.dataGridView1.TabIndex = 25;
            // 
            // textPercentage
            // 
            this.textPercentage.Location = new System.Drawing.Point(283, 268);
            this.textPercentage.Name = "textPercentage";
            this.textPercentage.Size = new System.Drawing.Size(154, 22);
            this.textPercentage.TabIndex = 24;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(283, 169);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(154, 22);
            this.textName.TabIndex = 23;
            // 
            // textRollno
            // 
            this.textRollno.Location = new System.Drawing.Point(283, 119);
            this.textRollno.Name = "textRollno";
            this.textRollno.Size = new System.Drawing.Size(154, 22);
            this.textRollno.TabIndex = 22;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(337, 444);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 44);
            this.btnSearch.TabIndex = 21;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(198, 442);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 46);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(335, 378);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(102, 44);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(195, 378);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 44);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // percentage
            // 
            this.percentage.AutoSize = true;
            this.percentage.Location = new System.Drawing.Point(173, 271);
            this.percentage.Name = "percentage";
            this.percentage.Size = new System.Drawing.Size(77, 16);
            this.percentage.TabIndex = 17;
            this.percentage.Text = "Percentage";
            // 
            // branch
            // 
            this.branch.AutoSize = true;
            this.branch.Location = new System.Drawing.Point(173, 224);
            this.branch.Name = "branch";
            this.branch.Size = new System.Drawing.Size(49, 16);
            this.branch.TabIndex = 16;
            this.branch.Text = "Branch";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(173, 175);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(44, 16);
            this.name.TabIndex = 15;
            this.name.Text = "Name";
            // 
            // rollno
            // 
            this.rollno.AutoSize = true;
            this.rollno.Location = new System.Drawing.Point(173, 122);
            this.rollno.Name = "rollno";
            this.rollno.Size = new System.Drawing.Size(52, 16);
            this.rollno.TabIndex = 14;
            this.rollno.Text = "Roll No";
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1429, 720);
            this.Controls.Add(this.dropBox);
            this.Controls.Add(this.btnShowAllStu);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textPercentage);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textRollno);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.percentage);
            this.Controls.Add(this.branch);
            this.Controls.Add(this.name);
            this.Controls.Add(this.rollno);
            this.Name = "Student";
            this.Text = "Student";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox dropBox;
        private System.Windows.Forms.Button btnShowAllStu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textPercentage;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textRollno;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label percentage;
        private System.Windows.Forms.Label branch;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label rollno;
    }
}