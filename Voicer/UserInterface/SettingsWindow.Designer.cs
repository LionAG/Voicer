namespace Voicer.UserInterface
{
    partial class SettingsWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsWindow));
            this.checkBox_EnableSayShortcut = new System.Windows.Forms.CheckBox();
            this.panel_Backdrop = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_AudioFormatSelection = new System.Windows.Forms.ComboBox();
            this.button_SelectLocation = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel_Backdrop.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox_EnableSayShortcut
            // 
            this.checkBox_EnableSayShortcut.AutoSize = true;
            this.checkBox_EnableSayShortcut.Location = new System.Drawing.Point(29, 23);
            this.checkBox_EnableSayShortcut.Name = "checkBox_EnableSayShortcut";
            this.checkBox_EnableSayShortcut.Size = new System.Drawing.Size(200, 19);
            this.checkBox_EnableSayShortcut.TabIndex = 2;
            this.checkBox_EnableSayShortcut.Text = "Enable say shortcut [Ctrl + C + S]";
            this.checkBox_EnableSayShortcut.UseVisualStyleBackColor = true;
            this.checkBox_EnableSayShortcut.CheckedChanged += new System.EventHandler(this.CheckBox_EnableSayShortcut_CheckedChanged);
            // 
            // panel_Backdrop
            // 
            this.panel_Backdrop.Controls.Add(this.tableLayoutPanel1);
            this.panel_Backdrop.Controls.Add(this.checkBox_EnableSayShortcut);
            this.panel_Backdrop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Backdrop.Location = new System.Drawing.Point(0, 0);
            this.panel_Backdrop.Name = "panel_Backdrop";
            this.panel_Backdrop.Size = new System.Drawing.Size(384, 181);
            this.panel_Backdrop.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.5F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboBox_AudioFormatSelection, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_SelectLocation, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(29, 57);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(326, 100);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 48);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select output audio format:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(4, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 49);
            this.label2.TabIndex = 5;
            this.label2.Text = "Select output audio location:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox_AudioFormatSelection
            // 
            this.comboBox_AudioFormatSelection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_AudioFormatSelection.FormattingEnabled = true;
            this.comboBox_AudioFormatSelection.Location = new System.Drawing.Point(226, 11);
            this.comboBox_AudioFormatSelection.Margin = new System.Windows.Forms.Padding(10);
            this.comboBox_AudioFormatSelection.Name = "comboBox_AudioFormatSelection";
            this.comboBox_AudioFormatSelection.Size = new System.Drawing.Size(89, 23);
            this.comboBox_AudioFormatSelection.TabIndex = 3;
            this.comboBox_AudioFormatSelection.SelectedValueChanged += new System.EventHandler(this.ComboBox_AudioFormatSelection_SelectedValueChanged);
            // 
            // button_SelectLocation
            // 
            this.button_SelectLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_SelectLocation.Location = new System.Drawing.Point(219, 53);
            this.button_SelectLocation.Name = "button_SelectLocation";
            this.button_SelectLocation.Size = new System.Drawing.Size(103, 43);
            this.button_SelectLocation.TabIndex = 6;
            this.button_SelectLocation.Text = "SELECT";
            this.button_SelectLocation.UseVisualStyleBackColor = true;
            this.button_SelectLocation.Click += new System.EventHandler(this.Button_SelectLocation_Click);
            // 
            // SettingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 181);
            this.Controls.Add(this.panel_Backdrop);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "SettingsWindow";
            this.Text = "SettingsWindow";
            this.Load += new System.EventHandler(this.SettingsWindow_Load);
            this.panel_Backdrop.ResumeLayout(false);
            this.panel_Backdrop.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CheckBox checkBox_EnableSayShortcut;
        private Panel panel_Backdrop;
        private Label label1;
        private ComboBox comboBox_AudioFormatSelection;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Button button_SelectLocation;
        private FolderBrowserDialog folderBrowserDialog1;
    }
}