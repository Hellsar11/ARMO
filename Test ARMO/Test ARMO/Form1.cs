using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_ARMO
{
    public partial class Form1 : Form
    {
        List<TreeNode> FindedFiles = new List<TreeNode>();
        

        public Form1()
        {
            InitializeComponent();
            treeViewFoldersFiles.BeforeExpand += treeViewFoldersFiles_BeforeExpand_1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Drives();
        }

        private void Drives()
        {
            try
            {
                foreach (DriveInfo drive in DriveInfo.GetDrives())
                {
                    TreeNode driveNode = new TreeNode { Text = drive.Name };
                    DaughterNodes(driveNode, drive.Name);
                    treeViewFoldersFiles.Nodes.Add(driveNode);
                }
            }
            catch (Exception ex) { }
        }

        private void DaughterNodes(TreeNode driveNode, string path)
        {
            treeViewFoldersFiles.ImageList = imageList1;
            try
            {
                string[] dirs = Directory.GetDirectories(path);
                foreach (string dir in dirs)
                {
                    TreeNode dirNode = new TreeNode{Text = dir.Remove(0, dir.LastIndexOf("\\") + 1), ImageIndex=0};
                    driveNode.Nodes.Add(dirNode);
                }

                string[] dirsFile = Directory.GetFiles(path);
                foreach (string dir in dirsFile)
                {
                    TreeNode dirNode = new TreeNode { Text = dir.Remove(0, dir.LastIndexOf("\\") + 1), ImageIndex=1 };                  
                    driveNode.Nodes.Add(dirNode);
                }

            }
            catch (Exception ex) { }
        }

        private void treeViewFoldersFiles_BeforeExpand_1(object sender, TreeViewCancelEventArgs e)
        {
            e.Node.Nodes.Clear();
            string[] dirs;
            try
            {
                
                if (Directory.Exists(e.Node.FullPath))
                {
                    dirs = Directory.GetDirectories(e.Node.FullPath);
                    if (dirs.Length != 0)
                    {
                        for (int i = 0; i < dirs.Length; i++)
                        {
                            TreeNode dirNode = new TreeNode (new DirectoryInfo(dirs[i]).Name);
                            DaughterNodes(dirNode, dirs[i]);
                            e.Node.Nodes.Add(dirNode);
                        };
                            
                    }

                        string[] dirsFile = Directory.GetFiles(e.Node.FullPath);
                        foreach (string dir in dirsFile)
                        {
                            TreeNode dirNode = new TreeNode { ImageIndex=1};
                            dirNode.Text = dir.Remove(0, dir.LastIndexOf("\\") + 1);
                            e.Node.Nodes.Add(dirNode);
                        }
                    
                }
            }
            catch (Exception ex) { }
        }

        private void Find(string stext, TreeNode sNode)
        {
            try
            {
                while (sNode != null)
                {
                    if (sNode.Text.Contains(stext))
                    {
                        FindedFiles.Add(sNode);
                    }

                    if (sNode.Nodes.Count != 0)
                    {
                        Find(stext, sNode.Nodes[0]);
                    }
                    sNode = sNode.NextNode;
                }
            }
            catch(Exception ex) { }
           
        }

        private void treeViewFoldersFiles_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                textBoxDir.Text = e.Node.FullPath;
                listBox1.Items.Clear();
                DirectoryInfo directory = new DirectoryInfo(e.Node.FullPath);
                FileInfo[] info = directory.GetFiles();
                listBox1.Items.Add("Файлы в выделенной директории:");
                foreach (var files in info)
                {
                    listBox1.Items.Add(" ");
                    listBox1.Items.Add(files.Name);
                    listBox1.Items.Add("---------------------------------");
                    labelGeneralInfo.Text = $"- Общее количество файлов: {info.Count() }";
                }
            }
            catch (Exception ex) { }
        }


        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBoxSearch.Text != String.Empty)
                {

                    listBox1.Items.Clear();
                    FindedFiles.Clear();
                    TreeNode tr = treeViewFoldersFiles.SelectedNode;
                    Find(textBoxSearch.Text, tr);

                    if (FindedFiles.Count > 0)
                    {
                        for (int i = 0; i < FindedFiles.Count; i++)
                        {
                            listBox1.Items.Add(FindedFiles[i].Text);
                            listBox1.Items.Add("Директория папки: " + FindedFiles[i].FullPath);
                            listBox1.Items.Add("----------------------------------------------");
                            DirectoryInfo di = new DirectoryInfo(FindedFiles[i].FullPath);
                            var ar = di.GetFiles();
                            labelGeneralInfo.Text = $"- Общее количество файлов: {ar.Count()}";
                            labelColInfo.Text = $"- Количество найденных файлов: {FindedFiles.Count}";
                        }

                        


                    }
                    else
                    {
                        listBox1.Items.Add("По заданному критерию в текущей директории файлы не найдены");
                    }

                    
                }
                else
                {
                    labelColInfo.Text = $"- Количество найденных файлов: {0}";
                    labelGeneralInfo.Text = $"- Общее количество файлов: {0}";
                    listBox1.Items.Clear();
                }
            }
            catch { }
          
            
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                Process.Start(Path.Combine(textBoxDir.Text, listBox1.SelectedItem.ToString()));
            }
            catch { }
            
        }
    }
}
