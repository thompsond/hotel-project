namespace Hotel {
    partial class Form1 {
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
            this.roomTable = new System.Windows.Forms.DataGridView();
            this.roomTableLabel = new System.Windows.Forms.Label();
            this.guestTableLabel = new System.Windows.Forms.Label();
            this.guestTable = new System.Windows.Forms.DataGridView();
            this.addGuestBtn = new System.Windows.Forms.Button();
            this.editGuestBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.roomTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestTable)).BeginInit();
            this.SuspendLayout();
            // 
            // roomTable
            // 
            this.roomTable.AllowUserToAddRows = false;
            this.roomTable.AllowUserToDeleteRows = false;
            this.roomTable.AllowUserToResizeColumns = false;
            this.roomTable.AllowUserToResizeRows = false;
            this.roomTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomTable.Location = new System.Drawing.Point(12, 61);
            this.roomTable.Name = "roomTable";
            this.roomTable.ReadOnly = true;
            this.roomTable.Size = new System.Drawing.Size(560, 150);
            this.roomTable.TabIndex = 0;
            // 
            // roomTableLabel
            // 
            this.roomTableLabel.AutoSize = true;
            this.roomTableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomTableLabel.Location = new System.Drawing.Point(13, 28);
            this.roomTableLabel.Name = "roomTableLabel";
            this.roomTableLabel.Size = new System.Drawing.Size(95, 20);
            this.roomTableLabel.TabIndex = 1;
            this.roomTableLabel.Text = "Room Table";
            // 
            // guestTableLabel
            // 
            this.guestTableLabel.AutoSize = true;
            this.guestTableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestTableLabel.Location = new System.Drawing.Point(13, 257);
            this.guestTableLabel.Name = "guestTableLabel";
            this.guestTableLabel.Size = new System.Drawing.Size(96, 20);
            this.guestTableLabel.TabIndex = 3;
            this.guestTableLabel.Text = "Guest Table";
            // 
            // guestTable
            // 
            this.guestTable.AllowUserToAddRows = false;
            this.guestTable.AllowUserToDeleteRows = false;
            this.guestTable.AllowUserToResizeColumns = false;
            this.guestTable.AllowUserToResizeRows = false;
            this.guestTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.guestTable.Location = new System.Drawing.Point(12, 290);
            this.guestTable.MultiSelect = false;
            this.guestTable.Name = "guestTable";
            this.guestTable.ReadOnly = true;
            this.guestTable.Size = new System.Drawing.Size(643, 150);
            this.guestTable.TabIndex = 2;
            this.guestTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guestTable_CellContentClick);
            // 
            // addGuestBtn
            // 
            this.addGuestBtn.Location = new System.Drawing.Point(122, 255);
            this.addGuestBtn.Name = "addGuestBtn";
            this.addGuestBtn.Size = new System.Drawing.Size(75, 23);
            this.addGuestBtn.TabIndex = 4;
            this.addGuestBtn.Text = "Add Guest";
            this.addGuestBtn.UseVisualStyleBackColor = true;
            this.addGuestBtn.Click += new System.EventHandler(this.addGuestBtn_Click);
            // 
            // editGuestBtn
            // 
            this.editGuestBtn.Location = new System.Drawing.Point(210, 255);
            this.editGuestBtn.Name = "editGuestBtn";
            this.editGuestBtn.Size = new System.Drawing.Size(75, 23);
            this.editGuestBtn.TabIndex = 5;
            this.editGuestBtn.Text = "Edit Guest";
            this.editGuestBtn.UseVisualStyleBackColor = true;
            this.editGuestBtn.Click += new System.EventHandler(this.editGuestBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 481);
            this.Controls.Add(this.editGuestBtn);
            this.Controls.Add(this.addGuestBtn);
            this.Controls.Add(this.guestTableLabel);
            this.Controls.Add(this.guestTable);
            this.Controls.Add(this.roomTableLabel);
            this.Controls.Add(this.roomTable);
            this.Name = "Form1";
            this.Text = "Hotel";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roomTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView roomTable;
        private System.Windows.Forms.Label roomTableLabel;
        private System.Windows.Forms.Label guestTableLabel;
        private System.Windows.Forms.DataGridView guestTable;
        private System.Windows.Forms.Button addGuestBtn;
        private System.Windows.Forms.Button editGuestBtn;
    }
}

