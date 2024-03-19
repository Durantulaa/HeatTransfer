namespace HeatTransfer
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtSteelBallTemp = new System.Windows.Forms.TextBox();
            this.lblChooseTime = new System.Windows.Forms.Label();
            this.txtChooseTime = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblSteelBallTemp = new System.Windows.Forms.Label();
            this.tmrAnimation = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDisplayTime = new System.Windows.Forms.Label();
            this.lblDisplayTemp = new System.Windows.Forms.Label();
            this.tmrTempAnimation = new System.Windows.Forms.Timer(this.components);
            this.lbltitle = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.lblBoilingWatherTemp = new System.Windows.Forms.Label();
            this.lblWater = new System.Windows.Forms.Label();
            this.animation1 = new HeatTransfer.Animation();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.ButtonShadow;
            resources.ApplyResources(this.btnReset, "btnReset");
            this.btnReset.Name = "btnReset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtSteelBallTemp
            // 
            resources.ApplyResources(this.txtSteelBallTemp, "txtSteelBallTemp");
            this.txtSteelBallTemp.Name = "txtSteelBallTemp";
            // 
            // lblChooseTime
            // 
            resources.ApplyResources(this.lblChooseTime, "lblChooseTime");
            this.lblChooseTime.Name = "lblChooseTime";
            // 
            // txtChooseTime
            // 
            resources.ApplyResources(this.txtChooseTime, "txtChooseTime");
            this.txtChooseTime.Name = "txtChooseTime";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.AppWorkspace;
            resources.ApplyResources(this.btnStart, "btnStart");
            this.btnStart.Name = "btnStart";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblSteelBallTemp
            // 
            resources.ApplyResources(this.lblSteelBallTemp, "lblSteelBallTemp");
            this.lblSteelBallTemp.Name = "lblSteelBallTemp";
            // 
            // tmrAnimation
            // 
            this.tmrAnimation.Tick += new System.EventHandler(this.tmrAnimation_Tick);
            // 
            // lblTime
            // 
            resources.ApplyResources(this.lblTime, "lblTime");
            this.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTime.Name = "lblTime";
            // 
            // lblDisplayTime
            // 
            resources.ApplyResources(this.lblDisplayTime, "lblDisplayTime");
            this.lblDisplayTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDisplayTime.Name = "lblDisplayTime";
            // 
            // lblDisplayTemp
            // 
            resources.ApplyResources(this.lblDisplayTemp, "lblDisplayTemp");
            this.lblDisplayTemp.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblDisplayTemp.Name = "lblDisplayTemp";
            // 
            // tmrTempAnimation
            // 
            this.tmrTempAnimation.Enabled = true;
            this.tmrTempAnimation.Interval = 1000;
            this.tmrTempAnimation.Tick += new System.EventHandler(this.tmrTempAnimation_Tick);
            // 
            // lbltitle
            // 
            resources.ApplyResources(this.lbltitle, "lbltitle");
            this.lbltitle.Name = "lbltitle";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            resources.ApplyResources(this.aboutToolStripMenuItem1, "aboutToolStripMenuItem1");
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // dgvResult
            // 
            this.dgvResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResult.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgvResult, "dgvResult");
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvResult.RowTemplate.Height = 24;
            // 
            // lblBoilingWatherTemp
            // 
            resources.ApplyResources(this.lblBoilingWatherTemp, "lblBoilingWatherTemp");
            this.lblBoilingWatherTemp.Name = "lblBoilingWatherTemp";
            // 
            // lblWater
            // 
            resources.ApplyResources(this.lblWater, "lblWater");
            this.lblWater.Name = "lblWater";
            // 
            // animation1
            // 
            this.animation1.BackColor = System.Drawing.Color.Transparent;
            this.animation1.ballPositionY = 0;
            resources.ApplyResources(this.animation1, "animation1");
            this.animation1.Name = "animation1";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblWater);
            this.Controls.Add(this.animation1);
            this.Controls.Add(this.dgvResult);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.lblDisplayTemp);
            this.Controls.Add(this.lblDisplayTime);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblSteelBallTemp);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtChooseTime);
            this.Controls.Add(this.lblChooseTime);
            this.Controls.Add(this.txtSteelBallTemp);
            this.Controls.Add(this.lblBoilingWatherTemp);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtSteelBallTemp;
        private System.Windows.Forms.Label lblChooseTime;
        private System.Windows.Forms.TextBox txtChooseTime;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblSteelBallTemp;
        private System.Windows.Forms.Timer tmrAnimation;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDisplayTime;
        private System.Windows.Forms.Label lblDisplayTemp;
        private System.Windows.Forms.Timer tmrTempAnimation;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvResult;
        private Animation animation1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.Label lblBoilingWatherTemp;
        private System.Windows.Forms.Label lblWater;
    }
}

