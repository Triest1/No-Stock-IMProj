namespace POSInventoryCreditSystem
{
    partial class AdminAddUsers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.addUsers_username = new System.Windows.Forms.TextBox();
            this.addUsers_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addUsers_role = new System.Windows.Forms.ComboBox();
            this.addUsers_status = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addUsers_addBtn = new System.Windows.Forms.Button();
            this.addUsers_updateBtn = new System.Windows.Forms.Button();
            this.addUsers_clearBtn = new System.Windows.Forms.Button();
            this.addUsers_removeBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.addUsers_clearBtn);
            this.panel1.Controls.Add(this.addUsers_removeBtn);
            this.panel1.Controls.Add(this.addUsers_updateBtn);
            this.panel1.Controls.Add(this.addUsers_addBtn);
            this.panel1.Controls.Add(this.addUsers_status);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.addUsers_role);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.addUsers_password);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.addUsers_username);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(21, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 707);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(385, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(703, 707);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // addUsers_username
            // 
            this.addUsers_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUsers_username.Location = new System.Drawing.Point(21, 92);
            this.addUsers_username.Name = "addUsers_username";
            this.addUsers_username.Size = new System.Drawing.Size(302, 29);
            this.addUsers_username.TabIndex = 1;
            // 
            // addUsers_password
            // 
            this.addUsers_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUsers_password.Location = new System.Drawing.Point(21, 161);
            this.addUsers_password.Name = "addUsers_password";
            this.addUsers_password.Size = new System.Drawing.Size(302, 29);
            this.addUsers_password.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Role";
            // 
            // addUsers_role
            // 
            this.addUsers_role.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUsers_role.FormattingEnabled = true;
            this.addUsers_role.Items.AddRange(new object[] {
            "Admin",
            "Cashier"});
            this.addUsers_role.Location = new System.Drawing.Point(21, 228);
            this.addUsers_role.Name = "addUsers_role";
            this.addUsers_role.Size = new System.Drawing.Size(302, 32);
            this.addUsers_role.TabIndex = 5;
            // 
            // addUsers_status
            // 
            this.addUsers_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUsers_status.FormattingEnabled = true;
            this.addUsers_status.Items.AddRange(new object[] {
            "Active",
            "Inactive",
            "Approval"});
            this.addUsers_status.Location = new System.Drawing.Point(21, 300);
            this.addUsers_status.Name = "addUsers_status";
            this.addUsers_status.Size = new System.Drawing.Size(302, 32);
            this.addUsers_status.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Status";
            // 
            // addUsers_addBtn
            // 
            this.addUsers_addBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.addUsers_addBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUsers_addBtn.ForeColor = System.Drawing.Color.White;
            this.addUsers_addBtn.Location = new System.Drawing.Point(21, 362);
            this.addUsers_addBtn.Name = "addUsers_addBtn";
            this.addUsers_addBtn.Size = new System.Drawing.Size(123, 46);
            this.addUsers_addBtn.TabIndex = 8;
            this.addUsers_addBtn.Text = "Add";
            this.addUsers_addBtn.UseVisualStyleBackColor = false;
            this.addUsers_addBtn.Click += new System.EventHandler(this.addUsers_addBtn_Click);
            // 
            // addUsers_updateBtn
            // 
            this.addUsers_updateBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.addUsers_updateBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUsers_updateBtn.ForeColor = System.Drawing.Color.White;
            this.addUsers_updateBtn.Location = new System.Drawing.Point(200, 362);
            this.addUsers_updateBtn.Name = "addUsers_updateBtn";
            this.addUsers_updateBtn.Size = new System.Drawing.Size(123, 46);
            this.addUsers_updateBtn.TabIndex = 9;
            this.addUsers_updateBtn.Text = "Update";
            this.addUsers_updateBtn.UseVisualStyleBackColor = false;
            // 
            // addUsers_clearBtn
            // 
            this.addUsers_clearBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.addUsers_clearBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUsers_clearBtn.ForeColor = System.Drawing.Color.White;
            this.addUsers_clearBtn.Location = new System.Drawing.Point(200, 434);
            this.addUsers_clearBtn.Name = "addUsers_clearBtn";
            this.addUsers_clearBtn.Size = new System.Drawing.Size(123, 46);
            this.addUsers_clearBtn.TabIndex = 11;
            this.addUsers_clearBtn.Text = "Clear";
            this.addUsers_clearBtn.UseVisualStyleBackColor = false;
            // 
            // addUsers_removeBtn
            // 
            this.addUsers_removeBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.addUsers_removeBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUsers_removeBtn.ForeColor = System.Drawing.Color.White;
            this.addUsers_removeBtn.Location = new System.Drawing.Point(21, 434);
            this.addUsers_removeBtn.Name = "addUsers_removeBtn";
            this.addUsers_removeBtn.Size = new System.Drawing.Size(123, 46);
            this.addUsers_removeBtn.TabIndex = 10;
            this.addUsers_removeBtn.Text = "Remove";
            this.addUsers_removeBtn.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "All User\'s Data";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(668, 617);
            this.dataGridView1.TabIndex = 13;
            // 
            // AdminAddUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 756);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminAddUsers";
            this.Text = "AdminAddUsers";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox addUsers_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addUsers_username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox addUsers_role;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addUsers_addBtn;
        private System.Windows.Forms.ComboBox addUsers_status;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addUsers_clearBtn;
        private System.Windows.Forms.Button addUsers_removeBtn;
        private System.Windows.Forms.Button addUsers_updateBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
    }
}