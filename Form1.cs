using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FileCompare
{
    public partial class FileCompare : Form
    {
        public FileCompare()
        {
            InitializeComponent();
            InitializeListViews();

            btnCopyFromLeft.Click += btnCopyFromLeft_Click;
            btnCopyFromRight.Click += btnCopyFromRight_Click;
        }

        private void InitializeListViews()
        {
            lvwLeftDir.View = View.Details;
            lvwLeftDir.FullRowSelect = true;
            lvwLeftDir.GridLines = true;
            lvwLeftDir.Columns.Clear();
            lvwLeftDir.Columns.Add("이름", 500);
            lvwLeftDir.Columns.Add("크기", 150);
            lvwLeftDir.Columns.Add("수정일", 250);

            lvwrightDir.View = View.Details;
            lvwrightDir.FullRowSelect = true;
            lvwrightDir.GridLines = true;
            lvwrightDir.Columns.Clear();
            lvwrightDir.Columns.Add("이름", 500);
            lvwrightDir.Columns.Add("크기", 150);
            lvwrightDir.Columns.Add("수정일", 250);
        }

        // ⭐ 하위폴더 포함 전체 파일 가져오기
        private Dictionary<string, FileInfo> GetAllFiles(string rootPath)
        {
            return Directory.EnumerateFiles(rootPath, "*", SearchOption.AllDirectories)
                .Select(path => new FileInfo(path))
                .ToDictionary(
                    file => Path.GetRelativePath(rootPath, file.FullName),
                    StringComparer.OrdinalIgnoreCase
                );
        }

        // ⭐ 양쪽 새로고침 + 비교
        private void RefreshBothListViews()
        {
            string leftPath = txtLeftDir.Text;
            string rightPath = txtRightDir.Text;

            if (!Directory.Exists(leftPath) || !Directory.Exists(rightPath))
                return;

            var leftFiles = GetAllFiles(leftPath);
            var rightFiles = GetAllFiles(rightPath);

            PopulateListView(lvwLeftDir, leftFiles, rightFiles);
            PopulateListView(lvwrightDir, rightFiles, leftFiles);
        }

        // ⭐ 색상 비교 출력
        private void PopulateListView(
            ListView lv,
            Dictionary<string, FileInfo> myFiles,
            Dictionary<string, FileInfo> otherFiles)
        {
            lv.BeginUpdate();
            lv.Items.Clear();

            try
            {
                foreach (var pair in myFiles.OrderBy(x => x.Key))
                {
                    string path = pair.Key;
                    FileInfo file = pair.Value;

                    var item = new ListViewItem(path);
                    item.SubItems.Add(file.Length.ToString("N0") + " 바이트");
                    item.SubItems.Add(file.LastWriteTime.ToString("g"));

                    if (otherFiles.TryGetValue(path, out var other))
                    {
                        if (file.LastWriteTime == other.LastWriteTime)
                            item.ForeColor = Color.Black;   // 동일
                        else if (file.LastWriteTime > other.LastWriteTime)
                            item.ForeColor = Color.Red;     // 최신
                        else
                            item.ForeColor = Color.Gray;    // 오래됨
                    }
                    else
                    {
                        item.ForeColor = Color.Purple;      // 단독
                    }

                    lv.Items.Add(item);
                }
            }
            finally
            {
                lv.EndUpdate();
            }
        }

        // ⭐ 폴더 선택
        private void btnLeftDir_Click(object sender, EventArgs e)
        {
            using (var dlg = new FolderBrowserDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtLeftDir.Text = dlg.SelectedPath;
                    RefreshBothListViews();
                }
            }
        }

        private void btnRightDir_Click(object sender, EventArgs e)
        {
            using (var dlg = new FolderBrowserDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtRightDir.Text = dlg.SelectedPath;
                    RefreshBothListViews();
                }
            }
        }

        // ⭐ 복사 핵심 (조건 분기 포함)
        private void CopySelectedFiles(ListView sourceList, string sourceRoot, string targetRoot)
        {
            if (!Directory.Exists(sourceRoot) || !Directory.Exists(targetRoot))
            {
                MessageBox.Show("폴더 선택 먼저 하세요");
                return;
            }



            foreach (ListViewItem item in sourceList.SelectedItems)
            {
                string relativePath = item.Text;

                string src = Path.Combine(sourceRoot, relativePath);
                string dst = Path.Combine(targetRoot, relativePath);

                if (!File.Exists(src))
                    continue;

                try
                {
                    // 폴더 자동 생성
                    string dir = Path.GetDirectoryName(dst);
                    if (!Directory.Exists(dir))
                        Directory.CreateDirectory(dir);

                    if (File.Exists(dst))
                    {
                        FileInfo srcInfo = new FileInfo(src);
                        FileInfo dstInfo = new FileInfo(dst);

                        // 🔴 최신 → 자동 덮어쓰기
                        if (srcInfo.LastWriteTime > dstInfo.LastWriteTime)
                        {
                            File.Copy(src, dst, true);
                        }
                        // ⚪ 오래됨 → 경고
                        else if (srcInfo.LastWriteTime < dstInfo.LastWriteTime)
                        {
                            DialogResult r = MessageBox.Show(
                                "대상 파일이 더 최신입니다.\n덮어쓰시겠습니까?",
                                "경고",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Warning);

                            if (r == DialogResult.Yes)
                                File.Copy(src, dst, true);
                        }
                        // 동일 → 무시
                    }
                    else
                    {
                        File.Copy(src, dst);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("오류: " + ex.Message);
                }
            }

            RefreshBothListViews();
        }

        private void btnCopyFromLeft_Click(object sender, EventArgs e)
        {
            CopySelectedFiles(lvwLeftDir, txtLeftDir.Text, txtRightDir.Text);
        }

        private void btnCopyFromRight_Click(object sender, EventArgs e)
        {
            CopySelectedFiles(lvwrightDir, txtRightDir.Text, txtLeftDir.Text);
        }
    }
}