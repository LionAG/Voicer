namespace Voicer.UserInterface
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.panel_Backdrop = new System.Windows.Forms.Panel();
            this.richTextBox_InputText = new System.Windows.Forms.RichTextBox();
            this.panel_SyntheiszerStatus = new System.Windows.Forms.Panel();
            this.panel_SynthesizerInfo = new System.Windows.Forms.Panel();
            this.label_SynthesizerState = new System.Windows.Forms.Label();
            this.label_Version = new System.Windows.Forms.Label();
            this.panel_SyntheiszerStateSettings = new System.Windows.Forms.Panel();
            this.tableLayoutPanel_SynthesizerSettings = new System.Windows.Forms.TableLayoutPanel();
            this.numericUpDown_SpeakingVolume = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_VoiceSelection = new System.Windows.Forms.ComboBox();
            this.numericUpDown_SpeakingRate = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel_SynthesizerControls = new System.Windows.Forms.FlowLayoutPanel();
            this.button_Speak = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Pause = new System.Windows.Forms.Button();
            this.button_Resume = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToWAVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearCtrlNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog_LoadFileSelection = new System.Windows.Forms.OpenFileDialog();
            this.panel_Backdrop.SuspendLayout();
            this.panel_SyntheiszerStatus.SuspendLayout();
            this.panel_SynthesizerInfo.SuspendLayout();
            this.panel_SyntheiszerStateSettings.SuspendLayout();
            this.tableLayoutPanel_SynthesizerSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SpeakingVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SpeakingRate)).BeginInit();
            this.flowLayoutPanel_SynthesizerControls.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Backdrop
            // 
            this.panel_Backdrop.Controls.Add(this.richTextBox_InputText);
            this.panel_Backdrop.Controls.Add(this.panel_SyntheiszerStatus);
            this.panel_Backdrop.Controls.Add(this.menuStrip1);
            this.panel_Backdrop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Backdrop.Location = new System.Drawing.Point(0, 0);
            this.panel_Backdrop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_Backdrop.Name = "panel_Backdrop";
            this.panel_Backdrop.Size = new System.Drawing.Size(917, 601);
            this.panel_Backdrop.TabIndex = 0;
            // 
            // richTextBox_InputText
            // 
            this.richTextBox_InputText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_InputText.EnableAutoDragDrop = true;
            this.richTextBox_InputText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox_InputText.Location = new System.Drawing.Point(0, 30);
            this.richTextBox_InputText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBox_InputText.Name = "richTextBox_InputText";
            this.richTextBox_InputText.Size = new System.Drawing.Size(538, 571);
            this.richTextBox_InputText.TabIndex = 16;
            this.richTextBox_InputText.Text = "";
            // 
            // panel_SyntheiszerStatus
            // 
            this.panel_SyntheiszerStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_SyntheiszerStatus.Controls.Add(this.panel_SynthesizerInfo);
            this.panel_SyntheiszerStatus.Controls.Add(this.panel_SyntheiszerStateSettings);
            this.panel_SyntheiszerStatus.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_SyntheiszerStatus.Location = new System.Drawing.Point(538, 30);
            this.panel_SyntheiszerStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_SyntheiszerStatus.Name = "panel_SyntheiszerStatus";
            this.panel_SyntheiszerStatus.Size = new System.Drawing.Size(379, 571);
            this.panel_SyntheiszerStatus.TabIndex = 15;
            // 
            // panel_SynthesizerInfo
            // 
            this.panel_SynthesizerInfo.Controls.Add(this.label_SynthesizerState);
            this.panel_SynthesizerInfo.Controls.Add(this.label_Version);
            this.panel_SynthesizerInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_SynthesizerInfo.Location = new System.Drawing.Point(0, 352);
            this.panel_SynthesizerInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_SynthesizerInfo.Name = "panel_SynthesizerInfo";
            this.panel_SynthesizerInfo.Size = new System.Drawing.Size(377, 217);
            this.panel_SynthesizerInfo.TabIndex = 18;
            // 
            // label_SynthesizerState
            // 
            this.label_SynthesizerState.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_SynthesizerState.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_SynthesizerState.Location = new System.Drawing.Point(0, 0);
            this.label_SynthesizerState.Name = "label_SynthesizerState";
            this.label_SynthesizerState.Size = new System.Drawing.Size(377, 167);
            this.label_SynthesizerState.TabIndex = 15;
            this.label_SynthesizerState.Text = "READY";
            this.label_SynthesizerState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Version
            // 
            this.label_Version.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Version.AutoSize = true;
            this.label_Version.Location = new System.Drawing.Point(147, 187);
            this.label_Version.Name = "label_Version";
            this.label_Version.Size = new System.Drawing.Size(91, 20);
            this.label_Version.TabIndex = 16;
            this.label_Version.Text = "Voicer v1.0.0";
            // 
            // panel_SyntheiszerStateSettings
            // 
            this.panel_SyntheiszerStateSettings.Controls.Add(this.tableLayoutPanel_SynthesizerSettings);
            this.panel_SyntheiszerStateSettings.Controls.Add(this.flowLayoutPanel_SynthesizerControls);
            this.panel_SyntheiszerStateSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_SyntheiszerStateSettings.Location = new System.Drawing.Point(0, 0);
            this.panel_SyntheiszerStateSettings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_SyntheiszerStateSettings.Name = "panel_SyntheiszerStateSettings";
            this.panel_SyntheiszerStateSettings.Size = new System.Drawing.Size(377, 373);
            this.panel_SyntheiszerStateSettings.TabIndex = 17;
            // 
            // tableLayoutPanel_SynthesizerSettings
            // 
            this.tableLayoutPanel_SynthesizerSettings.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel_SynthesizerSettings.ColumnCount = 2;
            this.tableLayoutPanel_SynthesizerSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_SynthesizerSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_SynthesizerSettings.Controls.Add(this.numericUpDown_SpeakingVolume, 1, 2);
            this.tableLayoutPanel_SynthesizerSettings.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel_SynthesizerSettings.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel_SynthesizerSettings.Controls.Add(this.comboBox_VoiceSelection, 1, 0);
            this.tableLayoutPanel_SynthesizerSettings.Controls.Add(this.numericUpDown_SpeakingRate, 1, 1);
            this.tableLayoutPanel_SynthesizerSettings.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel_SynthesizerSettings.Location = new System.Drawing.Point(10, 39);
            this.tableLayoutPanel_SynthesizerSettings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel_SynthesizerSettings.Name = "tableLayoutPanel_SynthesizerSettings";
            this.tableLayoutPanel_SynthesizerSettings.RowCount = 3;
            this.tableLayoutPanel_SynthesizerSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_SynthesizerSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_SynthesizerSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_SynthesizerSettings.Size = new System.Drawing.Size(358, 135);
            this.tableLayoutPanel_SynthesizerSettings.TabIndex = 16;
            // 
            // numericUpDown_SpeakingVolume
            // 
            this.numericUpDown_SpeakingVolume.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDown_SpeakingVolume.Location = new System.Drawing.Point(147, 93);
            this.numericUpDown_SpeakingVolume.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDown_SpeakingVolume.Name = "numericUpDown_SpeakingVolume";
            this.numericUpDown_SpeakingVolume.Size = new System.Drawing.Size(207, 27);
            this.numericUpDown_SpeakingVolume.TabIndex = 5;
            this.numericUpDown_SpeakingVolume.ValueChanged += new System.EventHandler(this.NumericUpDown_SpeakingVolume_ValueChanged);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Voice selection:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(4, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 45);
            this.label3.TabIndex = 3;
            this.label3.Text = "Speaking volume:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox_VoiceSelection
            // 
            this.comboBox_VoiceSelection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_VoiceSelection.FormattingEnabled = true;
            this.comboBox_VoiceSelection.Location = new System.Drawing.Point(147, 5);
            this.comboBox_VoiceSelection.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox_VoiceSelection.Name = "comboBox_VoiceSelection";
            this.comboBox_VoiceSelection.Size = new System.Drawing.Size(207, 28);
            this.comboBox_VoiceSelection.TabIndex = 1;
            this.comboBox_VoiceSelection.SelectedValueChanged += new System.EventHandler(this.ComboBox_VoiceSelection_SelectedValueChanged);
            // 
            // numericUpDown_SpeakingRate
            // 
            this.numericUpDown_SpeakingRate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDown_SpeakingRate.Location = new System.Drawing.Point(147, 49);
            this.numericUpDown_SpeakingRate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDown_SpeakingRate.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_SpeakingRate.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.numericUpDown_SpeakingRate.Name = "numericUpDown_SpeakingRate";
            this.numericUpDown_SpeakingRate.Size = new System.Drawing.Size(207, 27);
            this.numericUpDown_SpeakingRate.TabIndex = 4;
            this.numericUpDown_SpeakingRate.ValueChanged += new System.EventHandler(this.NumericUpDown_SpeakingRate_ValueChanged);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(4, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 43);
            this.label2.TabIndex = 2;
            this.label2.Text = "Speaking speed:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel_SynthesizerControls
            // 
            this.flowLayoutPanel_SynthesizerControls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel_SynthesizerControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel_SynthesizerControls.Controls.Add(this.button_Speak);
            this.flowLayoutPanel_SynthesizerControls.Controls.Add(this.button_Cancel);
            this.flowLayoutPanel_SynthesizerControls.Controls.Add(this.button_Pause);
            this.flowLayoutPanel_SynthesizerControls.Controls.Add(this.button_Resume);
            this.flowLayoutPanel_SynthesizerControls.Location = new System.Drawing.Point(79, 203);
            this.flowLayoutPanel_SynthesizerControls.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanel_SynthesizerControls.Name = "flowLayoutPanel_SynthesizerControls";
            this.flowLayoutPanel_SynthesizerControls.Size = new System.Drawing.Size(219, 119);
            this.flowLayoutPanel_SynthesizerControls.TabIndex = 0;
            // 
            // button_Speak
            // 
            this.button_Speak.Location = new System.Drawing.Point(10, 12);
            this.button_Speak.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.button_Speak.Name = "button_Speak";
            this.button_Speak.Size = new System.Drawing.Size(86, 31);
            this.button_Speak.TabIndex = 0;
            this.button_Speak.Text = "SPEAK";
            this.button_Speak.UseVisualStyleBackColor = true;
            this.button_Speak.Click += new System.EventHandler(this.Button_Speak_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(116, 12);
            this.button_Cancel.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(86, 31);
            this.button_Cancel.TabIndex = 3;
            this.button_Cancel.Text = "CANCEL";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // button_Pause
            // 
            this.button_Pause.Location = new System.Drawing.Point(10, 67);
            this.button_Pause.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.button_Pause.Name = "button_Pause";
            this.button_Pause.Size = new System.Drawing.Size(86, 31);
            this.button_Pause.TabIndex = 1;
            this.button_Pause.Text = "PAUSE";
            this.button_Pause.UseVisualStyleBackColor = true;
            this.button_Pause.Click += new System.EventHandler(this.Button_Pause_Click);
            // 
            // button_Resume
            // 
            this.button_Resume.Location = new System.Drawing.Point(116, 67);
            this.button_Resume.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.button_Resume.Name = "button_Resume";
            this.button_Resume.Size = new System.Drawing.Size(86, 31);
            this.button_Resume.TabIndex = 2;
            this.button_Resume.Text = "RESUME";
            this.button_Resume.UseVisualStyleBackColor = true;
            this.button_Resume.Click += new System.EventHandler(this.Button_Resume_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(917, 30);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadTextToolStripMenuItem,
            this.saveToWAVToolStripMenuItem,
            this.clearCtrlNToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadTextToolStripMenuItem
            // 
            this.loadTextToolStripMenuItem.Name = "loadTextToolStripMenuItem";
            this.loadTextToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.loadTextToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.loadTextToolStripMenuItem.Text = "Load Text File";
            this.loadTextToolStripMenuItem.Click += new System.EventHandler(this.LoadTextToolStripMenuItem_Click);
            // 
            // saveToWAVToolStripMenuItem
            // 
            this.saveToWAVToolStripMenuItem.Name = "saveToWAVToolStripMenuItem";
            this.saveToWAVToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.saveToWAVToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.saveToWAVToolStripMenuItem.Text = "Generate Audio";
            this.saveToWAVToolStripMenuItem.Click += new System.EventHandler(this.SaveToWAVToolStripMenuItem_Click);
            // 
            // clearCtrlNToolStripMenuItem
            // 
            this.clearCtrlNToolStripMenuItem.Name = "clearCtrlNToolStripMenuItem";
            this.clearCtrlNToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.clearCtrlNToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.clearCtrlNToolStripMenuItem.Text = "Clear";
            this.clearCtrlNToolStripMenuItem.Click += new System.EventHandler(this.ClearCtrlNToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.SettingsToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.closeToolStripMenuItem.Text = "Exit";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // openFileDialog_LoadFileSelection
            // 
            this.openFileDialog_LoadFileSelection.Filter = "Text files|*.txt";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 601);
            this.Controls.Add(this.panel_Backdrop);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MinimumSize = new System.Drawing.Size(932, 638);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.panel_Backdrop.ResumeLayout(false);
            this.panel_Backdrop.PerformLayout();
            this.panel_SyntheiszerStatus.ResumeLayout(false);
            this.panel_SynthesizerInfo.ResumeLayout(false);
            this.panel_SynthesizerInfo.PerformLayout();
            this.panel_SyntheiszerStateSettings.ResumeLayout(false);
            this.tableLayoutPanel_SynthesizerSettings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SpeakingVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SpeakingRate)).EndInit();
            this.flowLayoutPanel_SynthesizerControls.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel_Backdrop;
        private FlowLayoutPanel flowLayoutPanel_SynthesizerControls;
        private Label label1;
        private ComboBox comboBox_VoiceSelection;
        private Label label3;
        private Label label2;
        private NumericUpDown numericUpDown_SpeakingVolume;
        private NumericUpDown numericUpDown_SpeakingRate;
        private Button button_Speak;
        private Button button_Pause;
        private Button button_Resume;
        private Panel panel_SyntheiszerStatus;
        private Label label_SynthesizerState;
        private Label label_Version;
        private TableLayoutPanel tableLayoutPanel_SynthesizerSettings;
        private Panel panel_SynthesizerInfo;
        private Panel panel_SyntheiszerStateSettings;
        private RichTextBox richTextBox_InputText;
        private Button button_Cancel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem loadTextToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private OpenFileDialog openFileDialog_LoadFileSelection;
        private ToolStripMenuItem saveToWAVToolStripMenuItem;
        private ToolStripMenuItem clearCtrlNToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
    }
}