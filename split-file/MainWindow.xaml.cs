using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MSAPI = Microsoft.WindowsAPICodePack;

namespace split_file
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSelectFile_Click(object sender, RoutedEventArgs e)
        {
            var d = new MSAPI::Dialogs.CommonOpenFileDialog();
            d.Title = "分割するファイルを選択してください。";
            if (d.ShowDialog() == MSAPI::Dialogs.CommonFileDialogResult.Ok)
                tbFile.Text = d.FileName;
        }

        private void btnSelectFolder_Click(object sender, RoutedEventArgs e)
        {
            var d = new MSAPI::Dialogs.CommonOpenFileDialog();
            d.IsFolderPicker = true;
            d.Title = "分割したファイルを出力するフォルダを選択してください。";
            if (d.ShowDialog() == MSAPI::Dialogs.CommonFileDialogResult.Ok)
                tbOutFolder.Text = d.FileName;
        }

        private void btnSplit_Click(object sender, RoutedEventArgs e)
        {
            // 分割ファイル
            var sourcePath = tbFile.Text;
            if (string.IsNullOrEmpty(sourcePath) || !File.Exists(sourcePath))
            {
                MessageBox.Show("分割するファイルが見つかりません。");
                return;
            }
            // 出力フォルダ
            var outFolderPath = tbOutFolder.Text;
            if (string.IsNullOrEmpty(outFolderPath) || !Directory.Exists(outFolderPath))
            {
                MessageBox.Show("分割したファイルを出力するフォルダが見つかりません。");
                return;
            }
            // 分割単位
            if(!int.TryParse(tbDivNum.Text, out int divNum))
            {
                MessageBox.Show("分割単位となる数が正しく入力されていません。");
                return;
            }

            switch (cbMethod.SelectedIndex)
            {
                // 文字
                case 0:
                    break;
                // 行
                case 1:
                    DivFileLine(sourcePath, outFolderPath, divNum);
                    break;
                default:
                    throw new NotImplementedException();
            }

            MessageBox.Show("ファイル分割が完了しました。");
        }

        private void DivFileLine(string sourcePath, string outFolderPath, int divNum)
        {
            using(var sr = new StreamReader(sourcePath))

            {
                var idx = 0;
                var fidx = 0;
                string outPath = null;
                string line = null;
                while((line = sr.ReadLine()) != null)
                {
                    if (idx % divNum == 0)
                    {
                        fidx++;
                        outPath = System.IO.Path.Combine(
                            outFolderPath,
                            $"splited-{fidx}-{System.IO.Path.GetFileName(sourcePath)}");
                        if (File.Exists(outPath)) File.Delete(outPath);
                    }
                    idx++;
                    File.AppendAllLines(outPath, new List<string> { line });
                }
            }
        }

        private void cbMethod_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (cbMethod.SelectedIndex)
            {
                // 文字
                case 0:
                    tbDivNum.Text = "1000000";
                    break;
                // 行
                case 1:
                    tbDivNum.Text = "1000";
                    break;
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
