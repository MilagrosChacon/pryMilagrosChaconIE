using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryMilagrosChaconIE
{
    public partial class FormCarpetas : Form
    {
        private void FormCarpetas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        public FormCarpetas()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(FormCarpetas_KeyDown);
            PopulateTreeView();
        }

        clsLogs logs = new clsLogs();
        private void PopulateTreeView()
        {
            TreeNode rootNode;

            DirectoryInfo info = new DirectoryInfo(@"../..");
            if (info.Exists)
            {
                rootNode = new TreeNode(info.Name);
                rootNode.Tag = info;
                GetDirectories(info.GetDirectories(), rootNode);
                trvMostrar.Nodes.Add(rootNode);
            }
        }
        private void GetDirectories(DirectoryInfo[] subDirs,TreeNode nodeToAddTo)
        {
            TreeNode aNode;
            DirectoryInfo[] subSubDirs;
            foreach (DirectoryInfo subDir in subDirs)
            {
                aNode = new TreeNode(subDir.Name, 0, 0);
                aNode.Tag = subDir;
                aNode.ImageKey = "carpeta";
                subSubDirs = subDir.GetDirectories();
                if (subSubDirs.Length != 0)
                {
                    GetDirectories(subSubDirs, aNode);
                }
                nodeToAddTo.Nodes.Add(aNode);
            }
        }

        void treeView1_NodeMouseClick(object sender,TreeNodeMouseClickEventArgs e)
        {
            TreeNode newSelected = e.Node;
            lstMostrar.Items.Clear();
            DirectoryInfo nodeDirInfo = (DirectoryInfo)newSelected.Tag;
            ListViewItem.ListViewSubItem[] subItems;
            ListViewItem item = null;

            foreach (DirectoryInfo dir in nodeDirInfo.GetDirectories())
            {
                item = new ListViewItem(dir.Name, 0);
                subItems = new ListViewItem.ListViewSubItem[]
                    {new ListViewItem.ListViewSubItem(item, "Directory"),new ListViewItem.ListViewSubItem(item,dir.LastAccessTime.ToShortDateString())};
                item.SubItems.AddRange(subItems);
                lstMostrar.Items.Add(item);
            }
            foreach (FileInfo file in nodeDirInfo.GetFiles())
            {
                item = new ListViewItem(file.Name, 1);
                subItems = new ListViewItem.ListViewSubItem[]
                    { new ListViewItem.ListViewSubItem(item, "File"),new ListViewItem.ListViewSubItem(item,file.LastAccessTime.ToShortDateString())};

                item.SubItems.AddRange(subItems);
                lstMostrar.Items.Add(item);
            }

            lstMostrar.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void trvMostrar_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            this.trvMostrar.NodeMouseClick +=
            new TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
        }

        private void pctVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form volver = new FormMenú();
            volver.Show();
        }

    }
}
