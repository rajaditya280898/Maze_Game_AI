namespace Maze_Game_AI
{
    partial class Frm_Main
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
            this.components = new System.ComponentModel.Container();
            this.gMaze1 = new System.Windows.Forms.GroupBox();
            this.txtMSY = new System.Windows.Forms.TextBox();
            this.txtMSX = new System.Windows.Forms.TextBox();
            this.btCreate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gMaze2 = new System.Windows.Forms.GroupBox();
            this.btSolve = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbstatus = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.gMaze1.SuspendLayout();
            this.gMaze2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gMaze1
            // 
            this.gMaze1.Controls.Add(this.txtMSY);
            this.gMaze1.Controls.Add(this.txtMSX);
            this.gMaze1.Controls.Add(this.btCreate);
            this.gMaze1.Controls.Add(this.label2);
            this.gMaze1.Controls.Add(this.label1);
            this.gMaze1.Location = new System.Drawing.Point(8, 57);
            this.gMaze1.Name = "gMaze1";
            this.gMaze1.Size = new System.Drawing.Size(362, 115);
            this.gMaze1.TabIndex = 8;
            this.gMaze1.TabStop = false;
            this.gMaze1.Text = "Maze Setting";
            // 
            // txtMSY
            // 
            this.txtMSY.Location = new System.Drawing.Point(146, 44);
            this.txtMSY.Name = "txtMSY";
            this.txtMSY.Size = new System.Drawing.Size(195, 20);
            this.txtMSY.TabIndex = 3;
            this.txtMSY.Text = "20";
            // 
            // txtMSX
            // 
            this.txtMSX.Location = new System.Drawing.Point(146, 20);
            this.txtMSX.Name = "txtMSX";
            this.txtMSX.Size = new System.Drawing.Size(195, 20);
            this.txtMSX.TabIndex = 2;
            this.txtMSX.Text = "20";
            // 
            // btCreate
            // 
            this.btCreate.Location = new System.Drawing.Point(233, 70);
            this.btCreate.Name = "btCreate";
            this.btCreate.Size = new System.Drawing.Size(108, 24);
            this.btCreate.TabIndex = 4;
            this.btCreate.Text = "Create Maze";
            this.btCreate.Click += new System.EventHandler(this.btCreate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(11, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "No. of Column - Maze Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(11, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "No. Of Rows - Maze X";
            // 
            // gMaze2
            // 
            this.gMaze2.Controls.Add(this.button4);
            this.gMaze2.Controls.Add(this.button2);
            this.gMaze2.Controls.Add(this.btSolve);
            this.gMaze2.Controls.Add(this.btSave);
            this.gMaze2.Location = new System.Drawing.Point(8, 178);
            this.gMaze2.Name = "gMaze2";
            this.gMaze2.Size = new System.Drawing.Size(362, 103);
            this.gMaze2.TabIndex = 10;
            this.gMaze2.TabStop = false;
            this.gMaze2.Text = "Maze Operation";
            // 
            // btSolve
            // 
            this.btSolve.Location = new System.Drawing.Point(14, 19);
            this.btSolve.Name = "btSolve";
            this.btSolve.Size = new System.Drawing.Size(77, 66);
            this.btSolve.TabIndex = 6;
            this.btSolve.Text = "Solve Maze";
            this.btSolve.Click += new System.EventHandler(this.btSolve_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(403, 652);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 66);
            this.button1.TabIndex = 11;
            this.button1.Text = "Re Generate Maze";
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(179, 19);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 66);
            this.btSave.TabIndex = 5;
            this.btSave.Text = "Save Maze";
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(367, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(360, 37);
            this.label3.TabIndex = 12;
            this.label3.Text = "Dynamic Maze Solving";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbstatus);
            this.groupBox1.Location = new System.Drawing.Point(8, 287);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 327);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Maze Status";
            // 
            // lbstatus
            // 
            this.lbstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbstatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbstatus.Location = new System.Drawing.Point(6, 19);
            this.lbstatus.Multiline = true;
            this.lbstatus.Name = "lbstatus";
            this.lbstatus.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.lbstatus.Size = new System.Drawing.Size(350, 302);
            this.lbstatus.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(376, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Source";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(916, 537);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Destination";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(89, 22);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(195, 20);
            this.textBox2.TabIndex = 16;
            this.textBox2.Text = "0";
            this.textBox2.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(89, -2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 20);
            this.textBox1.TabIndex = 15;
            this.textBox1.Text = "0";
            this.textBox1.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 20000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(263, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 66);
            this.button2.TabIndex = 17;
            this.button2.Text = "Solve Maze With Time Complexity ";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Location = new System.Drawing.Point(982, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 568);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Time Complexity ";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.textBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBox3.Location = new System.Drawing.Point(10, 23);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox3.Size = new System.Drawing.Size(239, 490);
            this.textBox3.TabIndex = 15;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(174, 528);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(97, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(74, 66);
            this.button4.TabIndex = 18;
            this.button4.Text = "Stop Maze";
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 637);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gMaze1);
            this.Controls.Add(this.gMaze2);
            this.MaximizeBox = false;
            this.Name = "Frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dynamic Maze Solving";
            this.Load += new System.EventHandler(this.Frm_Main_Load);
            this.gMaze1.ResumeLayout(false);
            this.gMaze1.PerformLayout();
            this.gMaze2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private myPictureBox picMaze;
        private System.Windows.Forms.GroupBox gMaze1;
        private System.Windows.Forms.TextBox txtMSY;
        private System.Windows.Forms.TextBox txtMSX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gMaze2;
        private System.Windows.Forms.Button btSolve;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btCreate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox lbstatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;

    }
}

