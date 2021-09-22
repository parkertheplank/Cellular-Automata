
namespace CellularAutomata
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pause1 = new System.Windows.Forms.Button();
            this.reset1 = new System.Windows.Forms.Button();
            this.fillBox1 = new System.Windows.Forms.TextBox();
            this.menu1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.template7 = new System.Windows.Forms.Label();
            this.template6 = new System.Windows.Forms.Label();
            this.template5 = new System.Windows.Forms.Label();
            this.template4 = new System.Windows.Forms.Label();
            this.template3 = new System.Windows.Forms.Label();
            this.template2 = new System.Windows.Forms.Label();
            this.template1 = new System.Windows.Forms.Label();
            this.clockspeed1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.wraplabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clockspeed1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_tick);
            // 
            // pause1
            // 
            this.pause1.BackColor = System.Drawing.Color.White;
            this.pause1.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pause1.ForeColor = System.Drawing.Color.Purple;
            this.pause1.Location = new System.Drawing.Point(120, 13);
            this.pause1.Name = "pause1";
            this.pause1.Size = new System.Drawing.Size(75, 23);
            this.pause1.TabIndex = 0;
            this.pause1.Text = "Play";
            this.pause1.UseVisualStyleBackColor = false;
            this.pause1.Click += new System.EventHandler(this.pause1_Click);
            // 
            // reset1
            // 
            this.reset1.BackColor = System.Drawing.Color.White;
            this.reset1.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset1.ForeColor = System.Drawing.Color.Purple;
            this.reset1.Location = new System.Drawing.Point(201, 13);
            this.reset1.Name = "reset1";
            this.reset1.Size = new System.Drawing.Size(75, 23);
            this.reset1.TabIndex = 1;
            this.reset1.Text = "Reset";
            this.reset1.UseVisualStyleBackColor = false;
            this.reset1.Click += new System.EventHandler(this.reset1_Click);
            // 
            // fillBox1
            // 
            this.fillBox1.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fillBox1.ForeColor = System.Drawing.Color.Blue;
            this.fillBox1.Location = new System.Drawing.Point(282, 14);
            this.fillBox1.Name = "fillBox1";
            this.fillBox1.Size = new System.Drawing.Size(56, 22);
            this.fillBox1.TabIndex = 2;
            this.fillBox1.Text = "Fill..";
            this.fillBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fillBox1.Leave += new System.EventHandler(this.fillBox1_Leave);
            // 
            // menu1
            // 
            this.menu1.BackColor = System.Drawing.Color.White;
            this.menu1.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu1.ForeColor = System.Drawing.Color.Purple;
            this.menu1.Location = new System.Drawing.Point(12, 14);
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(102, 23);
            this.menu1.TabIndex = 4;
            this.menu1.Text = "Menu";
            this.menu1.UseVisualStyleBackColor = false;
            this.menu1.Click += new System.EventHandler(this.menu1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.template7);
            this.panel1.Controls.Add(this.template6);
            this.panel1.Controls.Add(this.template5);
            this.panel1.Controls.Add(this.template4);
            this.panel1.Controls.Add(this.template3);
            this.panel1.Controls.Add(this.template2);
            this.panel1.Controls.Add(this.template1);
            this.panel1.Location = new System.Drawing.Point(12, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(101, 195);
            this.panel1.TabIndex = 5;
            this.panel1.Visible = false;
            // 
            // template7
            // 
            this.template7.AutoSize = true;
            this.template7.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.template7.ForeColor = System.Drawing.Color.Blue;
            this.template7.Location = new System.Drawing.Point(5, 160);
            this.template7.Name = "template7";
            this.template7.Size = new System.Drawing.Size(38, 17);
            this.template7.TabIndex = 6;
            this.template7.Text = "Misc";
            this.template7.Click += new System.EventHandler(this.template7_Click);
            // 
            // template6
            // 
            this.template6.AutoSize = true;
            this.template6.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.template6.ForeColor = System.Drawing.Color.Blue;
            this.template6.Location = new System.Drawing.Point(5, 133);
            this.template6.Name = "template6";
            this.template6.Size = new System.Drawing.Size(52, 17);
            this.template6.TabIndex = 5;
            this.template6.Text = "Stripes";
            this.template6.Click += new System.EventHandler(this.template6_Click);
            // 
            // template5
            // 
            this.template5.AutoSize = true;
            this.template5.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.template5.ForeColor = System.Drawing.Color.Blue;
            this.template5.Location = new System.Drawing.Point(5, 106);
            this.template5.Name = "template5";
            this.template5.Size = new System.Drawing.Size(45, 17);
            this.template5.TabIndex = 4;
            this.template5.Text = "Japan";
            this.template5.Click += new System.EventHandler(this.template5_Click);
            // 
            // template4
            // 
            this.template4.AutoSize = true;
            this.template4.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.template4.ForeColor = System.Drawing.Color.Blue;
            this.template4.Location = new System.Drawing.Point(5, 80);
            this.template4.Name = "template4";
            this.template4.Size = new System.Drawing.Size(39, 17);
            this.template4.TabIndex = 3;
            this.template4.Text = "Oreo";
            this.template4.Click += new System.EventHandler(this.template4_Click);
            // 
            // template3
            // 
            this.template3.AutoSize = true;
            this.template3.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.template3.ForeColor = System.Drawing.Color.Blue;
            this.template3.Location = new System.Drawing.Point(5, 53);
            this.template3.Name = "template3";
            this.template3.Size = new System.Drawing.Size(81, 17);
            this.template3.TabIndex = 2;
            this.template3.Text = "WhiteBlack";
            this.template3.Click += new System.EventHandler(this.template3_Click);
            // 
            // template2
            // 
            this.template2.AutoSize = true;
            this.template2.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.template2.ForeColor = System.Drawing.Color.Blue;
            this.template2.Location = new System.Drawing.Point(5, 26);
            this.template2.Name = "template2";
            this.template2.Size = new System.Drawing.Size(92, 17);
            this.template2.TabIndex = 1;
            this.template2.Text = "GosperGlider";
            this.template2.Click += new System.EventHandler(this.template2_Click);
            // 
            // template1
            // 
            this.template1.AutoSize = true;
            this.template1.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.template1.ForeColor = System.Drawing.Color.Blue;
            this.template1.Location = new System.Drawing.Point(5, 0);
            this.template1.Name = "template1";
            this.template1.Size = new System.Drawing.Size(61, 17);
            this.template1.TabIndex = 0;
            this.template1.Text = "Random";
            this.template1.Click += new System.EventHandler(this.template1_Click);
            // 
            // clockspeed1
            // 
            this.clockspeed1.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockspeed1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.clockspeed1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.clockspeed1.Location = new System.Drawing.Point(424, 15);
            this.clockspeed1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.clockspeed1.Name = "clockspeed1";
            this.clockspeed1.Size = new System.Drawing.Size(52, 22);
            this.clockspeed1.TabIndex = 6;
            this.clockspeed1.Tag = "";
            this.clockspeed1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clockspeed1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.clockspeed1.ValueChanged += new System.EventHandler(this.clockspeed1_ValueChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Purple;
            this.button1.Location = new System.Drawing.Point(344, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 24);
            this.button1.TabIndex = 7;
            this.button1.Text = "Interval";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // wraplabel
            // 
            this.wraplabel.AutoSize = true;
            this.wraplabel.BackColor = System.Drawing.Color.White;
            this.wraplabel.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wraplabel.ForeColor = System.Drawing.Color.Purple;
            this.wraplabel.Location = new System.Drawing.Point(482, 18);
            this.wraplabel.Name = "wraplabel";
            this.wraplabel.Size = new System.Drawing.Size(121, 18);
            this.wraplabel.TabIndex = 9;
            this.wraplabel.Text = "Wrapped Edge";
            this.wraplabel.Click += new System.EventHandler(this.wraplabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1924, 953);
            this.Controls.Add(this.wraplabel);
            this.Controls.Add(this.clockspeed1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menu1);
            this.Controls.Add(this.fillBox1);
            this.Controls.Add(this.reset1);
            this.Controls.Add(this.pause1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cellular Automata";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clockspeed1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button pause1;
        private System.Windows.Forms.Button reset1;
        private System.Windows.Forms.TextBox fillBox1;
        private System.Windows.Forms.Button menu1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label template3;
        private System.Windows.Forms.Label template2;
        private System.Windows.Forms.Label template1;
        private System.Windows.Forms.Label template7;
        private System.Windows.Forms.Label template6;
        private System.Windows.Forms.Label template5;
        private System.Windows.Forms.Label template4;
        private System.Windows.Forms.NumericUpDown clockspeed1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label wraplabel;
    }
}

