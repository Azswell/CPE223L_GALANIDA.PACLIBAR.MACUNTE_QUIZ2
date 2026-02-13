namespace CPE223L_GALANIDA.PACLIBAR.MACUNTE_QUIZ2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtBoxCategory = new TextBox();
            txtBoxModel = new TextBox();
            txtBoxSerialNumber = new TextBox();
            btnRead = new Button();
            btnCreate = new Button();
            dataGridView = new DataGridView();
            btnDelete = new Button();
            btnEdit = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtBoxCategory);
            groupBox1.Controls.Add(txtBoxModel);
            groupBox1.Controls.Add(txtBoxSerialNumber);
            groupBox1.Controls.Add(btnRead);
            groupBox1.Controls.Add(btnCreate);
            groupBox1.Location = new Point(26, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(358, 276);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 154);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 7;
            label3.Text = "Category";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 93);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 6;
            label2.Text = "Model";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 35);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 5;
            label1.Text = "Serial Number";
            // 
            // txtBoxCategory
            // 
            txtBoxCategory.Location = new Point(6, 177);
            txtBoxCategory.Name = "txtBoxCategory";
            txtBoxCategory.Size = new Size(346, 27);
            txtBoxCategory.TabIndex = 4;
            // 
            // txtBoxModel
            // 
            txtBoxModel.Location = new Point(6, 116);
            txtBoxModel.Name = "txtBoxModel";
            txtBoxModel.Size = new Size(346, 27);
            txtBoxModel.TabIndex = 3;
            // 
            // txtBoxSerialNumber
            // 
            txtBoxSerialNumber.Location = new Point(6, 58);
            txtBoxSerialNumber.Name = "txtBoxSerialNumber";
            txtBoxSerialNumber.Size = new Size(346, 27);
            txtBoxSerialNumber.TabIndex = 2;
            // 
            // btnRead
            // 
            btnRead.Location = new Point(258, 241);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(94, 29);
            btnRead.TabIndex = 1;
            btnRead.Text = "Read";
            btnRead.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(258, 210);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 29);
            btnCreate.TabIndex = 0;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(411, 12);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(377, 373);
            dataGridView.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(694, 400);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(594, 400);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(dataGridView);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnCreate;
        private DataGridView dataGridView;
        private Button btnRead;
        private Button btnDelete;
        private Button btnEdit;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtBoxCategory;
        private TextBox txtBoxModel;
        private TextBox txtBoxSerialNumber;
    }
}
