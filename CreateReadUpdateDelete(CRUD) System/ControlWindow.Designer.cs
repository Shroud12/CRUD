
namespace CreateReadUpdateDelete_CRUD__System
{
    partial class ControlWindow
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelClass = new System.Windows.Forms.Label();
            this.labelRollno = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelAssignment = new System.Windows.Forms.Label();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.textName = new System.Windows.Forms.TextBox();
            this.textClass = new System.Windows.Forms.TextBox();
            this.textRoll = new System.Windows.Forms.TextBox();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PictureMinimize = new System.Windows.Forms.PictureBox();
            this.PictureClose = new System.Windows.Forms.PictureBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.radio_submitted = new System.Windows.Forms.RadioButton();
            this.radio_not = new System.Windows.Forms.RadioButton();
            this.groupStatus = new System.Windows.Forms.GroupBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLASS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ROLLNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ASSIGNMENT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PHONE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureClose)).BeginInit();
            this.groupStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(43, 106);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(64, 25);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // labelClass
            // 
            this.labelClass.AutoSize = true;
            this.labelClass.BackColor = System.Drawing.Color.Transparent;
            this.labelClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClass.Location = new System.Drawing.Point(43, 156);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(62, 25);
            this.labelClass.TabIndex = 0;
            this.labelClass.Text = "Class";
            // 
            // labelRollno
            // 
            this.labelRollno.AutoSize = true;
            this.labelRollno.BackColor = System.Drawing.Color.Transparent;
            this.labelRollno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRollno.Location = new System.Drawing.Point(43, 206);
            this.labelRollno.Name = "labelRollno";
            this.labelRollno.Size = new System.Drawing.Size(74, 25);
            this.labelRollno.TabIndex = 0;
            this.labelRollno.Text = "Roll No";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.BackColor = System.Drawing.Color.Transparent;
            this.labelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.Location = new System.Drawing.Point(43, 323);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(143, 25);
            this.labelPhone.TabIndex = 0;
            this.labelPhone.Text = "Phone Number";
            // 
            // labelAssignment
            // 
            this.labelAssignment.AutoSize = true;
            this.labelAssignment.BackColor = System.Drawing.Color.Transparent;
            this.labelAssignment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAssignment.Location = new System.Drawing.Point(43, 256);
            this.labelAssignment.Name = "labelAssignment";
            this.labelAssignment.Size = new System.Drawing.Size(120, 25);
            this.labelAssignment.TabIndex = 0;
            this.labelAssignment.Text = "Assignment ";
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NAME,
            this.CLASS,
            this.ROLLNO,
            this.ASSIGNMENT,
            this.PHONE});
            this.dgv1.Location = new System.Drawing.Point(48, 380);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersWidth = 51;
            this.dgv1.RowTemplate.Height = 24;
            this.dgv1.Size = new System.Drawing.Size(512, 161);
            this.dgv1.TabIndex = 1;
            this.dgv1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv1_CellMouseClick);
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(228, 110);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(164, 22);
            this.textName.TabIndex = 2;
            // 
            // textClass
            // 
            this.textClass.Location = new System.Drawing.Point(228, 160);
            this.textClass.Name = "textClass";
            this.textClass.Size = new System.Drawing.Size(164, 22);
            this.textClass.TabIndex = 2;
            // 
            // textRoll
            // 
            this.textRoll.Location = new System.Drawing.Point(228, 210);
            this.textRoll.Name = "textRoll";
            this.textRoll.Size = new System.Drawing.Size(164, 22);
            this.textRoll.TabIndex = 2;
            // 
            // textPhone
            // 
            this.textPhone.Location = new System.Drawing.Point(228, 327);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(164, 22);
            this.textPhone.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(507, 44);
            this.label6.TabIndex = 3;
            this.label6.Text = "School Management System";
            // 
            // PictureMinimize
            // 
            this.PictureMinimize.BackColor = System.Drawing.Color.Transparent;
            this.PictureMinimize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureMinimize.Image = global::CreateReadUpdateDelete_CRUD__System.Properties.Resources.minimize;
            this.PictureMinimize.Location = new System.Drawing.Point(480, 10);
            this.PictureMinimize.Name = "PictureMinimize";
            this.PictureMinimize.Size = new System.Drawing.Size(30, 30);
            this.PictureMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureMinimize.TabIndex = 4;
            this.PictureMinimize.TabStop = false;
            this.PictureMinimize.Click += new System.EventHandler(this.PictureMinimize_Click);
            // 
            // PictureClose
            // 
            this.PictureClose.BackColor = System.Drawing.Color.Transparent;
            this.PictureClose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureClose.Image = global::CreateReadUpdateDelete_CRUD__System.Properties.Resources.Close;
            this.PictureClose.Location = new System.Drawing.Point(530, 10);
            this.PictureClose.Name = "PictureClose";
            this.PictureClose.Size = new System.Drawing.Size(30, 30);
            this.PictureClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureClose.TabIndex = 4;
            this.PictureClose.TabStop = false;
            this.PictureClose.Click += new System.EventHandler(this.PictureClose_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Transparent;
            this.saveButton.Location = new System.Drawing.Point(472, 160);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 35);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Transparent;
            this.buttonDelete.Location = new System.Drawing.Point(472, 260);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 35);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.Transparent;
            this.buttonUpdate.Location = new System.Drawing.Point(472, 210);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 35);
            this.buttonUpdate.TabIndex = 5;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // radio_submitted
            // 
            this.radio_submitted.AutoSize = true;
            this.radio_submitted.Location = new System.Drawing.Point(6, 21);
            this.radio_submitted.Name = "radio_submitted";
            this.radio_submitted.Size = new System.Drawing.Size(92, 21);
            this.radio_submitted.TabIndex = 6;
            this.radio_submitted.TabStop = true;
            this.radio_submitted.Text = "Submitted";
            this.radio_submitted.UseVisualStyleBackColor = true;
            // 
            // radio_not
            // 
            this.radio_not.AutoSize = true;
            this.radio_not.Location = new System.Drawing.Point(6, 48);
            this.radio_not.Name = "radio_not";
            this.radio_not.Size = new System.Drawing.Size(118, 21);
            this.radio_not.TabIndex = 7;
            this.radio_not.TabStop = true;
            this.radio_not.Text = "Not Submitted";
            this.radio_not.UseVisualStyleBackColor = true;
            // 
            // groupStatus
            // 
            this.groupStatus.BackColor = System.Drawing.Color.Transparent;
            this.groupStatus.Controls.Add(this.radio_submitted);
            this.groupStatus.Controls.Add(this.radio_not);
            this.groupStatus.Location = new System.Drawing.Point(228, 246);
            this.groupStatus.Name = "groupStatus";
            this.groupStatus.Size = new System.Drawing.Size(164, 75);
            this.groupStatus.TabIndex = 8;
            this.groupStatus.TabStop = false;
            this.groupStatus.Text = "Status";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(472, 310);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 35);
            this.buttonClear.TabIndex = 9;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // NAME
            // 
            this.NAME.DataPropertyName = "NAME";
            this.NAME.HeaderText = "Name";
            this.NAME.MinimumWidth = 6;
            this.NAME.Name = "NAME";
            this.NAME.Width = 125;
            // 
            // CLASS
            // 
            this.CLASS.DataPropertyName = "CLASS";
            this.CLASS.HeaderText = "Class";
            this.CLASS.MinimumWidth = 6;
            this.CLASS.Name = "CLASS";
            this.CLASS.Width = 125;
            // 
            // ROLLNO
            // 
            this.ROLLNO.DataPropertyName = "ROLLNO";
            this.ROLLNO.HeaderText = "Roll no";
            this.ROLLNO.MinimumWidth = 6;
            this.ROLLNO.Name = "ROLLNO";
            this.ROLLNO.Width = 125;
            // 
            // ASSIGNMENT
            // 
            this.ASSIGNMENT.DataPropertyName = "ASSIGNMENT";
            this.ASSIGNMENT.HeaderText = "Assignment Status";
            this.ASSIGNMENT.MinimumWidth = 6;
            this.ASSIGNMENT.Name = "ASSIGNMENT";
            this.ASSIGNMENT.Width = 125;
            // 
            // PHONE
            // 
            this.PHONE.DataPropertyName = "PHONE";
            this.PHONE.HeaderText = "Phone ";
            this.PHONE.MinimumWidth = 6;
            this.PHONE.Name = "PHONE";
            this.PHONE.Width = 125;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(472, 107);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(75, 30);
            this.buttonLogout.TabIndex = 10;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // ControlWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CreateReadUpdateDelete_CRUD__System.Properties.Resources.InsideForm;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(582, 553);
            this.ControlBox = false;
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.groupStatus);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.PictureClose);
            this.Controls.Add(this.PictureMinimize);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.textRoll);
            this.Controls.Add(this.textClass);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.labelAssignment);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelRollno);
            this.Controls.Add(this.labelClass);
            this.Controls.Add(this.labelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ControlWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ControlWindow";
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureClose)).EndInit();
            this.groupStatus.ResumeLayout(false);
            this.groupStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelClass;
        private System.Windows.Forms.Label labelRollno;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelAssignment;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textClass;
        private System.Windows.Forms.TextBox textRoll;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox PictureMinimize;
        private System.Windows.Forms.PictureBox PictureClose;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.RadioButton radio_submitted;
        private System.Windows.Forms.RadioButton radio_not;
        private System.Windows.Forms.GroupBox groupStatus;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLASS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ROLLNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ASSIGNMENT;
        private System.Windows.Forms.DataGridViewTextBoxColumn PHONE;
        private System.Windows.Forms.Button buttonLogout;
    }
}