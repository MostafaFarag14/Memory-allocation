namespace GUI
{
    partial class Form1
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
            this.process_size = new System.Windows.Forms.TextBox();
            this.allocate = new System.Windows.Forms.Button();
            this.Add_hole = new System.Windows.Forms.Button();
            this.hole_start = new System.Windows.Forms.TextBox();
            this.hole_size = new System.Windows.Forms.TextBox();
            this.Add_process = new System.Windows.Forms.Button();
            this.Free_Table = new System.Windows.Forms.DataGridView();
            this.Starting_Adress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Allocation_Table = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.number_of_processes = new System.Windows.Forms.TextBox();
            this.Allocation_method = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.deallocate_index = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PID = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Free_Table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Allocation_Table)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // process_size
            // 
            this.process_size.Location = new System.Drawing.Point(140, 126);
            this.process_size.Name = "process_size";
            this.process_size.Size = new System.Drawing.Size(81, 20);
            this.process_size.TabIndex = 2;
            this.process_size.TextChanged += new System.EventHandler(this.process_size_TextChanged);
            // 
            // allocate
            // 
            this.allocate.Location = new System.Drawing.Point(284, 71);
            this.allocate.Name = "allocate";
            this.allocate.Size = new System.Drawing.Size(75, 23);
            this.allocate.TabIndex = 7;
            this.allocate.Text = "allocate";
            this.allocate.UseVisualStyleBackColor = true;
            this.allocate.Click += new System.EventHandler(this.allocate_Click);
            // 
            // Add_hole
            // 
            this.Add_hole.Location = new System.Drawing.Point(74, 103);
            this.Add_hole.Name = "Add_hole";
            this.Add_hole.Size = new System.Drawing.Size(75, 23);
            this.Add_hole.TabIndex = 8;
            this.Add_hole.Text = "Add ";
            this.Add_hole.UseVisualStyleBackColor = true;
            this.Add_hole.Click += new System.EventHandler(this.Add_hole_Click);
            // 
            // hole_start
            // 
            this.hole_start.Location = new System.Drawing.Point(6, 59);
            this.hole_start.Name = "hole_start";
            this.hole_start.Size = new System.Drawing.Size(81, 20);
            this.hole_start.TabIndex = 11;
            this.hole_start.TextChanged += new System.EventHandler(this.hole_start_TextChanged);
            // 
            // hole_size
            // 
            this.hole_size.Location = new System.Drawing.Point(129, 59);
            this.hole_size.Name = "hole_size";
            this.hole_size.Size = new System.Drawing.Size(81, 20);
            this.hole_size.TabIndex = 10;
            this.hole_size.TextChanged += new System.EventHandler(this.hole_size_TextChanged);
            // 
            // Add_process
            // 
            this.Add_process.Location = new System.Drawing.Point(9, 123);
            this.Add_process.Name = "Add_process";
            this.Add_process.Size = new System.Drawing.Size(75, 23);
            this.Add_process.TabIndex = 12;
            this.Add_process.Text = "Add";
            this.Add_process.UseVisualStyleBackColor = true;
            this.Add_process.Click += new System.EventHandler(this.Add_process_Click);
            // 
            // Free_Table
            // 
            this.Free_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Free_Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Starting_Adress,
            this.Size});
            this.Free_Table.Location = new System.Drawing.Point(12, 203);
            this.Free_Table.Name = "Free_Table";
            this.Free_Table.Size = new System.Drawing.Size(256, 254);
            this.Free_Table.TabIndex = 13;
            this.Free_Table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Free_Table_CellContentClick);
            // 
            // Starting_Adress
            // 
            this.Starting_Adress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Starting_Adress.HeaderText = "Starting Adress";
            this.Starting_Adress.Name = "Starting_Adress";
            // 
            // Size
            // 
            this.Size.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Size.HeaderText = "Size";
            this.Size.Name = "Size";
            // 
            // Allocation_Table
            // 
            this.Allocation_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Allocation_Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.Allocation_Table.Location = new System.Drawing.Point(355, 203);
            this.Allocation_Table.Name = "Allocation_Table";
            this.Allocation_Table.Size = new System.Drawing.Size(299, 254);
            this.Allocation_Table.TabIndex = 14;
            this.Allocation_Table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Allocation_Table_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.hole_size);
            this.groupBox1.Controls.Add(this.hole_start);
            this.groupBox1.Controls.Add(this.Add_hole);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 170);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "holes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(126, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "hole size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Starting adress";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.PID);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.number_of_processes);
            this.groupBox2.Controls.Add(this.process_size);
            this.groupBox2.Controls.Add(this.Add_process);
            this.groupBox2.Location = new System.Drawing.Point(425, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(229, 170);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Processes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(137, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Process size";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Number of processes";
            // 
            // number_of_processes
            // 
            this.number_of_processes.Location = new System.Drawing.Point(6, 59);
            this.number_of_processes.Name = "number_of_processes";
            this.number_of_processes.Size = new System.Drawing.Size(78, 20);
            this.number_of_processes.TabIndex = 9;
            this.number_of_processes.TextChanged += new System.EventHandler(this.number_of_processes_TextChanged);
            // 
            // Allocation_method
            // 
            this.Allocation_method.FormattingEnabled = true;
            this.Allocation_method.Items.AddRange(new object[] {
            "First fit",
            "Best fit",
            "Worst fit"});
            this.Allocation_method.Location = new System.Drawing.Point(270, 31);
            this.Allocation_method.Name = "Allocation_method";
            this.Allocation_method.Size = new System.Drawing.Size(121, 21);
            this.Allocation_method.TabIndex = 17;
            this.Allocation_method.Text = "Allocation method";
            this.Allocation_method.SelectedIndexChanged += new System.EventHandler(this.Allocation_method_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(105, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Free Table";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(475, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "Allocation Table";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(284, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "deallocate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // deallocate_index
            // 
            this.deallocate_index.Location = new System.Drawing.Point(270, 135);
            this.deallocate_index.Name = "deallocate_index";
            this.deallocate_index.Size = new System.Drawing.Size(100, 20);
            this.deallocate_index.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(261, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "deallocated process index";
            // 
            // PID
            // 
            this.PID.Location = new System.Drawing.Point(138, 59);
            this.PID.Name = "PID";
            this.PID.Size = new System.Drawing.Size(83, 20);
            this.PID.TabIndex = 15;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.HeaderText = "PID";
            this.ID.Name = "ID";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Starting Adress";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Size";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(137, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "PID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 485);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.deallocate_index);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Allocation_method);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Allocation_Table);
            this.Controls.Add(this.Free_Table);
            this.Controls.Add(this.allocate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Free_Table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Allocation_Table)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox process_size;
        private System.Windows.Forms.Button allocate;
        private System.Windows.Forms.Button Add_hole;
        private System.Windows.Forms.TextBox hole_start;
        private System.Windows.Forms.TextBox hole_size;
        private System.Windows.Forms.Button Add_process;
        private System.Windows.Forms.DataGridView Free_Table;
        private System.Windows.Forms.DataGridView Allocation_Table;
        private System.Windows.Forms.DataGridViewTextBoxColumn Starting_Adress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox Allocation_method;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox number_of_processes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox deallocate_index;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox PID;

    }
}

