namespace risovalka
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UndoEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.ReduEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pencilTools = new System.Windows.Forms.ToolStripMenuItem();
            this.brushTools = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSize4 = new System.Windows.Forms.Button();
            this.buttonSize1 = new System.Windows.Forms.Button();
            this.buttonSize3 = new System.Windows.Forms.Button();
            this.buttonSize2 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.D = new System.Windows.Forms.Label();
            this.pictureBoxWhale = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelTools = new System.Windows.Forms.Panel();
            this.buttonPalette = new System.Windows.Forms.Button();
            this.buttonEraser = new System.Windows.Forms.Button();
            this.buttonPencile = new System.Windows.Forms.Button();
            this.buttonTriangle = new System.Windows.Forms.Button();
            this.buttonSquare = new System.Windows.Forms.Button();
            this.buttonTriangle90 = new System.Windows.Forms.Button();
            this.panelFigures = new System.Windows.Forms.Panel();
            this.buttonPolygon2 = new System.Windows.Forms.Button();
            this.buttonPolygon1 = new System.Windows.Forms.Button();
            this.buttonOval = new System.Windows.Forms.Button();
            this.buttonRectangle = new System.Windows.Forms.Button();
            this.buttonRedo = new System.Windows.Forms.Button();
            this.buttonUndo = new System.Windows.Forms.Button();
            this.buttonCircle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWhale)).BeginInit();
            this.panelTools.SuspendLayout();
            this.panelFigures.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Location = new System.Drawing.Point(173, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(615, 362);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.printToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.newToolStripMenuItem.Text = "&New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(181, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(181, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.printToolStripMenuItem.Text = "&Print";
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripMenuItem.Image")));
            this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.printPreviewToolStripMenuItem.Text = "Print Pre&view";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(181, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UndoEdit,
            this.ReduEdit,
            this.toolStripSeparator3,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator4,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // UndoEdit
            // 
            this.UndoEdit.Name = "UndoEdit";
            this.UndoEdit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.UndoEdit.Size = new System.Drawing.Size(184, 26);
            this.UndoEdit.Text = "&Undo";
            // 
            // ReduEdit
            // 
            this.ReduEdit.Name = "ReduEdit";
            this.ReduEdit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.ReduEdit.Size = new System.Drawing.Size(184, 26);
            this.ReduEdit.Text = "&Redo";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(181, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.cutToolStripMenuItem.Text = "Cu&t";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.copyToolStripMenuItem.Text = "&Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.pasteToolStripMenuItem.Text = "&Paste";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(181, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.selectAllToolStripMenuItem.Text = "Select &All";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pencilTools,
            this.brushTools});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // pencilTools
            // 
            this.pencilTools.Name = "pencilTools";
            this.pencilTools.Size = new System.Drawing.Size(180, 22);
            this.pencilTools.Text = "pencil";
            // 
            // brushTools
            // 
            this.brushTools.Name = "brushTools";
            this.brushTools.Size = new System.Drawing.Size(180, 22);
            this.brushTools.Text = "Brush";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(119, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(150, 150);
            this.toolStripContainer1.Location = new System.Drawing.Point(427, 290);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(150, 175);
            this.toolStripContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panelFigures);
            this.panel1.Controls.Add(this.buttonSize4);
            this.panel1.Controls.Add(this.buttonSize1);
            this.panel1.Controls.Add(this.buttonSize3);
            this.panel1.Controls.Add(this.buttonSize2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 426);
            this.panel1.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Yellow;
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(0, 168);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(190, 27);
            this.panel5.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(54, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фигуры";
            // 
            // buttonSize4
            // 
            this.buttonSize4.BackColor = System.Drawing.Color.Yellow;
            this.buttonSize4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSize4.Location = new System.Drawing.Point(121, 121);
            this.buttonSize4.Name = "buttonSize4";
            this.buttonSize4.Size = new System.Drawing.Size(32, 32);
            this.buttonSize4.TabIndex = 13;
            this.buttonSize4.UseVisualStyleBackColor = false;
            this.buttonSize4.Click += new System.EventHandler(this.buttonSize4_Click);
            // 
            // buttonSize1
            // 
            this.buttonSize1.BackColor = System.Drawing.Color.Yellow;
            this.buttonSize1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSize1.Location = new System.Drawing.Point(43, 138);
            this.buttonSize1.Name = "buttonSize1";
            this.buttonSize1.Size = new System.Drawing.Size(14, 14);
            this.buttonSize1.TabIndex = 10;
            this.buttonSize1.UseVisualStyleBackColor = false;
            this.buttonSize1.Click += new System.EventHandler(this.buttonSize1_Click);
            // 
            // buttonSize3
            // 
            this.buttonSize3.BackColor = System.Drawing.Color.Yellow;
            this.buttonSize3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSize3.Location = new System.Drawing.Point(89, 126);
            this.buttonSize3.Name = "buttonSize3";
            this.buttonSize3.Size = new System.Drawing.Size(26, 26);
            this.buttonSize3.TabIndex = 12;
            this.buttonSize3.UseVisualStyleBackColor = false;
            this.buttonSize3.Click += new System.EventHandler(this.buttonSize3_Click);
            // 
            // buttonSize2
            // 
            this.buttonSize2.BackColor = System.Drawing.Color.Yellow;
            this.buttonSize2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSize2.Location = new System.Drawing.Point(63, 132);
            this.buttonSize2.Name = "buttonSize2";
            this.buttonSize2.Size = new System.Drawing.Size(20, 20);
            this.buttonSize2.TabIndex = 11;
            this.buttonSize2.UseVisualStyleBackColor = false;
            this.buttonSize2.Click += new System.EventHandler(this.buttonSize2_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Yellow;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.pictureBoxWhale);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(190, 112);
            this.panel3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.D);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(190, 22);
            this.panel4.TabIndex = 7;
            // 
            // D
            // 
            this.D.AutoSize = true;
            this.D.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.D.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.D.Location = new System.Drawing.Point(36, 4);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(93, 18);
            this.D.TabIndex = 6;
            this.D.Text = "Whale Draw";
            // 
            // pictureBoxWhale
            // 
            this.pictureBoxWhale.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxWhale.Image")));
            this.pictureBoxWhale.Location = new System.Drawing.Point(0, 25);
            this.pictureBoxWhale.Name = "pictureBoxWhale";
            this.pictureBoxWhale.Size = new System.Drawing.Size(173, 84);
            this.pictureBoxWhale.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxWhale.TabIndex = 6;
            this.pictureBoxWhale.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Yellow;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(173, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(627, 22);
            this.panel2.TabIndex = 4;
            // 
            // panelTools
            // 
            this.panelTools.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelTools.Controls.Add(this.buttonUndo);
            this.panelTools.Controls.Add(this.buttonRedo);
            this.panelTools.Controls.Add(this.buttonPalette);
            this.panelTools.Controls.Add(this.buttonEraser);
            this.panelTools.Controls.Add(this.buttonPencile);
            this.panelTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTools.Location = new System.Drawing.Point(173, 46);
            this.panelTools.Name = "panelTools";
            this.panelTools.Size = new System.Drawing.Size(627, 39);
            this.panelTools.TabIndex = 5;
            // 
            // buttonPalette
            // 
            this.buttonPalette.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPalette.BackgroundImage")));
            this.buttonPalette.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPalette.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPalette.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPalette.Location = new System.Drawing.Point(104, 6);
            this.buttonPalette.Name = "buttonPalette";
            this.buttonPalette.Size = new System.Drawing.Size(28, 27);
            this.buttonPalette.TabIndex = 7;
            this.buttonPalette.UseVisualStyleBackColor = true;
            this.buttonPalette.Click += new System.EventHandler(this.buttonPalette_Click);
            // 
            // buttonEraser
            // 
            this.buttonEraser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEraser.BackgroundImage")));
            this.buttonEraser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonEraser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEraser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEraser.Location = new System.Drawing.Point(59, 6);
            this.buttonEraser.Name = "buttonEraser";
            this.buttonEraser.Size = new System.Drawing.Size(28, 27);
            this.buttonEraser.TabIndex = 8;
            this.buttonEraser.UseVisualStyleBackColor = true;
            // 
            // buttonPencile
            // 
            this.buttonPencile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPencile.BackgroundImage")));
            this.buttonPencile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPencile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPencile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPencile.Location = new System.Drawing.Point(15, 6);
            this.buttonPencile.Name = "buttonPencile";
            this.buttonPencile.Size = new System.Drawing.Size(28, 27);
            this.buttonPencile.TabIndex = 6;
            this.buttonPencile.UseVisualStyleBackColor = true;
            // 
            // buttonTriangle
            // 
            this.buttonTriangle.BackColor = System.Drawing.Color.LightBlue;
            this.buttonTriangle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonTriangle.BackgroundImage")));
            this.buttonTriangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonTriangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTriangle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonTriangle.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTriangle.Location = new System.Drawing.Point(12, 6);
            this.buttonTriangle.Name = "buttonTriangle";
            this.buttonTriangle.Size = new System.Drawing.Size(40, 40);
            this.buttonTriangle.TabIndex = 10;
            this.buttonTriangle.UseVisualStyleBackColor = false;
            // 
            // buttonSquare
            // 
            this.buttonSquare.BackColor = System.Drawing.Color.LightBlue;
            this.buttonSquare.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSquare.BackgroundImage")));
            this.buttonSquare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSquare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSquare.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSquare.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSquare.Location = new System.Drawing.Point(113, 6);
            this.buttonSquare.Name = "buttonSquare";
            this.buttonSquare.Size = new System.Drawing.Size(40, 40);
            this.buttonSquare.TabIndex = 13;
            this.buttonSquare.UseVisualStyleBackColor = false;
            // 
            // buttonTriangle90
            // 
            this.buttonTriangle90.BackColor = System.Drawing.Color.Yellow;
            this.buttonTriangle90.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTriangle90.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonTriangle90.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTriangle90.Location = new System.Drawing.Point(232, 250);
            this.buttonTriangle90.Name = "buttonTriangle90";
            this.buttonTriangle90.Size = new System.Drawing.Size(117, 38);
            this.buttonTriangle90.TabIndex = 14;
            this.buttonTriangle90.Text = "Прямоугольный треугольник";
            this.buttonTriangle90.UseVisualStyleBackColor = false;
            // 
            // panelFigures
            // 
            this.panelFigures.BackColor = System.Drawing.Color.LightBlue;
            this.panelFigures.Controls.Add(this.buttonCircle);
            this.panelFigures.Controls.Add(this.buttonPolygon1);
            this.panelFigures.Controls.Add(this.buttonTriangle);
            this.panelFigures.Controls.Add(this.buttonSquare);
            this.panelFigures.Location = new System.Drawing.Point(0, 195);
            this.panelFigures.Name = "panelFigures";
            this.panelFigures.Size = new System.Drawing.Size(173, 147);
            this.panelFigures.TabIndex = 13;
            // 
            // buttonPolygon2
            // 
            this.buttonPolygon2.BackColor = System.Drawing.Color.Yellow;
            this.buttonPolygon2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPolygon2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPolygon2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPolygon2.Location = new System.Drawing.Point(264, 332);
            this.buttonPolygon2.Name = "buttonPolygon2";
            this.buttonPolygon2.Size = new System.Drawing.Size(116, 28);
            this.buttonPolygon2.TabIndex = 15;
            this.buttonPolygon2.Text = "Многоугольник";
            this.buttonPolygon2.UseVisualStyleBackColor = false;
            // 
            // buttonPolygon1
            // 
            this.buttonPolygon1.BackColor = System.Drawing.Color.LightBlue;
            this.buttonPolygon1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPolygon1.BackgroundImage")));
            this.buttonPolygon1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPolygon1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPolygon1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPolygon1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPolygon1.Location = new System.Drawing.Point(63, 6);
            this.buttonPolygon1.Name = "buttonPolygon1";
            this.buttonPolygon1.Size = new System.Drawing.Size(40, 40);
            this.buttonPolygon1.TabIndex = 16;
            this.buttonPolygon1.UseVisualStyleBackColor = false;
            // 
            // buttonOval
            // 
            this.buttonOval.BackColor = System.Drawing.Color.Yellow;
            this.buttonOval.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOval.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOval.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOval.Location = new System.Drawing.Point(349, 298);
            this.buttonOval.Name = "buttonOval";
            this.buttonOval.Size = new System.Drawing.Size(116, 28);
            this.buttonOval.TabIndex = 15;
            this.buttonOval.Text = "Овал";
            this.buttonOval.UseVisualStyleBackColor = false;
            // 
            // buttonRectangle
            // 
            this.buttonRectangle.BackColor = System.Drawing.Color.Yellow;
            this.buttonRectangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRectangle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRectangle.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRectangle.Location = new System.Drawing.Point(329, 216);
            this.buttonRectangle.Name = "buttonRectangle";
            this.buttonRectangle.Size = new System.Drawing.Size(119, 28);
            this.buttonRectangle.TabIndex = 14;
            this.buttonRectangle.Text = "Прямоугольник";
            this.buttonRectangle.UseVisualStyleBackColor = false;
            // 
            // buttonRedo
            // 
            this.buttonRedo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRedo.BackgroundImage")));
            this.buttonRedo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRedo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRedo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRedo.Location = new System.Drawing.Point(254, 6);
            this.buttonRedo.Name = "buttonRedo";
            this.buttonRedo.Size = new System.Drawing.Size(28, 27);
            this.buttonRedo.TabIndex = 16;
            this.buttonRedo.UseVisualStyleBackColor = true;
            // 
            // buttonUndo
            // 
            this.buttonUndo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonUndo.BackgroundImage")));
            this.buttonUndo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUndo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUndo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUndo.Location = new System.Drawing.Point(220, 6);
            this.buttonUndo.Name = "buttonUndo";
            this.buttonUndo.Size = new System.Drawing.Size(28, 27);
            this.buttonUndo.TabIndex = 16;
            this.buttonUndo.UseVisualStyleBackColor = true;
            // 
            // buttonCircle
            // 
            this.buttonCircle.BackColor = System.Drawing.Color.LightBlue;
            this.buttonCircle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCircle.BackgroundImage")));
            this.buttonCircle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCircle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCircle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCircle.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCircle.Location = new System.Drawing.Point(12, 52);
            this.buttonCircle.Name = "buttonCircle";
            this.buttonCircle.Size = new System.Drawing.Size(40, 40);
            this.buttonCircle.TabIndex = 16;
            this.buttonCircle.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonPolygon2);
            this.Controls.Add(this.panelTools);
            this.Controls.Add(this.buttonOval);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonRectangle);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.buttonTriangle90);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWhale)).EndInit();
            this.panelTools.ResumeLayout(false);
            this.panelFigures.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UndoEdit;
        private System.Windows.Forms.ToolStripMenuItem ReduEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pencilTools;
        private System.Windows.Forms.ToolStripMenuItem brushTools;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label D;
        private System.Windows.Forms.PictureBox pictureBoxWhale;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelTools;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonPencile;
        private System.Windows.Forms.Button buttonPalette;
        private System.Windows.Forms.Button buttonEraser;
        private System.Windows.Forms.Button buttonSize4;
        private System.Windows.Forms.Button buttonSize1;
        private System.Windows.Forms.Button buttonSize3;
        private System.Windows.Forms.Button buttonSize2;
        private System.Windows.Forms.Button buttonTriangle;
        private System.Windows.Forms.Button buttonSquare;
        private System.Windows.Forms.Button buttonTriangle90;
        private System.Windows.Forms.Panel panelFigures;
        private System.Windows.Forms.Button buttonPolygon2;
        private System.Windows.Forms.Button buttonPolygon1;
        private System.Windows.Forms.Button buttonOval;
        private System.Windows.Forms.Button buttonRectangle;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonUndo;
        private System.Windows.Forms.Button buttonRedo;
        private System.Windows.Forms.Button buttonCircle;
    }
}

