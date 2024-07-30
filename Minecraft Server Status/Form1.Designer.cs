namespace Minecraft_Server_Status
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.get_status = new System.Windows.Forms.Button();
            this.ip_box = new System.Windows.Forms.RichTextBox();
            this.port_box = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.status = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pl_o = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // get_status
            // 
            this.get_status.BackColor = System.Drawing.Color.DarkGreen;
            this.get_status.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.get_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.get_status.ForeColor = System.Drawing.Color.Snow;
            this.get_status.Location = new System.Drawing.Point(593, 48);
            this.get_status.Name = "get_status";
            this.get_status.Size = new System.Drawing.Size(151, 67);
            this.get_status.TabIndex = 0;
            this.get_status.Text = "Get Status";
            this.get_status.UseVisualStyleBackColor = false;
            this.get_status.Click += new System.EventHandler(this.get_status_Click);
            // 
            // ip_box
            // 
            this.ip_box.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ip_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ip_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ip_box.ForeColor = System.Drawing.Color.White;
            this.ip_box.Location = new System.Drawing.Point(11, 47);
            this.ip_box.Multiline = false;
            this.ip_box.Name = "ip_box";
            this.ip_box.Size = new System.Drawing.Size(363, 68);
            this.ip_box.TabIndex = 1;
            this.ip_box.Text = "";
            // 
            // port_box
            // 
            this.port_box.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.port_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.port_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.port_box.ForeColor = System.Drawing.Color.White;
            this.port_box.Location = new System.Drawing.Point(400, 48);
            this.port_box.Multiline = false;
            this.port_box.Name = "port_box";
            this.port_box.Size = new System.Drawing.Size(166, 67);
            this.port_box.TabIndex = 2;
            this.port_box.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(170, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(415, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 42);
            this.label2.TabIndex = 4;
            this.label2.Text = "PORT:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(5, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 42);
            this.label3.TabIndex = 5;
            this.label3.Text = "Status:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.port_box);
            this.groupBox1.Controls.Add(this.ip_box);
            this.groupBox1.Controls.Add(this.get_status);
            this.groupBox1.Location = new System.Drawing.Point(1, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(755, 142);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.ForeColor = System.Drawing.Color.Snow;
            this.status.Location = new System.Drawing.Point(12, 316);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(287, 42);
            this.status.TabIndex = 7;
            this.status.Text = "Waiting for Input";
            this.status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(474, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(271, 42);
            this.label4.TabIndex = 8;
            this.label4.Text = "Players Online:";
            // 
            // pl_o
            // 
            this.pl_o.AutoSize = true;
            this.pl_o.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pl_o.ForeColor = System.Drawing.Color.Snow;
            this.pl_o.Location = new System.Drawing.Point(555, 316);
            this.pl_o.Name = "pl_o";
            this.pl_o.Size = new System.Drawing.Size(70, 42);
            this.pl_o.TabIndex = 9;
            this.pl_o.Text = "n/a";
            this.pl_o.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.DimGray;
            this.menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.ForeColor = System.Drawing.Color.White;
            this.menu.Location = new System.Drawing.Point(716, 414);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(40, 53);
            this.menu.TabIndex = 10;
            this.menu.Text = "⋮";
            this.menu.UseVisualStyleBackColor = false;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(757, 468);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.pl_o);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.status);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Server Status";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button get_status;
        private System.Windows.Forms.RichTextBox ip_box;
        private System.Windows.Forms.RichTextBox port_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label pl_o;
        private System.Windows.Forms.Button menu;
    }
}

