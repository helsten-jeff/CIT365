namespace MegaDesk_Helsten
{
    partial class AddQuote
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
            this.customerName = new System.Windows.Forms.TextBox();
            this.submitQuote = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.customerNameError = new System.Windows.Forms.Label();
            this.widthError = new System.Windows.Forms.Label();
            this.depthError = new System.Windows.Forms.Label();
            this.drawerCountError = new System.Windows.Forms.Label();
            this.materialError = new System.Windows.Forms.Label();
            this.rushOrderError = new System.Windows.Forms.Label();
            this.deskWidth = new System.Windows.Forms.NumericUpDown();
            this.deskDepth = new System.Windows.Forms.NumericUpDown();
            this.drawerCount = new System.Windows.Forms.NumericUpDown();
            this.rushOrder = new System.Windows.Forms.NumericUpDown();
            this.material = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.deskWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deskDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawerCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rushOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // customerName
            // 
            this.customerName.Location = new System.Drawing.Point(116, 21);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(168, 20);
            this.customerName.TabIndex = 0;
            // 
            // submitQuote
            // 
            this.submitQuote.Location = new System.Drawing.Point(12, 392);
            this.submitQuote.Name = "submitQuote";
            this.submitQuote.Size = new System.Drawing.Size(197, 39);
            this.submitQuote.TabIndex = 6;
            this.submitQuote.Text = "Add Quote";
            this.submitQuote.UseVisualStyleBackColor = true;
            this.submitQuote.Click += new System.EventHandler(this.SubmitQuote_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Desk Width";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Desk Depth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Number of Drawers";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Material";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Rush Order? (Days)";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // customerNameError
            // 
            this.customerNameError.AutoSize = true;
            this.customerNameError.BackColor = System.Drawing.SystemColors.Control;
            this.customerNameError.ForeColor = System.Drawing.SystemColors.Control;
            this.customerNameError.Location = new System.Drawing.Point(298, 24);
            this.customerNameError.Name = "customerNameError";
            this.customerNameError.Size = new System.Drawing.Size(0, 13);
            this.customerNameError.TabIndex = 13;
            // 
            // widthError
            // 
            this.widthError.AutoSize = true;
            this.widthError.BackColor = System.Drawing.SystemColors.Control;
            this.widthError.ForeColor = System.Drawing.SystemColors.ControlText;
            this.widthError.Location = new System.Drawing.Point(222, 67);
            this.widthError.Name = "widthError";
            this.widthError.Size = new System.Drawing.Size(62, 13);
            this.widthError.TabIndex = 14;
            this.widthError.Text = "( 24\" - 96\" )";
            this.widthError.Click += new System.EventHandler(this.Label8_Click);
            // 
            // depthError
            // 
            this.depthError.AutoSize = true;
            this.depthError.Location = new System.Drawing.Point(222, 110);
            this.depthError.Name = "depthError";
            this.depthError.Size = new System.Drawing.Size(62, 13);
            this.depthError.TabIndex = 15;
            this.depthError.Text = "( 12\" - 48\" )";
            // 
            // drawerCountError
            // 
            this.drawerCountError.AutoSize = true;
            this.drawerCountError.Location = new System.Drawing.Point(222, 156);
            this.drawerCountError.Name = "drawerCountError";
            this.drawerCountError.Size = new System.Drawing.Size(34, 13);
            this.drawerCountError.TabIndex = 16;
            this.drawerCountError.Text = "( 0-7 )";
            // 
            // materialError
            // 
            this.materialError.AutoSize = true;
            this.materialError.ForeColor = System.Drawing.SystemColors.ControlText;
            this.materialError.Location = new System.Drawing.Point(222, 204);
            this.materialError.Name = "materialError";
            this.materialError.Size = new System.Drawing.Size(209, 13);
            this.materialError.TabIndex = 17;
            this.materialError.Text = "( Laminate Oak, Rosewood, Veneer, Pine )";
            // 
            // rushOrderError
            // 
            this.rushOrderError.AutoSize = true;
            this.rushOrderError.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rushOrderError.Location = new System.Drawing.Point(222, 247);
            this.rushOrderError.Name = "rushOrderError";
            this.rushOrderError.Size = new System.Drawing.Size(104, 13);
            this.rushOrderError.TabIndex = 18;
            this.rushOrderError.Text = "( 3, 5, 7, or 14 days )";
            // 
            // deskWidth
            // 
            this.deskWidth.Location = new System.Drawing.Point(116, 65);
            this.deskWidth.Name = "deskWidth";
            this.deskWidth.Size = new System.Drawing.Size(100, 20);
            this.deskWidth.TabIndex = 19;
            this.deskWidth.ValueChanged += new System.EventHandler(this.NumericUpDown1_ValueChanged);
            // 
            // deskDepth
            // 
            this.deskDepth.Location = new System.Drawing.Point(116, 108);
            this.deskDepth.Name = "deskDepth";
            this.deskDepth.Size = new System.Drawing.Size(100, 20);
            this.deskDepth.TabIndex = 20;
            this.deskDepth.ValueChanged += new System.EventHandler(this.DeskDepth_ValueChanged);
            // 
            // drawerCount
            // 
            this.drawerCount.Location = new System.Drawing.Point(116, 154);
            this.drawerCount.Name = "drawerCount";
            this.drawerCount.Size = new System.Drawing.Size(100, 20);
            this.drawerCount.TabIndex = 22;
            // 
            // rushOrder
            // 
            this.rushOrder.Location = new System.Drawing.Point(116, 245);
            this.rushOrder.Name = "rushOrder";
            this.rushOrder.Size = new System.Drawing.Size(100, 20);
            this.rushOrder.TabIndex = 23;
            this.rushOrder.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            // 
            // material
            // 
            this.material.Location = new System.Drawing.Point(116, 201);
            this.material.Name = "material";
            this.material.Size = new System.Drawing.Size(100, 20);
            this.material.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(551, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 443);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.material);
            this.Controls.Add(this.rushOrder);
            this.Controls.Add(this.drawerCount);
            this.Controls.Add(this.deskDepth);
            this.Controls.Add(this.deskWidth);
            this.Controls.Add(this.rushOrderError);
            this.Controls.Add(this.materialError);
            this.Controls.Add(this.drawerCountError);
            this.Controls.Add(this.depthError);
            this.Controls.Add(this.widthError);
            this.Controls.Add(this.customerNameError);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submitQuote);
            this.Controls.Add(this.customerName);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            this.Load += new System.EventHandler(this.AddQuote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deskWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deskDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawerCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rushOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox customerName;
        private System.Windows.Forms.Button submitQuote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label customerNameError;
        private System.Windows.Forms.Label widthError;
        private System.Windows.Forms.Label depthError;
        private System.Windows.Forms.Label drawerCountError;
        private System.Windows.Forms.Label materialError;
        private System.Windows.Forms.Label rushOrderError;
        private System.Windows.Forms.NumericUpDown deskWidth;
        private System.Windows.Forms.NumericUpDown deskDepth;
        private System.Windows.Forms.NumericUpDown drawerCount;
        private System.Windows.Forms.NumericUpDown rushOrder;
        private System.Windows.Forms.TextBox material;
        private System.Windows.Forms.Button button1;
    }
}