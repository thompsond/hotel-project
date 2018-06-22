namespace Hotel {
    partial class GuestDialog {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.roomNumberBox = new System.Windows.Forms.TextBox();
            this.roomNumberLabel = new System.Windows.Forms.Label();
            this.numOfNightsBox = new System.Windows.Forms.TextBox();
            this.numOfNightsLabel = new System.Windows.Forms.Label();
            this.reservationDateLabel = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.reservationDateBox = new System.Windows.Forms.DateTimePicker();
            this.infoLabel = new System.Windows.Forms.Label();
            this.editBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.Location = new System.Drawing.Point(13, 13);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(76, 17);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name";
            // 
            // firstNameBox
            // 
            this.firstNameBox.Location = new System.Drawing.Point(16, 35);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(191, 20);
            this.firstNameBox.TabIndex = 1;
            // 
            // lastNameBox
            // 
            this.lastNameBox.Location = new System.Drawing.Point(16, 88);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(191, 20);
            this.lastNameBox.TabIndex = 3;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.Location = new System.Drawing.Point(13, 66);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(76, 17);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Last Name";
            // 
            // roomNumberBox
            // 
            this.roomNumberBox.Location = new System.Drawing.Point(16, 141);
            this.roomNumberBox.Name = "roomNumberBox";
            this.roomNumberBox.Size = new System.Drawing.Size(191, 20);
            this.roomNumberBox.TabIndex = 5;
            // 
            // roomNumberLabel
            // 
            this.roomNumberLabel.AutoSize = true;
            this.roomNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomNumberLabel.Location = new System.Drawing.Point(13, 119);
            this.roomNumberLabel.Name = "roomNumberLabel";
            this.roomNumberLabel.Size = new System.Drawing.Size(99, 17);
            this.roomNumberLabel.TabIndex = 4;
            this.roomNumberLabel.Text = "Room Number";
            // 
            // numOfNightsBox
            // 
            this.numOfNightsBox.Location = new System.Drawing.Point(16, 194);
            this.numOfNightsBox.Name = "numOfNightsBox";
            this.numOfNightsBox.Size = new System.Drawing.Size(191, 20);
            this.numOfNightsBox.TabIndex = 7;
            // 
            // numOfNightsLabel
            // 
            this.numOfNightsLabel.AutoSize = true;
            this.numOfNightsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfNightsLabel.Location = new System.Drawing.Point(13, 172);
            this.numOfNightsLabel.Name = "numOfNightsLabel";
            this.numOfNightsLabel.Size = new System.Drawing.Size(118, 17);
            this.numOfNightsLabel.TabIndex = 6;
            this.numOfNightsLabel.Text = "Number of Nights";
            // 
            // reservationDateLabel
            // 
            this.reservationDateLabel.AutoSize = true;
            this.reservationDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationDateLabel.Location = new System.Drawing.Point(13, 225);
            this.reservationDateLabel.Name = "reservationDateLabel";
            this.reservationDateLabel.Size = new System.Drawing.Size(118, 17);
            this.reservationDateLabel.TabIndex = 8;
            this.reservationDateLabel.Text = "Reservation Date";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(351, 295);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 10;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(266, 295);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 11;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // reservationDateBox
            // 
            this.reservationDateBox.CustomFormat = "yyyy-MM-dd";
            this.reservationDateBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.reservationDateBox.Location = new System.Drawing.Point(16, 247);
            this.reservationDateBox.Name = "reservationDateBox";
            this.reservationDateBox.Size = new System.Drawing.Size(200, 20);
            this.reservationDateBox.TabIndex = 12;
            this.reservationDateBox.Value = new System.DateTime(2018, 2, 20, 21, 16, 5, 0);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(213, 38);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(0, 13);
            this.infoLabel.TabIndex = 13;
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(351, 295);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(75, 23);
            this.editBtn.TabIndex = 14;
            this.editBtn.Text = "Save";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Visible = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // GuestDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 330);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.reservationDateBox);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.reservationDateLabel);
            this.Controls.Add(this.numOfNightsBox);
            this.Controls.Add(this.numOfNightsLabel);
            this.Controls.Add(this.roomNumberBox);
            this.Controls.Add(this.roomNumberLabel);
            this.Controls.Add(this.lastNameBox);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameBox);
            this.Controls.Add(this.firstNameLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GuestDialog";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Guest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox roomNumberBox;
        private System.Windows.Forms.Label roomNumberLabel;
        private System.Windows.Forms.TextBox numOfNightsBox;
        private System.Windows.Forms.Label numOfNightsLabel;
        private System.Windows.Forms.Label reservationDateLabel;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.DateTimePicker reservationDateBox;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Button editBtn;
    }
}