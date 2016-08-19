namespace FolderCopy.Presentations
{
    partial class FolderCopy
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FolderCopy));
            this.pnlScreen = new NexFx.Controls.ExPanel();
            this.pnlBody = new NexFx.Controls.ExPanel();
            this.cbOverWrite = new NexFx.Controls.ExCheckBox();
            this.txtExtension = new NexFx.Controls.ExTextBox();
            this.lblExtension = new System.Windows.Forms.Label();
            this.btnExecute = new NexFx.Controls.ExButton();
            this.btnCopyTo = new NexFx.Controls.ExButton();
            this.lblCopyTo = new System.Windows.Forms.Label();
            this.btnOriginal = new NexFx.Controls.ExButton();
            this.lblOriginal = new System.Windows.Forms.Label();
            this.txtCopyTo = new NexFx.Controls.ExTextBox();
            this.txtOriginal = new NexFx.Controls.ExTextBox();
            this.pnlScreen.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlScreen
            // 
            this.pnlScreen.BackColor = System.Drawing.Color.Transparent;
            this.pnlScreen.Controls.Add(this.pnlBody);
            this.pnlScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlScreen.Location = new System.Drawing.Point(0, 0);
            this.pnlScreen.Name = "pnlScreen";
            this.pnlScreen.Size = new System.Drawing.Size(510, 196);
            this.pnlScreen.TabIndex = 0;
            // 
            // pnlBody
            // 
            this.pnlBody.BackColor = System.Drawing.Color.Transparent;
            this.pnlBody.Controls.Add(this.cbOverWrite);
            this.pnlBody.Controls.Add(this.txtExtension);
            this.pnlBody.Controls.Add(this.lblExtension);
            this.pnlBody.Controls.Add(this.btnExecute);
            this.pnlBody.Controls.Add(this.btnCopyTo);
            this.pnlBody.Controls.Add(this.btnOriginal);
            this.pnlBody.Controls.Add(this.txtCopyTo);
            this.pnlBody.Controls.Add(this.txtOriginal);
            this.pnlBody.Controls.Add(this.lblCopyTo);
            this.pnlBody.Controls.Add(this.lblOriginal);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 0);
            this.pnlBody.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(510, 196);
            this.pnlBody.TabIndex = 0;
            // 
            // cbOverWrite
            // 
            this.cbOverWrite.CaptionControl = null;
            this.cbOverWrite.FocusedBackColor = System.Drawing.SystemColors.Control;
            this.cbOverWrite.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.cbOverWrite.Key = "OverWrite";
            this.cbOverWrite.Location = new System.Drawing.Point(89, 131);
            this.cbOverWrite.Name = "cbOverWrite";
            this.cbOverWrite.Size = new System.Drawing.Size(147, 24);
            this.cbOverWrite.TabIndex = 8;
            this.cbOverWrite.Text = "ファイルの上書きをする";
            this.cbOverWrite.UseVisualStyleBackColor = true;
            // 
            // txtExtension
            // 
            this.txtExtension.BackColor = System.Drawing.SystemColors.Window;
            this.txtExtension.CaptionControl = this.lblExtension;
            this.txtExtension.FocusedBackColor = System.Drawing.Color.LightYellow;
            this.txtExtension.FocusedForeColor = System.Drawing.SystemColors.WindowText;
            this.txtExtension.Key = "Extension";
            this.txtExtension.Location = new System.Drawing.Point(89, 98);
            this.txtExtension.Name = "txtExtension";
            this.txtExtension.PlaceholderText = "例) .txt,.jpg,.jpeg";
            this.txtExtension.Size = new System.Drawing.Size(405, 23);
            this.txtExtension.TabIndex = 7;
            // 
            // lblExtension
            // 
            this.lblExtension.AutoSize = true;
            this.lblExtension.Location = new System.Drawing.Point(12, 101);
            this.lblExtension.Name = "lblExtension";
            this.lblExtension.Size = new System.Drawing.Size(67, 15);
            this.lblExtension.TabIndex = 6;
            this.lblExtension.Text = "対象拡張子";
            // 
            // btnExecute
            // 
            this.btnExecute.CaptionControl = null;
            this.btnExecute.FocusedBackColor = System.Drawing.Color.LightYellow;
            this.btnExecute.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExecute.Location = new System.Drawing.Point(12, 158);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(482, 30);
            this.btnExecute.TabIndex = 9;
            this.btnExecute.Text = "実行";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // btnCopyTo
            // 
            this.btnCopyTo.CaptionControl = this.lblCopyTo;
            this.btnCopyTo.FocusedBackColor = System.Drawing.Color.LightYellow;
            this.btnCopyTo.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCopyTo.Location = new System.Drawing.Point(60, 56);
            this.btnCopyTo.Name = "btnCopyTo";
            this.btnCopyTo.Size = new System.Drawing.Size(23, 23);
            this.btnCopyTo.TabIndex = 4;
            this.btnCopyTo.UseVisualStyleBackColor = true;
            this.btnCopyTo.Click += new System.EventHandler(this.btnCopyTo_Click);
            // 
            // lblCopyTo
            // 
            this.lblCopyTo.AutoSize = true;
            this.lblCopyTo.Location = new System.Drawing.Point(12, 60);
            this.lblCopyTo.Name = "lblCopyTo";
            this.lblCopyTo.Size = new System.Drawing.Size(46, 15);
            this.lblCopyTo.TabIndex = 3;
            this.lblCopyTo.Text = "コピー先";
            // 
            // btnOriginal
            // 
            this.btnOriginal.CaptionControl = this.lblOriginal;
            this.btnOriginal.FocusedBackColor = System.Drawing.Color.LightYellow;
            this.btnOriginal.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOriginal.Location = new System.Drawing.Point(60, 15);
            this.btnOriginal.Name = "btnOriginal";
            this.btnOriginal.Size = new System.Drawing.Size(23, 23);
            this.btnOriginal.TabIndex = 1;
            this.btnOriginal.UseVisualStyleBackColor = true;
            this.btnOriginal.Click += new System.EventHandler(this.btnOriginal_Click);
            // 
            // lblOriginal
            // 
            this.lblOriginal.AutoSize = true;
            this.lblOriginal.Location = new System.Drawing.Point(12, 19);
            this.lblOriginal.Name = "lblOriginal";
            this.lblOriginal.Size = new System.Drawing.Size(46, 15);
            this.lblOriginal.TabIndex = 0;
            this.lblOriginal.Text = "コピー元";
            // 
            // txtCopyTo
            // 
            this.txtCopyTo.BackColor = System.Drawing.SystemColors.Window;
            this.txtCopyTo.CaptionControl = this.lblCopyTo;
            this.txtCopyTo.FocusedBackColor = System.Drawing.Color.LightYellow;
            this.txtCopyTo.FocusedForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCopyTo.Key = "CopyTo";
            this.txtCopyTo.Location = new System.Drawing.Point(89, 57);
            this.txtCopyTo.Name = "txtCopyTo";
            this.txtCopyTo.Size = new System.Drawing.Size(405, 23);
            this.txtCopyTo.TabIndex = 5;
            this.txtCopyTo.TabStop = false;
            // 
            // txtOriginal
            // 
            this.txtOriginal.BackColor = System.Drawing.SystemColors.Window;
            this.txtOriginal.CaptionControl = this.lblOriginal;
            this.txtOriginal.FocusedBackColor = System.Drawing.Color.LightYellow;
            this.txtOriginal.FocusedForeColor = System.Drawing.SystemColors.WindowText;
            this.txtOriginal.Key = "Original";
            this.txtOriginal.Location = new System.Drawing.Point(89, 16);
            this.txtOriginal.Name = "txtOriginal";
            this.txtOriginal.Size = new System.Drawing.Size(405, 23);
            this.txtOriginal.TabIndex = 2;
            this.txtOriginal.TabStop = false;
            // 
            // FolderCopy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(510, 196);
            this.Controls.Add(this.pnlScreen);
            this.DuplicateLastTimePosition = true;
            this.EnableEscClose = true;
            this.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.GradationColor1 = System.Drawing.Color.Honeydew;
            this.GradationColor2 = System.Drawing.Color.PaleTurquoise;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FolderCopy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FolderCopy";
            this.Load += new System.EventHandler(this.FolderCopy_Load);
            this.pnlScreen.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private NexFx.Controls.ExPanel pnlScreen;
        private NexFx.Controls.ExPanel pnlBody;
        private NexFx.Controls.ExButton btnExecute;
        private NexFx.Controls.ExButton btnOriginal;
        private System.Windows.Forms.Label lblOriginal;
        private NexFx.Controls.ExTextBox txtOriginal;
        private NexFx.Controls.ExButton btnCopyTo;
        private System.Windows.Forms.Label lblCopyTo;
        private NexFx.Controls.ExTextBox txtCopyTo;
        private NexFx.Controls.ExTextBox txtExtension;
        private System.Windows.Forms.Label lblExtension;
        private NexFx.Controls.ExCheckBox cbOverWrite;
    }
}
