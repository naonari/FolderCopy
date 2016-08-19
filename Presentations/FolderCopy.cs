using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using NexFx.Controls;
using FolderCopy.Resources;
using FolderCopy.Services;

namespace FolderCopy.Presentations
{
    public partial class FolderCopy : ExForm
    {
        /// <summary>
        /// コンストラクタ定義。
        /// </summary>
        public FolderCopy()
        {
            // 初期設定を行います。
            InitializeComponent();
        }

        /// <summary>
        /// 画面読込時の処理を行います。
        /// </summary>
        private void FolderCopy_Load(object sender, EventArgs e)
        {
            // 画面の初期化を行います。
            this.FolderCopy_Initialize(true);
        }

        /// <summary>
        /// 画面の初期化を行います。
        /// </summary>
        /// <param name="forceInitialize">強制画面初期化値。</param>
        private void FolderCopy_Initialize(bool forceInitialize)
        {
            // 設定ファイルサービスを取得します。
            var css = ConfigSingletonService.GetInstance();

            // 各コントロールに初期化します。
            if (forceInitialize || css.GetCompleteInitialize(this.txtOriginal.Key, true))
            {
                this.txtOriginal.Text = css.GetDefaultValue(this.txtOriginal.Key);
            }

            if (forceInitialize || css.GetCompleteInitialize(this.txtCopyTo.Key, true))
            {
                this.txtCopyTo.Text = css.GetDefaultValue(this.txtCopyTo.Key);
            }

            if (forceInitialize || css.GetCompleteInitialize(this.txtExtension.Key, true))
            {
                this.txtExtension.Text = css.GetDefaultValue(this.txtExtension.Key);
            }

            if (forceInitialize || css.GetCompleteInitialize(this.cbOverWrite.Key, true))
            {
                this.cbOverWrite.Checked = css.GetDefaultValue(this.cbOverWrite.Key, true);
            }
        }

        /// <summary>
        /// コピー元ボタン押下時の処理を行います。
        /// </summary>
        private void btnOriginal_Click(object sender, EventArgs e)
        {
            // ディレクトリ選択ダイアログをインスタン化します。
            using (var ofd = new FolderBrowserDialog())
            {
                // ダイアログの結果を判定し、テキストボックスにパスを設定します。
                if (ofd.ShowDialog() == DialogResult.OK)
                    this.txtOriginal.Text = ofd.SelectedPath;
            }
        }

        /// <summary>
        /// コピー先ボタン押下時の処理を行います。
        /// </summary>
        private void btnCopyTo_Click(object sender, EventArgs e)
        {
            // ディレクトリ選択ダイアログをインスタン化します。
            using (var ofd = new FolderBrowserDialog())
            {
                // ダイアログの結果を判定し、テキストボックスにパスを設定します。
                if (ofd.ShowDialog() == DialogResult.OK)
                    this.txtCopyTo.Text = ofd.SelectedPath;
            }
        }

        /// <summary>
        /// 実行ボタン押下時の処理を行います。
        /// </summary>
        private void btnExecute_Click(object sender, EventArgs e)
        {
            // コピー元ディレクトリが未入力かを判定します。
            if (string.IsNullOrWhiteSpace(this.txtOriginal.Text))
            {
                // エラーメッセージを表示します。
                var message = string.Format(Messages.E0001, "コピー元");
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // コピー元ディレクトリが存在するかを判定します。
            if (!Directory.Exists(this.txtOriginal.Text))
            {
                // エラーメッセージを表示します。
                var message = string.Format(Messages.E0002, "コピー元");
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // コピー先ディレクトリが未入力かを判定します。
            if (string.IsNullOrWhiteSpace(this.txtCopyTo.Text))
            {
                // エラーメッセージを表示します。
                var message = string.Format(Messages.E0001, "コピー先");
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // コピー先ディレクトリが存在するかを判定します。
            if (!Directory.Exists(this.txtCopyTo.Text))
            {
                // エラーメッセージを表示します。
                var message = string.Format(Messages.E0002, "コピー先");
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 拡張子リスト変数。
            var extensionList = new List<string>();

            // 拡張子の入力値を判定します。
            if (!string.IsNullOrWhiteSpace(this.txtExtension.Text))
            {
                // 入力された拡張子を小文字化して取得します。
                var extensions = this.txtExtension.Text.ToLower().Split(',');

                // リストに設定します。
                extensionList.AddRange(extensions);
            }

            // サービスを取得します。
            var fcss = FolderCopySingletonService.GetInstance();

            try
            {
                // 末尾のパスセパレータを取り除いた値を取得します。
                var originalPath = this.txtOriginal.Text.Trim().TrimEnd('\\');
                var copyToPath = this.txtCopyTo.Text.Trim().TrimEnd('\\');

                // フォルダをコピーします。
                fcss.FolderCopy(this.txtOriginal.Text, this.txtCopyTo.Text, extensionList, this.cbOverWrite.Checked);

                // 完了メッセージを表示します。
                MessageBox.Show(Messages.N0001, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 画面の初期化をします。
                this.FolderCopy_Initialize(false);
            }
            catch
            {
                // エラーメッセージを表示します。
                MessageBox.Show(Messages.E0003, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
