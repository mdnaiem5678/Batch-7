namespace Coffee_Shop
{
    partial class Home
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
            this.showtxtbx = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.custtxtbx = new System.Windows.Forms.TextBox();
            this.contactlvl = new System.Windows.Forms.Label();
            this.Headlvl = new System.Windows.Forms.Label();
            this.conttxtbx = new System.Windows.Forms.TextBox();
            this.addtxtbx = new System.Windows.Forms.TextBox();
            this.quntxtbx = new System.Windows.Forms.TextBox();
            this.ordercobox = new System.Windows.Forms.ComboBox();
            this.orderlvl = new System.Windows.Forms.Label();
            this.savebtn = new System.Windows.Forms.Button();
            this.namelvl = new System.Windows.Forms.Label();
            this.addlvl = new System.Windows.Forms.Label();
            this.qusntitylvl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // showtxtbx
            // 
            this.showtxtbx.Location = new System.Drawing.Point(507, 44);
            this.showtxtbx.Name = "showtxtbx";
            this.showtxtbx.Size = new System.Drawing.Size(233, 403);
            this.showtxtbx.TabIndex = 15;
            this.showtxtbx.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.custtxtbx);
            this.panel1.Controls.Add(this.contactlvl);
            this.panel1.Controls.Add(this.Headlvl);
            this.panel1.Controls.Add(this.conttxtbx);
            this.panel1.Controls.Add(this.addtxtbx);
            this.panel1.Controls.Add(this.quntxtbx);
            this.panel1.Controls.Add(this.ordercobox);
            this.panel1.Controls.Add(this.orderlvl);
            this.panel1.Controls.Add(this.savebtn);
            this.panel1.Controls.Add(this.namelvl);
            this.panel1.Controls.Add(this.addlvl);
            this.panel1.Controls.Add(this.qusntitylvl);
            this.panel1.Location = new System.Drawing.Point(29, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 403);
            this.panel1.TabIndex = 14;
            // 
            // custtxtbx
            // 
            this.custtxtbx.Location = new System.Drawing.Point(235, 61);
            this.custtxtbx.Name = "custtxtbx";
            this.custtxtbx.Size = new System.Drawing.Size(157, 22);
            this.custtxtbx.TabIndex = 5;
            // 
            // contactlvl
            // 
            this.contactlvl.AutoSize = true;
            this.contactlvl.Location = new System.Drawing.Point(42, 104);
            this.contactlvl.Name = "contactlvl";
            this.contactlvl.Size = new System.Drawing.Size(82, 17);
            this.contactlvl.TabIndex = 2;
            this.contactlvl.Text = "Contact No ";
            // 
            // Headlvl
            // 
            this.Headlvl.AutoSize = true;
            this.Headlvl.Location = new System.Drawing.Point(17, 0);
            this.Headlvl.Name = "Headlvl";
            this.Headlvl.Size = new System.Drawing.Size(142, 17);
            this.Headlvl.TabIndex = 0;
            this.Headlvl.Text = "Customer information";
            // 
            // conttxtbx
            // 
            this.conttxtbx.Location = new System.Drawing.Point(235, 104);
            this.conttxtbx.Name = "conttxtbx";
            this.conttxtbx.Size = new System.Drawing.Size(157, 22);
            this.conttxtbx.TabIndex = 6;
            // 
            // addtxtbx
            // 
            this.addtxtbx.Location = new System.Drawing.Point(235, 152);
            this.addtxtbx.Name = "addtxtbx";
            this.addtxtbx.Size = new System.Drawing.Size(157, 22);
            this.addtxtbx.TabIndex = 7;
            // 
            // quntxtbx
            // 
            this.quntxtbx.Location = new System.Drawing.Point(235, 296);
            this.quntxtbx.Name = "quntxtbx";
            this.quntxtbx.Size = new System.Drawing.Size(157, 22);
            this.quntxtbx.TabIndex = 8;
            // 
            // ordercobox
            // 
            this.ordercobox.FormattingEnabled = true;
            this.ordercobox.Items.AddRange(new object[] {
            "Black-120",
            "Cold-100",
            "Hot-90",
            "Reguler-80"});
            this.ordercobox.Location = new System.Drawing.Point(235, 255);
            this.ordercobox.Name = "ordercobox";
            this.ordercobox.Size = new System.Drawing.Size(157, 24);
            this.ordercobox.TabIndex = 10;
            this.ordercobox.Text = "Select Item";
            // 
            // orderlvl
            // 
            this.orderlvl.AutoSize = true;
            this.orderlvl.Location = new System.Drawing.Point(42, 255);
            this.orderlvl.Name = "orderlvl";
            this.orderlvl.Size = new System.Drawing.Size(49, 17);
            this.orderlvl.TabIndex = 11;
            this.orderlvl.Text = "Order ";
            // 
            // savebtn
            // 
            this.savebtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.savebtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.savebtn.Location = new System.Drawing.Point(277, 354);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(75, 23);
            this.savebtn.TabIndex = 9;
            this.savebtn.Text = "Save";
            this.savebtn.UseVisualStyleBackColor = false;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // namelvl
            // 
            this.namelvl.AutoSize = true;
            this.namelvl.Location = new System.Drawing.Point(42, 61);
            this.namelvl.Name = "namelvl";
            this.namelvl.Size = new System.Drawing.Size(113, 17);
            this.namelvl.TabIndex = 1;
            this.namelvl.Text = "Customar Name ";
            // 
            // addlvl
            // 
            this.addlvl.AutoSize = true;
            this.addlvl.Location = new System.Drawing.Point(42, 152);
            this.addlvl.Name = "addlvl";
            this.addlvl.Size = new System.Drawing.Size(64, 17);
            this.addlvl.TabIndex = 3;
            this.addlvl.Text = "Address ";
            // 
            // qusntitylvl
            // 
            this.qusntitylvl.AutoSize = true;
            this.qusntitylvl.Location = new System.Drawing.Point(42, 296);
            this.qusntitylvl.Name = "qusntitylvl";
            this.qusntitylvl.Size = new System.Drawing.Size(65, 17);
            this.qusntitylvl.TabIndex = 4;
            this.qusntitylvl.Text = "Quantity ";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 501);
            this.Controls.Add(this.showtxtbx);
            this.Controls.Add(this.panel1);
            this.Name = "Home";
            this.Text = "Coffee Shop UI";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox showtxtbx;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox custtxtbx;
        private System.Windows.Forms.Label contactlvl;
        private System.Windows.Forms.Label Headlvl;
        private System.Windows.Forms.TextBox conttxtbx;
        private System.Windows.Forms.TextBox addtxtbx;
        private System.Windows.Forms.TextBox quntxtbx;
        private System.Windows.Forms.ComboBox ordercobox;
        private System.Windows.Forms.Label orderlvl;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Label namelvl;
        private System.Windows.Forms.Label addlvl;
        private System.Windows.Forms.Label qusntitylvl;
    }
}

