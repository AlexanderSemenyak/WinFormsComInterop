﻿namespace SampleWindowsForms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("111");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("222");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("333");
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node2");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Node3");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Node0", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Node1");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonPressMe = new System.Windows.Forms.Button();
            this.openFormButton = new System.Windows.Forms.Button();
            this.buttonMessageBox = new System.Windows.Forms.Button();
            this.trivialCheckBox = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.simpleLabel = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButtonGroup = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxMultiline = new System.Windows.Forms.TextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.buttonBrowserForm = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.listView2 = new System.Windows.Forms.ListView();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.saveFileButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.openFileButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSplitButton3 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripProgressBar2 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.browseDialogButton = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.buttonOpenMultipleFiles = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.radioButtonGroup.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPressMe
            // 
            this.buttonPressMe.Location = new System.Drawing.Point(120, 3);
            this.buttonPressMe.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonPressMe.Name = "buttonPressMe";
            this.buttonPressMe.Size = new System.Drawing.Size(88, 27);
            this.buttonPressMe.TabIndex = 1;
            this.buttonPressMe.Text = "Press Me";
            this.buttonPressMe.UseVisualStyleBackColor = true;
            this.buttonPressMe.Click += new System.EventHandler(this.buttonPressMe_Click);
            // 
            // openFormButton
            // 
            this.openFormButton.Location = new System.Drawing.Point(7, 6);
            this.openFormButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.openFormButton.Name = "openFormButton";
            this.openFormButton.Size = new System.Drawing.Size(88, 27);
            this.openFormButton.TabIndex = 0;
            this.openFormButton.Text = "Open form";
            this.openFormButton.UseVisualStyleBackColor = true;
            this.openFormButton.Click += new System.EventHandler(this.openFormButton_Click);
            // 
            // buttonMessageBox
            // 
            this.buttonMessageBox.Location = new System.Drawing.Point(15, 39);
            this.buttonMessageBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonMessageBox.Name = "buttonMessageBox";
            this.buttonMessageBox.Size = new System.Drawing.Size(88, 27);
            this.buttonMessageBox.TabIndex = 0;
            this.buttonMessageBox.Text = "Message box";
            this.buttonMessageBox.UseVisualStyleBackColor = true;
            this.buttonMessageBox.Click += new System.EventHandler(this.buttonMessageBox_Click);
            // 
            // trivialCheckBox
            // 
            this.trivialCheckBox.AutoSize = true;
            this.trivialCheckBox.Location = new System.Drawing.Point(15, 74);
            this.trivialCheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.trivialCheckBox.Name = "trivialCheckBox";
            this.trivialCheckBox.Size = new System.Drawing.Size(75, 19);
            this.trivialCheckBox.TabIndex = 1;
            this.trivialCheckBox.Text = "Click me!";
            this.trivialCheckBox.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "item1",
            "item2",
            "item3"});
            this.comboBox1.Location = new System.Drawing.Point(15, 101);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 23);
            this.comboBox1.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(15, 250);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(233, 23);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // simpleLabel
            // 
            this.simpleLabel.AutoSize = true;
            this.simpleLabel.Location = new System.Drawing.Point(15, 281);
            this.simpleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.simpleLabel.Name = "simpleLabel";
            this.simpleLabel.Size = new System.Drawing.Size(38, 15);
            this.simpleLabel.TabIndex = 5;
            this.simpleLabel.Text = "Label here!";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Items.AddRange(new object[] {
            "item1",
            "item2",
            "item3"});
            this.listBox1.Location = new System.Drawing.Point(15, 321);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(139, 109);
            this.listBox1.TabIndex = 7;
            // 
            // listView1
            // 
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.listView1.Location = new System.Drawing.Point(315, 39);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(140, 111);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(315, 159);
            this.maskedTextBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.PasswordChar = '*';
            this.maskedTextBox1.Size = new System.Drawing.Size(116, 23);
            this.maskedTextBox1.TabIndex = 9;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(315, 190);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(140, 23);
            this.numericUpDown1.TabIndex = 10;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(315, 214);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(117, 27);
            this.progressBar1.TabIndex = 11;
            this.progressBar1.Value = 23;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(8, 23);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(70, 19);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Variant 1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(8, 46);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(70, 19);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Variant 2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButtonGroup
            // 
            this.radioButtonGroup.Controls.Add(this.radioButton2);
            this.radioButtonGroup.Controls.Add(this.radioButton1);
            this.radioButtonGroup.Location = new System.Drawing.Point(315, 249);
            this.radioButtonGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioButtonGroup.Name = "radioButtonGroup";
            this.radioButtonGroup.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioButtonGroup.Size = new System.Drawing.Size(233, 91);
            this.radioButtonGroup.TabIndex = 12;
            this.radioButtonGroup.TabStop = false;
            this.radioButtonGroup.Text = "Group of related radio buttons";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(166, 41);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 23);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "Text box";
            // 
            // textBoxMultiline
            // 
            this.textBoxMultiline.Location = new System.Drawing.Point(166, 74);
            this.textBoxMultiline.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxMultiline.Multiline = true;
            this.textBoxMultiline.Name = "textBoxMultiline";
            this.textBoxMultiline.Size = new System.Drawing.Size(116, 54);
            this.textBoxMultiline.TabIndex = 14;
            this.textBoxMultiline.Text = "Multiline textbox\r\nwhere you can have multiple lines";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(463, 38);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node2";
            treeNode1.Text = "Node2";
            treeNode2.Name = "Node3";
            treeNode2.Text = "Node3";
            treeNode3.Name = "Node0";
            treeNode3.Text = "Node0";
            treeNode4.Name = "Node1";
            treeNode4.Text = "Node1";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4});
            this.treeView1.Size = new System.Drawing.Size(140, 111);
            this.treeView1.TabIndex = 15;
            // 
            // buttonBrowserForm
            // 
            this.buttonBrowserForm.Location = new System.Drawing.Point(100, 3);
            this.buttonBrowserForm.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonBrowserForm.Name = "buttonBrowserForm";
            this.buttonBrowserForm.Size = new System.Drawing.Size(88, 27);
            this.buttonBrowserForm.TabIndex = 1;
            this.buttonBrowserForm.Text = "Flow Is Good";
            this.buttonBrowserForm.UseVisualStyleBackColor = true;
            this.buttonBrowserForm.Click += new System.EventHandler(this.buttonBrowserForm_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(4, 3);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 27);
            this.button2.TabIndex = 0;
            this.button2.Text = "Inside Flow Panel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.buttonBrowserForm);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(611, 38);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(233, 115);
            this.flowLayoutPanel1.TabIndex = 16;
            // 
            // listView2
            // 
            this.listView2.Location = new System.Drawing.Point(4, 1);
            this.listView2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(140, 111);
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(175, 177);
            this.toolStripContainer1.Location = new System.Drawing.Point(206, 89);
            this.toolStripContainer1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(175, 202);
            this.toolStripContainer1.TabIndex = 24;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Padding = new System.Windows.Forms.Padding(0, 0, 25, 25);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolStripContainer1);
            this.panel1.Controls.Add(this.listView2);
            this.panel1.Location = new System.Drawing.Point(552, 160);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 115);
            this.panel1.TabIndex = 17;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.openFormButton);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Size = new System.Drawing.Size(206, 34);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Open form";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.saveFileButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Size = new System.Drawing.Size(206, 34);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nothing here";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // saveFileButton
            // 
            this.saveFileButton.Location = new System.Drawing.Point(51, 2);
            this.saveFileButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.saveFileButton.Name = "saveFileButton";
            this.saveFileButton.Size = new System.Drawing.Size(88, 27);
            this.saveFileButton.TabIndex = 0;
            this.saveFileButton.Text = "Save file";
            this.saveFileButton.UseVisualStyleBackColor = true;
            this.saveFileButton.Click += new System.EventHandler(this.saveFileButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(555, 282);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(214, 62);
            this.tabControl1.TabIndex = 18;
            // 
            // openFileButton
            // 
            this.openFileButton.ContextMenuStrip = this.contextMenuStrip1;
            this.openFileButton.Location = new System.Drawing.Point(4, 3);
            this.openFileButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(88, 27);
            this.openFileButton.TabIndex = 0;
            this.openFileButton.Text = "Open File";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 48);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "toolStripMenuItem2";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.buttonPressMe, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.openFileButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonOpenMultipleFiles, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(555, 353);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(233, 115);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSplitButton3,
            this.toolStripDropDownButton2,
            this.toolStripSeparator1,
            this.toolStripProgressBar2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(933, 25);
            this.toolStrip1.TabIndex = 23;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(86, 22);
            this.toolStripLabel1.Text = "toolStripLabel1";
            // 
            // toolStripSplitButton3
            // 
            this.toolStripSplitButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton3.Image")));
            this.toolStripSplitButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton3.Name = "toolStripSplitButton3";
            this.toolStripSplitButton3.Size = new System.Drawing.Size(32, 22);
            this.toolStripSplitButton3.Text = "toolStripSplitButton3";
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton2.Text = "toolStripDropDownButton2";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripProgressBar2
            // 
            this.toolStripProgressBar2.Name = "toolStripProgressBar2";
            this.toolStripProgressBar2.Size = new System.Drawing.Size(100, 22);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(113, 19);
            this.toolStripStatusLabel1.Text = "ToolStripStatusLabel";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(117, 18);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1,
            this.toolStripDropDownButton1,
            this.toolStripSplitButton1,
            this.toolStripStatusLabel2,
            this.toolStripSplitButton2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 495);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(933, 24);
            this.statusStrip1.TabIndex = 22;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3});
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(13, 22);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem3.Text = "toolStripMenuItem3";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(16, 22);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(118, 19);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // toolStripSplitButton2
            // 
            this.toolStripSplitButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton2.Image")));
            this.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton2.Name = "toolStripSplitButton2";
            this.toolStripSplitButton2.Size = new System.Drawing.Size(32, 22);
            this.toolStripSplitButton2.Text = "toolStripSplitButton2";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "text";
            this.notifyIcon1.BalloonTipTitle = "title";
            this.notifyIcon1.Text = "text";
            this.notifyIcon1.Visible = true;
            // 
            // browseDialogButton
            // 
            this.browseDialogButton.Location = new System.Drawing.Point(5, 9);
            this.browseDialogButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.browseDialogButton.Name = "browseDialogButton";
            this.browseDialogButton.Size = new System.Drawing.Size(88, 27);
            this.browseDialogButton.TabIndex = 0;
            this.browseDialogButton.Text = "Browse Dlg";
            this.browseDialogButton.UseVisualStyleBackColor = true;
            this.browseDialogButton.Click += new System.EventHandler(this.browseDialogButton_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(5, 9);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(83, 19);
            this.checkBox2.TabIndex = 0;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(166, 347);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.checkBox2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.browseDialogButton);
            this.splitContainer1.Size = new System.Drawing.Size(383, 121);
            this.splitContainer1.SplitterDistance = 127;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 20;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(15, 134);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(139, 94);
            this.checkedListBox1.TabIndex = 3;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(15, 301);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(60, 15);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            // 
            // buttonOpenMultipleFiles
            // 
            this.buttonOpenMultipleFiles.Location = new System.Drawing.Point(3, 60);
            this.buttonOpenMultipleFiles.Name = "buttonOpenMultipleFiles";
            this.buttonOpenMultipleFiles.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenMultipleFiles.TabIndex = 2;
            this.buttonOpenMultipleFiles.Text = "Open Multi";
            this.buttonOpenMultipleFiles.UseVisualStyleBackColor = true;
            this.buttonOpenMultipleFiles.Click += new System.EventHandler(this.buttonOpenMultipleFiles_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.textBoxMultiline);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.radioButtonGroup);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.simpleLabel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.trivialCheckBox);
            this.Controls.Add(this.buttonMessageBox);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.radioButtonGroup.ResumeLayout(false);
            this.radioButtonGroup.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button openFormButton;
        private System.Windows.Forms.Button buttonPressMe;
        private System.Windows.Forms.Button buttonMessageBox;
        private System.Windows.Forms.CheckBox trivialCheckBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label simpleLabel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox radioButtonGroup;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxMultiline;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button buttonBrowserForm;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button saveFileButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button browseDialogButton;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton3;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar2;
        private System.Windows.Forms.Button buttonOpenMultipleFiles;
    }
}

