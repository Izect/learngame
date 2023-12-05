namespace Learning_Game
{
    partial class frm_select
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
            this.btn_math = new System.Windows.Forms.Button();
            this.btn_puzzle = new System.Windows.Forms.Button();
            this.btn_color = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_math
            // 
            this.btn_math.Location = new System.Drawing.Point(14, 466);
            this.btn_math.Name = "btn_math";
            this.btn_math.Size = new System.Drawing.Size(177, 59);
            this.btn_math.TabIndex = 0;
            this.btn_math.Text = "Math";
            this.btn_math.UseVisualStyleBackColor = true;
            this.btn_math.Click += new System.EventHandler(this.btn_math_Click);
            // 
            // btn_puzzle
            // 
            this.btn_puzzle.Location = new System.Drawing.Point(14, 401);
            this.btn_puzzle.Name = "btn_puzzle";
            this.btn_puzzle.Size = new System.Drawing.Size(179, 59);
            this.btn_puzzle.TabIndex = 0;
            this.btn_puzzle.Text = "Puzzle";
            this.btn_puzzle.UseVisualStyleBackColor = true;
            this.btn_puzzle.Click += new System.EventHandler(this.btn_puzzle_Click);
            // 
            // btn_color
            // 
            this.btn_color.Location = new System.Drawing.Point(12, 336);
            this.btn_color.Name = "btn_color";
            this.btn_color.Size = new System.Drawing.Size(179, 59);
            this.btn_color.TabIndex = 0;
            this.btn_color.Text = "Color";
            this.btn_color.UseVisualStyleBackColor = true;
            this.btn_color.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_math);
            this.groupBox1.Controls.Add(this.btn_color);
            this.groupBox1.Controls.Add(this.btn_puzzle);
            this.groupBox1.Location = new System.Drawing.Point(1161, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 701);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tutorial";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(11, 110);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 156);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(180, 40);
            this.button3.TabIndex = 2;
            this.button3.Text = "button1";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Play";
            // 
            // frm_select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1363, 712);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_select";
            this.Text = "Selection_Screen";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_math;
        private System.Windows.Forms.Button btn_puzzle;
        private System.Windows.Forms.Button btn_color;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}