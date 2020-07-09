namespace Controller
{
    partial class MainViewStaff
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.quantitytext = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.Citems = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.placeorde = new System.Windows.Forms.Button();
            this.iddrugtext = new System.Windows.Forms.TextBox();
            this.drugname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.drugs = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 193);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Placed Orders:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(283, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Id:";
            // 
            // quantitytext
            // 
            this.quantitytext.Location = new System.Drawing.Point(349, 243);
            this.quantitytext.Name = "quantitytext";
            this.quantitytext.Size = new System.Drawing.Size(100, 20);
            this.quantitytext.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(273, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quantity:";
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(464, 283);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 6;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // Citems
            // 
            this.Citems.HideSelection = false;
            this.Citems.Location = new System.Drawing.Point(564, 88);
            this.Citems.Name = "Citems";
            this.Citems.Size = new System.Drawing.Size(168, 152);
            this.Citems.TabIndex = 7;
            this.Citems.UseCompatibleStateImageBehavior = false;
            this.Citems.SelectedIndexChanged += new System.EventHandler(this.Citems_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(560, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Order details:";
            // 
            // placeorde
            // 
            this.placeorde.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeorde.Location = new System.Drawing.Point(658, 275);
            this.placeorde.Name = "placeorde";
            this.placeorde.Size = new System.Drawing.Size(119, 29);
            this.placeorde.TabIndex = 9;
            this.placeorde.Text = "Place Order";
            this.placeorde.UseVisualStyleBackColor = true;
            this.placeorde.Click += new System.EventHandler(this.placeorde_Click);
            // 
            // iddrugtext
            // 
            this.iddrugtext.Location = new System.Drawing.Point(349, 285);
            this.iddrugtext.Name = "iddrugtext";
            this.iddrugtext.Size = new System.Drawing.Size(100, 20);
            this.iddrugtext.TabIndex = 10;
            // 
            // drugname
            // 
            this.drugname.Location = new System.Drawing.Point(349, 47);
            this.drugname.Name = "drugname";
            this.drugname.Size = new System.Drawing.Size(100, 20);
            this.drugname.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(294, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Name:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(474, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // drugs
            // 
            this.drugs.HideSelection = false;
            this.drugs.Location = new System.Drawing.Point(349, 82);
            this.drugs.Name = "drugs";
            this.drugs.Size = new System.Drawing.Size(121, 97);
            this.drugs.TabIndex = 14;
            this.drugs.UseCompatibleStateImageBehavior = false;
            this.drugs.SelectedIndexChanged += new System.EventHandler(this.drugs_SelectedIndexChanged);
            // 
            // MainViewStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 316);
            this.Controls.Add(this.drugs);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.drugname);
            this.Controls.Add(this.iddrugtext);
            this.Controls.Add(this.placeorde);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Citems);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.quantitytext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainViewStaff";
            this.Text = "MainViewStaff";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainViewStaff_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox quantitytext;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.ListView Citems;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button placeorde;
        private System.Windows.Forms.TextBox iddrugtext;
        private System.Windows.Forms.TextBox drugname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView drugs;
    }
}