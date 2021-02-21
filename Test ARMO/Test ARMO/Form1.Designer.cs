
namespace Test_ARMO
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.treeViewFoldersFiles = new System.Windows.Forms.TreeView();
            this.labelGeneralInfo = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBoxDir = new System.Windows.Forms.TextBox();
            this.labelColInfo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeViewFoldersFiles
            // 
            this.treeViewFoldersFiles.Location = new System.Drawing.Point(12, 12);
            this.treeViewFoldersFiles.Name = "treeViewFoldersFiles";
            this.treeViewFoldersFiles.Size = new System.Drawing.Size(181, 426);
            this.treeViewFoldersFiles.TabIndex = 0;
            this.treeViewFoldersFiles.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeViewFoldersFiles_BeforeExpand_1);
            this.treeViewFoldersFiles.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewFoldersFiles_AfterSelect);
            // 
            // labelGeneralInfo
            // 
            this.labelGeneralInfo.AutoSize = true;
            this.labelGeneralInfo.Location = new System.Drawing.Point(6, 41);
            this.labelGeneralInfo.Name = "labelGeneralInfo";
            this.labelGeneralInfo.Size = new System.Drawing.Size(179, 13);
            this.labelGeneralInfo.TabIndex = 3;
            this.labelGeneralInfo.Text = "- Общее количество файлов:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(222, 53);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(510, 147);
            this.listBox1.TabIndex = 4;
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // textBoxDir
            // 
            this.textBoxDir.Location = new System.Drawing.Point(330, 15);
            this.textBoxDir.Name = "textBoxDir";
            this.textBoxDir.Size = new System.Drawing.Size(402, 20);
            this.textBoxDir.TabIndex = 5;
            // 
            // labelColInfo
            // 
            this.labelColInfo.AutoSize = true;
            this.labelColInfo.Location = new System.Drawing.Point(6, 75);
            this.labelColInfo.Name = "labelColInfo";
            this.labelColInfo.Size = new System.Drawing.Size(204, 13);
            this.labelColInfo.TabIndex = 6;
            this.labelColInfo.Text = "- Количество найденных файлов:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelColInfo);
            this.groupBox1.Controls.Add(this.labelGeneralInfo);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(357, 260);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 121);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Общая информация";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(381, 206);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(351, 20);
            this.textBoxSearch.TabIndex = 10;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "pink-xopixel-folder_99392.ico");
            this.imageList1.Images.SetKeyName(1, "file-add_114479.ico");
            this.imageList1.Images.SetKeyName(2, "vcsnormal_93488.ico");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Директория:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Поиск файлов:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxDir);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.treeViewFoldersFiles);
            this.Name = "Form1";
            this.Text = "ARMO";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewFoldersFiles;
        private System.Windows.Forms.Label labelGeneralInfo;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBoxDir;
        private System.Windows.Forms.Label labelColInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

