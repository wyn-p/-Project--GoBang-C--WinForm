using System.Drawing;

namespace GoBang
{
    partial class Form_Game
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.button3 = new System.Windows.Forms.Button();
            this.Label_MouseCoD = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.WarningMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.BurlyWood;
            this.button1.Location = new System.Drawing.Point(28, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "重新開始";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.clickGame_Process_Restart);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.BurlyWood;
            this.button3.Location = new System.Drawing.Point(28, 78);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(165, 44);
            this.button3.TabIndex = 2;
            this.button3.Text = "結束遊戲";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Game_Status_Shut);
            // 
            // Label_MouseCoD
            // 
            this.Label_MouseCoD.AutoSize = true;
            this.Label_MouseCoD.BackColor = System.Drawing.Color.BurlyWood;
            this.Label_MouseCoD.Location = new System.Drawing.Point(24, 525);
            this.Label_MouseCoD.Name = "Label_MouseCoD";
            this.Label_MouseCoD.Size = new System.Drawing.Size(64, 24);
            this.Label_MouseCoD.TabIndex = 3;
            this.Label_MouseCoD.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.BurlyWood;
            this.label1.Location = new System.Drawing.Point(24, 620);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.BurlyWood;
            this.label2.Location = new System.Drawing.Point(24, 571);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "label1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.BurlyWood;
            this.label4.Location = new System.Drawing.Point(24, 666);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "label4";
            // 
            // WarningMessage
            // 
            this.WarningMessage.AutoSize = true;
            this.WarningMessage.Location = new System.Drawing.Point(24, 704);
            this.WarningMessage.Name = "WarningMessage";
            this.WarningMessage.Size = new System.Drawing.Size(64, 24);
            this.WarningMessage.TabIndex = 8;
            this.WarningMessage.Text = "label3";
            // 
            // Form_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1795, 1251);
            this.Controls.Add(this.WarningMessage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Label_MouseCoD);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Name = "Form_Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_Game_Load);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Form_Game_MouseDoubleClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_Game_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label Label_MouseCoD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label WarningMessage;
    }
}

