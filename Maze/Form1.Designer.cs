namespace Maze
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.win = new System.Windows.Forms.PictureBox();
            this.rat = new System.Windows.Forms.PictureBox();
            this.Map = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.win)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Map)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTime.ForeColor = System.Drawing.Color.Red;
            this.lblTime.Location = new System.Drawing.Point(333, 411);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(128, 16);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "时间剩余：60秒";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(25, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "编辑地图";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // win
            // 
            this.win.Image = ((System.Drawing.Image)(resources.GetObject("win.Image")));
            this.win.Location = new System.Drawing.Point(194, 111);
            this.win.Name = "win";
            this.win.Size = new System.Drawing.Size(138, 174);
            this.win.TabIndex = 4;
            this.win.TabStop = false;
            this.win.Visible = false;
            // 
            // rat
            // 
            this.rat.Image = ((System.Drawing.Image)(resources.GetObject("rat.Image")));
            this.rat.Location = new System.Drawing.Point(441, 317);
            this.rat.Name = "rat";
            this.rat.Size = new System.Drawing.Size(20, 20);
            this.rat.TabIndex = 2;
            this.rat.TabStop = false;
            // 
            // Map
            // 
            this.Map.Image = ((System.Drawing.Image)(resources.GetObject("Map.Image")));
            this.Map.Location = new System.Drawing.Point(-1, 0);
            this.Map.Name = "Map";
            this.Map.Size = new System.Drawing.Size(515, 383);
            this.Map.TabIndex = 0;
            this.Map.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 452);
            this.Controls.Add(this.win);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rat);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.Map);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "老鼠走迷宫  0906401-23 邓宇";
            ((System.ComponentModel.ISupportInitialize)(this.win)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Map)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Map;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.PictureBox rat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox win;

    }
}

