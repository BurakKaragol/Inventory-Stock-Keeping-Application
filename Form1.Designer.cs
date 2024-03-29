﻿namespace Inventory_Stock_Keeping_Application
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.upperPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.maximizeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.upperPanelLabel = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.stockPage = new System.Windows.Forms.TabPage();
            this.stockPageLayout = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.editComponentButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.filterByText = new System.Windows.Forms.Label();
            this.searchFilterComboBox = new System.Windows.Forms.ComboBox();
            this.searchTextbox = new System.Windows.Forms.TextBox();
            this.removeComponentButton = new System.Windows.Forms.Button();
            this.addComponentButton = new System.Windows.Forms.Button();
            this.Headers = new System.Windows.Forms.Panel();
            this.materialGridView = new System.Windows.Forms.DataGridView();
            this.productPage = new System.Windows.Forms.TabPage();
            this.statusPage = new System.Windows.Forms.TabPage();
            this.productionPage = new System.Windows.Forms.TabPage();
            this.otherPage = new System.Windows.Forms.TabPage();
            this.exportExcellButton = new System.Windows.Forms.Button();
            this.importExcellButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.upperPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.stockPage.SuspendLayout();
            this.stockPageLayout.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Headers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialGridView)).BeginInit();
            this.otherPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 600);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // upperPanel
            // 
            this.upperPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.upperPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.upperPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.upperPanel.Controls.Add(this.button1);
            this.upperPanel.Controls.Add(this.maximizeButton);
            this.upperPanel.Controls.Add(this.closeButton);
            this.upperPanel.Controls.Add(this.upperPanelLabel);
            this.upperPanel.Location = new System.Drawing.Point(0, 0);
            this.upperPanel.Name = "upperPanel";
            this.upperPanel.Size = new System.Drawing.Size(1000, 30);
            this.upperPanel.TabIndex = 1;
            this.upperPanel.DoubleClick += new System.EventHandler(this.upperPanel_DoubleClick);
            this.upperPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.upperPanel_MouseDown);
            this.upperPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.upperPanel_MouseMove);
            this.upperPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.upperPanel_MouseUp);
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(865, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 30);
            this.button1.TabIndex = 6;
            this.button1.TabStop = false;
            this.button1.Text = "_";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // maximizeButton
            // 
            this.maximizeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.maximizeButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.maximizeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.maximizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maximizeButton.Location = new System.Drawing.Point(910, 0);
            this.maximizeButton.Name = "maximizeButton";
            this.maximizeButton.Size = new System.Drawing.Size(45, 30);
            this.maximizeButton.TabIndex = 5;
            this.maximizeButton.TabStop = false;
            this.maximizeButton.Text = "□";
            this.maximizeButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.maximizeButton.UseVisualStyleBackColor = false;
            this.maximizeButton.Click += new System.EventHandler(this.maximizeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.closeButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(955, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(45, 30);
            this.closeButton.TabIndex = 4;
            this.closeButton.TabStop = false;
            this.closeButton.Text = "x";
            this.closeButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.closeButton_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            // 
            // upperPanelLabel
            // 
            this.upperPanelLabel.AutoSize = true;
            this.upperPanelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upperPanelLabel.Location = new System.Drawing.Point(6, 6);
            this.upperPanelLabel.Margin = new System.Windows.Forms.Padding(3);
            this.upperPanelLabel.Name = "upperPanelLabel";
            this.upperPanelLabel.Size = new System.Drawing.Size(234, 17);
            this.upperPanelLabel.TabIndex = 0;
            this.upperPanelLabel.Text = "Inventory Stock Keeping Application";
            // 
            // mainPanel
            // 
            this.mainPanel.AccessibleName = "Inventory-Stock-Keeping-Application";
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.mainPanel.Controls.Add(this.tabControl);
            this.mainPanel.Location = new System.Drawing.Point(0, 30);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1000, 570);
            this.mainPanel.TabIndex = 3;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.stockPage);
            this.tabControl.Controls.Add(this.productPage);
            this.tabControl.Controls.Add(this.statusPage);
            this.tabControl.Controls.Add(this.productionPage);
            this.tabControl.Controls.Add(this.otherPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.ItemSize = new System.Drawing.Size(80, 25);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Drawing.Point(20, 5);
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1000, 570);
            this.tabControl.TabIndex = 0;
            // 
            // stockPage
            // 
            this.stockPage.Controls.Add(this.stockPageLayout);
            this.stockPage.Location = new System.Drawing.Point(4, 29);
            this.stockPage.Name = "stockPage";
            this.stockPage.Padding = new System.Windows.Forms.Padding(3);
            this.stockPage.Size = new System.Drawing.Size(992, 537);
            this.stockPage.TabIndex = 0;
            this.stockPage.Text = "STOCK";
            this.stockPage.UseVisualStyleBackColor = true;
            // 
            // stockPageLayout
            // 
            this.stockPageLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.stockPageLayout.ColumnCount = 1;
            this.stockPageLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.stockPageLayout.Controls.Add(this.panel1, 0, 0);
            this.stockPageLayout.Controls.Add(this.Headers, 0, 1);
            this.stockPageLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stockPageLayout.Location = new System.Drawing.Point(3, 3);
            this.stockPageLayout.Margin = new System.Windows.Forms.Padding(0);
            this.stockPageLayout.Name = "stockPageLayout";
            this.stockPageLayout.RowCount = 2;
            this.stockPageLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.stockPageLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.stockPageLayout.Size = new System.Drawing.Size(986, 531);
            this.stockPageLayout.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.editComponentButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.filterByText);
            this.panel1.Controls.Add(this.searchFilterComboBox);
            this.panel1.Controls.Add(this.searchTextbox);
            this.panel1.Controls.Add(this.removeComponentButton);
            this.panel1.Controls.Add(this.addComponentButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(986, 30);
            this.panel1.TabIndex = 1;
            // 
            // editComponentButton
            // 
            this.editComponentButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.editComponentButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.editComponentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editComponentButton.Location = new System.Drawing.Point(686, 0);
            this.editComponentButton.Margin = new System.Windows.Forms.Padding(0);
            this.editComponentButton.Name = "editComponentButton";
            this.editComponentButton.Size = new System.Drawing.Size(100, 30);
            this.editComponentButton.TabIndex = 6;
            this.editComponentButton.TabStop = false;
            this.editComponentButton.Text = "Edit";
            this.editComponentButton.UseVisualStyleBackColor = false;
            this.editComponentButton.Click += new System.EventHandler(this.editComponentButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Search:";
            // 
            // filterByText
            // 
            this.filterByText.AutoSize = true;
            this.filterByText.Location = new System.Drawing.Point(5, 7);
            this.filterByText.Name = "filterByText";
            this.filterByText.Size = new System.Drawing.Size(62, 17);
            this.filterByText.TabIndex = 4;
            this.filterByText.Text = "Filter by:";
            // 
            // searchFilterComboBox
            // 
            this.searchFilterComboBox.FormattingEnabled = true;
            this.searchFilterComboBox.Items.AddRange(new object[] {
            "Stock Code",
            "Name",
            "Type",
            "From",
            "Date"});
            this.searchFilterComboBox.Location = new System.Drawing.Point(73, 3);
            this.searchFilterComboBox.Name = "searchFilterComboBox";
            this.searchFilterComboBox.Size = new System.Drawing.Size(120, 24);
            this.searchFilterComboBox.TabIndex = 3;
            this.searchFilterComboBox.Text = "Name";
            this.searchFilterComboBox.SelectedIndexChanged += new System.EventHandler(this.searchFilterComboBox_SelectedIndexChanged);
            // 
            // searchTextbox
            // 
            this.searchTextbox.Location = new System.Drawing.Point(272, 4);
            this.searchTextbox.Name = "searchTextbox";
            this.searchTextbox.Size = new System.Drawing.Size(400, 23);
            this.searchTextbox.TabIndex = 2;
            this.searchTextbox.TextChanged += new System.EventHandler(this.searchTextbox_TextChanged);
            // 
            // removeComponentButton
            // 
            this.removeComponentButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.removeComponentButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.removeComponentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeComponentButton.Location = new System.Drawing.Point(786, 0);
            this.removeComponentButton.Margin = new System.Windows.Forms.Padding(0);
            this.removeComponentButton.Name = "removeComponentButton";
            this.removeComponentButton.Size = new System.Drawing.Size(100, 30);
            this.removeComponentButton.TabIndex = 1;
            this.removeComponentButton.TabStop = false;
            this.removeComponentButton.Text = "Remove";
            this.removeComponentButton.UseVisualStyleBackColor = false;
            this.removeComponentButton.Click += new System.EventHandler(this.removeComponentButton_Click);
            // 
            // addComponentButton
            // 
            this.addComponentButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.addComponentButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.addComponentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addComponentButton.Location = new System.Drawing.Point(886, 0);
            this.addComponentButton.Margin = new System.Windows.Forms.Padding(0);
            this.addComponentButton.Name = "addComponentButton";
            this.addComponentButton.Size = new System.Drawing.Size(100, 30);
            this.addComponentButton.TabIndex = 0;
            this.addComponentButton.TabStop = false;
            this.addComponentButton.Text = "Add";
            this.addComponentButton.UseVisualStyleBackColor = false;
            this.addComponentButton.Click += new System.EventHandler(this.addComponentButton_Click);
            // 
            // Headers
            // 
            this.Headers.Controls.Add(this.materialGridView);
            this.Headers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Headers.Location = new System.Drawing.Point(0, 30);
            this.Headers.Margin = new System.Windows.Forms.Padding(0);
            this.Headers.Name = "Headers";
            this.Headers.Size = new System.Drawing.Size(986, 501);
            this.Headers.TabIndex = 2;
            // 
            // materialGridView
            // 
            this.materialGridView.AllowUserToAddRows = false;
            this.materialGridView.AllowUserToDeleteRows = false;
            this.materialGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.materialGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialGridView.Location = new System.Drawing.Point(0, 0);
            this.materialGridView.Name = "materialGridView";
            this.materialGridView.Size = new System.Drawing.Size(986, 501);
            this.materialGridView.TabIndex = 0;
            // 
            // productPage
            // 
            this.productPage.Location = new System.Drawing.Point(4, 29);
            this.productPage.Name = "productPage";
            this.productPage.Padding = new System.Windows.Forms.Padding(3);
            this.productPage.Size = new System.Drawing.Size(992, 537);
            this.productPage.TabIndex = 1;
            this.productPage.Text = "PRODUCT";
            this.productPage.UseVisualStyleBackColor = true;
            // 
            // statusPage
            // 
            this.statusPage.Location = new System.Drawing.Point(4, 29);
            this.statusPage.Name = "statusPage";
            this.statusPage.Padding = new System.Windows.Forms.Padding(3);
            this.statusPage.Size = new System.Drawing.Size(992, 537);
            this.statusPage.TabIndex = 2;
            this.statusPage.Text = "STATUS";
            this.statusPage.UseVisualStyleBackColor = true;
            // 
            // productionPage
            // 
            this.productionPage.Location = new System.Drawing.Point(4, 29);
            this.productionPage.Name = "productionPage";
            this.productionPage.Padding = new System.Windows.Forms.Padding(3);
            this.productionPage.Size = new System.Drawing.Size(992, 537);
            this.productionPage.TabIndex = 3;
            this.productionPage.Text = "PRODUCTION";
            this.productionPage.UseVisualStyleBackColor = true;
            // 
            // otherPage
            // 
            this.otherPage.Controls.Add(this.exportExcellButton);
            this.otherPage.Controls.Add(this.importExcellButton);
            this.otherPage.Location = new System.Drawing.Point(4, 29);
            this.otherPage.Name = "otherPage";
            this.otherPage.Padding = new System.Windows.Forms.Padding(3);
            this.otherPage.Size = new System.Drawing.Size(992, 537);
            this.otherPage.TabIndex = 4;
            this.otherPage.Text = "OTHER";
            this.otherPage.UseVisualStyleBackColor = true;
            // 
            // exportExcellButton
            // 
            this.exportExcellButton.Location = new System.Drawing.Point(535, 141);
            this.exportExcellButton.Name = "exportExcellButton";
            this.exportExcellButton.Size = new System.Drawing.Size(335, 256);
            this.exportExcellButton.TabIndex = 1;
            this.exportExcellButton.Text = "export";
            this.exportExcellButton.UseVisualStyleBackColor = true;
            this.exportExcellButton.Click += new System.EventHandler(this.exportExcellButton_Click);
            // 
            // importExcellButton
            // 
            this.importExcellButton.Location = new System.Drawing.Point(100, 141);
            this.importExcellButton.Name = "importExcellButton";
            this.importExcellButton.Size = new System.Drawing.Size(373, 256);
            this.importExcellButton.TabIndex = 0;
            this.importExcellButton.Text = "import";
            this.importExcellButton.UseVisualStyleBackColor = true;
            this.importExcellButton.Click += new System.EventHandler(this.importExcellButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.upperPanel);
            this.Controls.Add(this.splitter1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Form1";
            this.Text = "Inventory Stock Keeping Application";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.upperPanel.ResumeLayout(false);
            this.upperPanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.stockPage.ResumeLayout(false);
            this.stockPageLayout.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Headers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.materialGridView)).EndInit();
            this.otherPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel upperPanel;
        private System.Windows.Forms.Label upperPanelLabel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button maximizeButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage stockPage;
        private System.Windows.Forms.TableLayoutPanel stockPageLayout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button editComponentButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label filterByText;
        private System.Windows.Forms.ComboBox searchFilterComboBox;
        private System.Windows.Forms.TextBox searchTextbox;
        private System.Windows.Forms.Button removeComponentButton;
        private System.Windows.Forms.Button addComponentButton;
        private System.Windows.Forms.TabPage productPage;
        private System.Windows.Forms.TabPage statusPage;
        private System.Windows.Forms.TabPage productionPage;
        private System.Windows.Forms.TabPage otherPage;
        private System.Windows.Forms.Panel Headers;
        private System.Windows.Forms.Button exportExcellButton;
        private System.Windows.Forms.Button importExcellButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.DataGridView materialGridView;
    }
}

