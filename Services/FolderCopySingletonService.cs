using System.Collections.Generic;
using System.IO;

namespace FolderCopy.Services
{
    public class FolderCopySingletonService
    {
        // 単一のインスタンス。
        public static FolderCopySingletonService _singleton = new FolderCopySingletonService();

        /// <summary>
        /// 単一のインスタンスを取得します。
        /// </summary>
        /// <returns>単一のインスタンスを返します。</returns>
        public static FolderCopySingletonService GetInstance()
        {
            return _singleton;
        }

        /// <summary>
        /// コンストラクタ定義。
        /// </summary>
        private FolderCopySingletonService()
        {
        }

        /// <summary>
        /// フォルダコピーを行います。
        /// </summary>
        /// <param name="originalPath">コピー元のパス。</param>
        /// <param name="copyToPath">コピー先のパス。</param>
        /// <param name="extensionList">拡張子リスト。</param>
        public void FolderCopy(string originalPath, string copyToPath, List<string> extensionList, bool overWrite)
        {
            // コピー元のファイルにて走査します。
            foreach (var filePath in Directory.GetFiles(originalPath))
            {
                // ファイルの拡張子を小文字にて取得します。
                var fileLowerExtension = Path.GetExtension(filePath).ToLower();

                // 拡張子リストに存在するかを判定します。
                if (extensionList.Contains(fileLowerExtension))
                {
                    // コピー先のファイルパスを取得します。
                    var copyToFilePath = filePath.Replace(originalPath, copyToPath);

                    // ファイルをコピーします。
                    File.Copy(filePath, copyToFilePath, overWrite);
                }
            }

            // コピー元のフォルダにて走査します。
            foreach (var path in Directory.GetDirectories(originalPath))
            {
                // コピー先のフォルダのパスを取得します。
                var createPath = path.Replace(originalPath, copyToPath);

                // コピー先のフォルダが存在する場合は処理をスキップします。
                if (Directory.Exists(createPath)) continue;

                // コピー先のフォルダを作成します。
                Directory.CreateDirectory(createPath);

                // 再帰的にフォルダコピーを行います。
                this.FolderCopy(path, createPath, extensionList, overWrite);
            }
        }
    }
}
