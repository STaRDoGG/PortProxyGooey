﻿using System.Windows.Forms;

namespace PortProxyGooey {
    partial class SetProxy {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetProxy));
            label_ListenOn = new Label();
            label_ConnectTo = new Label();
            textBox_ConnectPort = new TextBox();
            label_ConnectPort = new Label();
            button_Set = new Button();
            label_ListenPort = new Label();
            textBox_ListenPort = new TextBox();
            label_Comment = new Label();
            textBox_Comment = new TextBox();
            label_Group = new Label();
            comboBox_Group = new ComboBox();
            comboBox_ListenOn = new ComboBox();
            textBox_ListenPortRange = new TextBox();
            lblDash = new Label();
            chkBox_ListenPortRange = new CheckBox();
            lblRequired = new Label();
            tTipSetProxy = new ToolTip(components);
            lblWSLIP = new Label();
            lblType = new Label();
            lblRangeCount = new Label();
            progBarRange = new ProgressBar();
            chkAutoComment = new CheckBox();
            comboBox_ConnectTo = new ComboBox();
            lblDupe = new Label();
            btnCancel = new Button();
            lblClone = new Label();
            SuspendLayout();
            // 
            // label_ListenOn
            // 
            resources.ApplyResources(label_ListenOn, "label_ListenOn");
            label_ListenOn.Cursor = Cursors.Help;
            label_ListenOn.ForeColor = System.Drawing.Color.FromArgb(191, 97, 106);
            label_ListenOn.Name = "label_ListenOn";
            tTipSetProxy.SetToolTip(label_ListenOn, resources.GetString("label_ListenOn.ToolTip"));
            // 
            // label_ConnectTo
            // 
            resources.ApplyResources(label_ConnectTo, "label_ConnectTo");
            label_ConnectTo.Cursor = Cursors.Help;
            label_ConnectTo.ForeColor = System.Drawing.Color.FromArgb(191, 97, 106);
            label_ConnectTo.Name = "label_ConnectTo";
            tTipSetProxy.SetToolTip(label_ConnectTo, resources.GetString("label_ConnectTo.ToolTip"));
            // 
            // textBox_ConnectPort
            // 
            textBox_ConnectPort.AutoCompleteCustomSource.AddRange(new string[] { resources.GetString("textBox_ConnectPort.AutoCompleteCustomSource"), resources.GetString("textBox_ConnectPort.AutoCompleteCustomSource1"), resources.GetString("textBox_ConnectPort.AutoCompleteCustomSource2"), resources.GetString("textBox_ConnectPort.AutoCompleteCustomSource3"), resources.GetString("textBox_ConnectPort.AutoCompleteCustomSource4"), resources.GetString("textBox_ConnectPort.AutoCompleteCustomSource5"), resources.GetString("textBox_ConnectPort.AutoCompleteCustomSource6"), resources.GetString("textBox_ConnectPort.AutoCompleteCustomSource7"), resources.GetString("textBox_ConnectPort.AutoCompleteCustomSource8"), resources.GetString("textBox_ConnectPort.AutoCompleteCustomSource9"), resources.GetString("textBox_ConnectPort.AutoCompleteCustomSource10"), resources.GetString("textBox_ConnectPort.AutoCompleteCustomSource11"), resources.GetString("textBox_ConnectPort.AutoCompleteCustomSource12"), resources.GetString("textBox_ConnectPort.AutoCompleteCustomSource13") });
            textBox_ConnectPort.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox_ConnectPort.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBox_ConnectPort.BackColor = System.Drawing.Color.FromArgb(46, 52, 64);
            textBox_ConnectPort.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(textBox_ConnectPort, "textBox_ConnectPort");
            textBox_ConnectPort.ForeColor = System.Drawing.Color.FromArgb(229, 233, 240);
            textBox_ConnectPort.Name = "textBox_ConnectPort";
            textBox_ConnectPort.TextChanged += textBox_ConnectPort_TextChanged;
            textBox_ConnectPort.KeyDown += textBox_ConnectPort_KeyDown;
            textBox_ConnectPort.KeyPress += textBox_ConnectPort_KeyPress;
            textBox_ConnectPort.MouseWheel += TextBox_ConnectPort_MouseWheel;
            // 
            // label_ConnectPort
            // 
            resources.ApplyResources(label_ConnectPort, "label_ConnectPort");
            label_ConnectPort.Cursor = Cursors.Help;
            label_ConnectPort.ForeColor = System.Drawing.Color.FromArgb(191, 97, 106);
            label_ConnectPort.Name = "label_ConnectPort";
            tTipSetProxy.SetToolTip(label_ConnectPort, resources.GetString("label_ConnectPort.ToolTip"));
            // 
            // button_Set
            // 
            button_Set.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(67, 76, 94);
            button_Set.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(59, 66, 82);
            resources.ApplyResources(button_Set, "button_Set");
            button_Set.ForeColor = System.Drawing.Color.FromArgb(235, 203, 139);
            button_Set.Name = "button_Set";
            button_Set.UseVisualStyleBackColor = true;
            button_Set.Click += button_Set_Click;
            // 
            // label_ListenPort
            // 
            resources.ApplyResources(label_ListenPort, "label_ListenPort");
            label_ListenPort.Cursor = Cursors.Help;
            label_ListenPort.ForeColor = System.Drawing.Color.FromArgb(191, 97, 106);
            label_ListenPort.Name = "label_ListenPort";
            tTipSetProxy.SetToolTip(label_ListenPort, resources.GetString("label_ListenPort.ToolTip"));
            // 
            // textBox_ListenPort
            // 
            textBox_ListenPort.AutoCompleteCustomSource.AddRange(new string[] { resources.GetString("textBox_ListenPort.AutoCompleteCustomSource"), resources.GetString("textBox_ListenPort.AutoCompleteCustomSource1"), resources.GetString("textBox_ListenPort.AutoCompleteCustomSource2"), resources.GetString("textBox_ListenPort.AutoCompleteCustomSource3"), resources.GetString("textBox_ListenPort.AutoCompleteCustomSource4"), resources.GetString("textBox_ListenPort.AutoCompleteCustomSource5"), resources.GetString("textBox_ListenPort.AutoCompleteCustomSource6"), resources.GetString("textBox_ListenPort.AutoCompleteCustomSource7"), resources.GetString("textBox_ListenPort.AutoCompleteCustomSource8"), resources.GetString("textBox_ListenPort.AutoCompleteCustomSource9"), resources.GetString("textBox_ListenPort.AutoCompleteCustomSource10"), resources.GetString("textBox_ListenPort.AutoCompleteCustomSource11"), resources.GetString("textBox_ListenPort.AutoCompleteCustomSource12"), resources.GetString("textBox_ListenPort.AutoCompleteCustomSource13") });
            textBox_ListenPort.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox_ListenPort.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBox_ListenPort.BackColor = System.Drawing.Color.FromArgb(46, 52, 64);
            textBox_ListenPort.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(textBox_ListenPort, "textBox_ListenPort");
            textBox_ListenPort.ForeColor = System.Drawing.Color.FromArgb(229, 233, 240);
            textBox_ListenPort.Name = "textBox_ListenPort";
            textBox_ListenPort.TextChanged += textBox_ListenPort_TextChanged;
            textBox_ListenPort.KeyDown += textBox_ListenPort_KeyDown;
            textBox_ListenPort.KeyPress += textBox_ListenPort_KeyPress;
            textBox_ListenPort.MouseWheel += TextBox_ListenPort_MouseWheel;
            // 
            // label_Comment
            // 
            resources.ApplyResources(label_Comment, "label_Comment");
            label_Comment.Cursor = Cursors.Help;
            label_Comment.ForeColor = System.Drawing.Color.FromArgb(216, 222, 233);
            label_Comment.Name = "label_Comment";
            tTipSetProxy.SetToolTip(label_Comment, resources.GetString("label_Comment.ToolTip"));
            // 
            // textBox_Comment
            // 
            textBox_Comment.AutoCompleteCustomSource.AddRange(new string[] { resources.GetString("textBox_Comment.AutoCompleteCustomSource"), resources.GetString("textBox_Comment.AutoCompleteCustomSource1"), resources.GetString("textBox_Comment.AutoCompleteCustomSource2"), resources.GetString("textBox_Comment.AutoCompleteCustomSource3") });
            textBox_Comment.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox_Comment.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBox_Comment.BackColor = System.Drawing.Color.FromArgb(46, 52, 64);
            textBox_Comment.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(textBox_Comment, "textBox_Comment");
            textBox_Comment.ForeColor = System.Drawing.Color.FromArgb(229, 233, 240);
            textBox_Comment.Name = "textBox_Comment";
            // 
            // label_Group
            // 
            resources.ApplyResources(label_Group, "label_Group");
            label_Group.Cursor = Cursors.Help;
            label_Group.ForeColor = System.Drawing.Color.FromArgb(216, 222, 233);
            label_Group.Name = "label_Group";
            tTipSetProxy.SetToolTip(label_Group, resources.GetString("label_Group.ToolTip"));
            // 
            // comboBox_Group
            // 
            comboBox_Group.AutoCompleteCustomSource.AddRange(new string[] { resources.GetString("comboBox_Group.AutoCompleteCustomSource"), resources.GetString("comboBox_Group.AutoCompleteCustomSource1"), resources.GetString("comboBox_Group.AutoCompleteCustomSource2"), resources.GetString("comboBox_Group.AutoCompleteCustomSource3"), resources.GetString("comboBox_Group.AutoCompleteCustomSource4"), resources.GetString("comboBox_Group.AutoCompleteCustomSource5"), resources.GetString("comboBox_Group.AutoCompleteCustomSource6") });
            comboBox_Group.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox_Group.AutoCompleteSource = AutoCompleteSource.CustomSource;
            comboBox_Group.BackColor = System.Drawing.Color.FromArgb(46, 52, 64);
            resources.ApplyResources(comboBox_Group, "comboBox_Group");
            comboBox_Group.ForeColor = System.Drawing.Color.FromArgb(229, 233, 240);
            comboBox_Group.FormattingEnabled = true;
            comboBox_Group.Name = "comboBox_Group";
            // 
            // comboBox_ListenOn
            // 
            comboBox_ListenOn.AutoCompleteCustomSource.AddRange(new string[] { resources.GetString("comboBox_ListenOn.AutoCompleteCustomSource"), resources.GetString("comboBox_ListenOn.AutoCompleteCustomSource1"), resources.GetString("comboBox_ListenOn.AutoCompleteCustomSource2"), resources.GetString("comboBox_ListenOn.AutoCompleteCustomSource3"), resources.GetString("comboBox_ListenOn.AutoCompleteCustomSource4"), resources.GetString("comboBox_ListenOn.AutoCompleteCustomSource5"), resources.GetString("comboBox_ListenOn.AutoCompleteCustomSource6"), resources.GetString("comboBox_ListenOn.AutoCompleteCustomSource7") });
            comboBox_ListenOn.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox_ListenOn.AutoCompleteSource = AutoCompleteSource.CustomSource;
            comboBox_ListenOn.BackColor = System.Drawing.Color.FromArgb(46, 52, 64);
            resources.ApplyResources(comboBox_ListenOn, "comboBox_ListenOn");
            comboBox_ListenOn.ForeColor = System.Drawing.Color.FromArgb(229, 233, 240);
            comboBox_ListenOn.FormattingEnabled = true;
            comboBox_ListenOn.Items.AddRange(new object[] { resources.GetString("comboBox_ListenOn.Items"), resources.GetString("comboBox_ListenOn.Items1"), resources.GetString("comboBox_ListenOn.Items2"), resources.GetString("comboBox_ListenOn.Items3"), resources.GetString("comboBox_ListenOn.Items4"), resources.GetString("comboBox_ListenOn.Items5"), resources.GetString("comboBox_ListenOn.Items6"), resources.GetString("comboBox_ListenOn.Items7"), resources.GetString("comboBox_ListenOn.Items8") });
            comboBox_ListenOn.Name = "comboBox_ListenOn";
            comboBox_ListenOn.TextChanged += comboBox_ListenOn_TextChanged;
            comboBox_ListenOn.KeyPress += comboBox_ListenOn_KeyPress;
            // 
            // textBox_ListenPortRange
            // 
            textBox_ListenPortRange.AutoCompleteCustomSource.AddRange(new string[] { resources.GetString("textBox_ListenPortRange.AutoCompleteCustomSource"), resources.GetString("textBox_ListenPortRange.AutoCompleteCustomSource1"), resources.GetString("textBox_ListenPortRange.AutoCompleteCustomSource2"), resources.GetString("textBox_ListenPortRange.AutoCompleteCustomSource3"), resources.GetString("textBox_ListenPortRange.AutoCompleteCustomSource4"), resources.GetString("textBox_ListenPortRange.AutoCompleteCustomSource5"), resources.GetString("textBox_ListenPortRange.AutoCompleteCustomSource6"), resources.GetString("textBox_ListenPortRange.AutoCompleteCustomSource7"), resources.GetString("textBox_ListenPortRange.AutoCompleteCustomSource8"), resources.GetString("textBox_ListenPortRange.AutoCompleteCustomSource9"), resources.GetString("textBox_ListenPortRange.AutoCompleteCustomSource10"), resources.GetString("textBox_ListenPortRange.AutoCompleteCustomSource11"), resources.GetString("textBox_ListenPortRange.AutoCompleteCustomSource12"), resources.GetString("textBox_ListenPortRange.AutoCompleteCustomSource13") });
            textBox_ListenPortRange.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox_ListenPortRange.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBox_ListenPortRange.BackColor = System.Drawing.Color.FromArgb(46, 52, 64);
            textBox_ListenPortRange.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(textBox_ListenPortRange, "textBox_ListenPortRange");
            textBox_ListenPortRange.ForeColor = System.Drawing.Color.FromArgb(229, 233, 240);
            textBox_ListenPortRange.Name = "textBox_ListenPortRange";
            tTipSetProxy.SetToolTip(textBox_ListenPortRange, resources.GetString("textBox_ListenPortRange.ToolTip"));
            textBox_ListenPortRange.TextChanged += textBox_ListenPortRange_TextChanged;
            textBox_ListenPortRange.KeyDown += textBox_ListenPortRange_KeyDown;
            textBox_ListenPortRange.KeyPress += textBox_ListenPortRange_KeyPress;
            textBox_ListenPortRange.MouseWheel += TextBox_ListenPortRange_MouseWheel;
            // 
            // lblDash
            // 
            resources.ApplyResources(lblDash, "lblDash");
            lblDash.ForeColor = System.Drawing.Color.FromArgb(216, 222, 233);
            lblDash.Name = "lblDash";
            // 
            // chkBox_ListenPortRange
            // 
            resources.ApplyResources(chkBox_ListenPortRange, "chkBox_ListenPortRange");
            chkBox_ListenPortRange.Cursor = Cursors.Help;
            chkBox_ListenPortRange.ForeColor = System.Drawing.Color.FromArgb(216, 222, 233);
            chkBox_ListenPortRange.Name = "chkBox_ListenPortRange";
            tTipSetProxy.SetToolTip(chkBox_ListenPortRange, resources.GetString("chkBox_ListenPortRange.ToolTip"));
            chkBox_ListenPortRange.UseVisualStyleBackColor = true;
            chkBox_ListenPortRange.CheckedChanged += chkBox_ListenPortRange_CheckedChanged;
            // 
            // lblRequired
            // 
            resources.ApplyResources(lblRequired, "lblRequired");
            lblRequired.Cursor = Cursors.Help;
            lblRequired.ForeColor = System.Drawing.Color.FromArgb(191, 97, 106);
            lblRequired.Name = "lblRequired";
            tTipSetProxy.SetToolTip(lblRequired, resources.GetString("lblRequired.ToolTip"));
            // 
            // tTipSetProxy
            // 
            tTipSetProxy.BackColor = System.Drawing.Color.FromArgb(235, 203, 139);
            // 
            // lblWSLIP
            // 
            resources.ApplyResources(lblWSLIP, "lblWSLIP");
            lblWSLIP.Cursor = Cursors.Hand;
            lblWSLIP.ForeColor = System.Drawing.Color.FromArgb(129, 161, 193);
            lblWSLIP.Name = "lblWSLIP";
            tTipSetProxy.SetToolTip(lblWSLIP, resources.GetString("lblWSLIP.ToolTip"));
            lblWSLIP.DoubleClick += lblWSLIP_DoubleClick;
            // 
            // lblType
            // 
            resources.ApplyResources(lblType, "lblType");
            lblType.Cursor = Cursors.Help;
            lblType.ForeColor = System.Drawing.Color.FromArgb(143, 188, 187);
            lblType.Name = "lblType";
            tTipSetProxy.SetToolTip(lblType, resources.GetString("lblType.ToolTip"));
            // 
            // lblRangeCount
            // 
            resources.ApplyResources(lblRangeCount, "lblRangeCount");
            lblRangeCount.Cursor = Cursors.Help;
            lblRangeCount.ForeColor = System.Drawing.Color.FromArgb(163, 190, 140);
            lblRangeCount.Name = "lblRangeCount";
            tTipSetProxy.SetToolTip(lblRangeCount, resources.GetString("lblRangeCount.ToolTip"));
            // 
            // progBarRange
            // 
            resources.ApplyResources(progBarRange, "progBarRange");
            progBarRange.Cursor = Cursors.Help;
            progBarRange.ForeColor = System.Drawing.Color.FromArgb(180, 142, 173);
            progBarRange.Name = "progBarRange";
            progBarRange.Step = 1;
            progBarRange.Style = ProgressBarStyle.Continuous;
            tTipSetProxy.SetToolTip(progBarRange, resources.GetString("progBarRange.ToolTip"));
            // 
            // chkAutoComment
            // 
            resources.ApplyResources(chkAutoComment, "chkAutoComment");
            chkAutoComment.Checked = true;
            chkAutoComment.CheckState = CheckState.Checked;
            chkAutoComment.Cursor = Cursors.Help;
            chkAutoComment.ForeColor = System.Drawing.Color.FromArgb(216, 222, 233);
            chkAutoComment.Name = "chkAutoComment";
            tTipSetProxy.SetToolTip(chkAutoComment, resources.GetString("chkAutoComment.ToolTip"));
            chkAutoComment.UseVisualStyleBackColor = true;
            // 
            // comboBox_ConnectTo
            // 
            comboBox_ConnectTo.AutoCompleteCustomSource.AddRange(new string[] { resources.GetString("comboBox_ConnectTo.AutoCompleteCustomSource"), resources.GetString("comboBox_ConnectTo.AutoCompleteCustomSource1"), resources.GetString("comboBox_ConnectTo.AutoCompleteCustomSource2"), resources.GetString("comboBox_ConnectTo.AutoCompleteCustomSource3"), resources.GetString("comboBox_ConnectTo.AutoCompleteCustomSource4"), resources.GetString("comboBox_ConnectTo.AutoCompleteCustomSource5"), resources.GetString("comboBox_ConnectTo.AutoCompleteCustomSource6"), resources.GetString("comboBox_ConnectTo.AutoCompleteCustomSource7") });
            comboBox_ConnectTo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox_ConnectTo.AutoCompleteSource = AutoCompleteSource.CustomSource;
            comboBox_ConnectTo.BackColor = System.Drawing.Color.FromArgb(46, 52, 64);
            resources.ApplyResources(comboBox_ConnectTo, "comboBox_ConnectTo");
            comboBox_ConnectTo.ForeColor = System.Drawing.Color.FromArgb(229, 233, 240);
            comboBox_ConnectTo.FormattingEnabled = true;
            comboBox_ConnectTo.Items.AddRange(new object[] { resources.GetString("comboBox_ConnectTo.Items"), resources.GetString("comboBox_ConnectTo.Items1"), resources.GetString("comboBox_ConnectTo.Items2"), resources.GetString("comboBox_ConnectTo.Items3"), resources.GetString("comboBox_ConnectTo.Items4"), resources.GetString("comboBox_ConnectTo.Items5"), resources.GetString("comboBox_ConnectTo.Items6"), resources.GetString("comboBox_ConnectTo.Items7"), resources.GetString("comboBox_ConnectTo.Items8") });
            comboBox_ConnectTo.Name = "comboBox_ConnectTo";
            comboBox_ConnectTo.TextChanged += comboBox_ConnectTo_TextChanged;
            comboBox_ConnectTo.KeyPress += comboBox_ConnectTo_KeyPress;
            // 
            // lblDupe
            // 
            lblDupe.BackColor = System.Drawing.Color.FromArgb(208, 135, 112);
            resources.ApplyResources(lblDupe, "lblDupe");
            lblDupe.ForeColor = System.Drawing.Color.FromArgb(235, 203, 139);
            lblDupe.Name = "lblDupe";
            // 
            // btnCancel
            // 
            btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(67, 76, 94);
            btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(59, 66, 82);
            resources.ApplyResources(btnCancel, "btnCancel");
            btnCancel.ForeColor = System.Drawing.Color.FromArgb(191, 97, 106);
            btnCancel.Name = "btnCancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblClone
            // 
            lblClone.BackColor = System.Drawing.Color.FromArgb(103, 81, 99);
            resources.ApplyResources(lblClone, "lblClone");
            lblClone.ForeColor = System.Drawing.Color.FromArgb(180, 142, 173);
            lblClone.Name = "lblClone";
            // 
            // SetProxy
            // 
            AcceptButton = button_Set;
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(46, 52, 64);
            ControlBox = false;
            Controls.Add(chkAutoComment);
            Controls.Add(lblClone);
            Controls.Add(btnCancel);
            Controls.Add(progBarRange);
            Controls.Add(lblRangeCount);
            Controls.Add(lblType);
            Controls.Add(lblDupe);
            Controls.Add(lblWSLIP);
            Controls.Add(comboBox_ConnectTo);
            Controls.Add(lblRequired);
            Controls.Add(chkBox_ListenPortRange);
            Controls.Add(lblDash);
            Controls.Add(textBox_ListenPortRange);
            Controls.Add(comboBox_ListenOn);
            Controls.Add(comboBox_Group);
            Controls.Add(label_Group);
            Controls.Add(textBox_Comment);
            Controls.Add(label_Comment);
            Controls.Add(textBox_ListenPort);
            Controls.Add(label_ListenPort);
            Controls.Add(button_Set);
            Controls.Add(label_ConnectPort);
            Controls.Add(textBox_ConnectPort);
            Controls.Add(label_ConnectTo);
            Controls.Add(label_ListenOn);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SetProxy";
            ShowInTaskbar = false;
            TopMost = true;
            FormClosing += SetProxyForm_FormClosing;
            Load += SetProxyForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_ListenOn;
        private Label label_ConnectTo;
        private TextBox textBox_ConnectPort;
        private Label label_ConnectPort;
        private Button button_Set;
        private Label label_ListenPort;
        private TextBox textBox_ListenPort;
        private Label label_Comment;
        private TextBox textBox_Comment;
        private Label label_Group;
        private ComboBox comboBox_Group;
        private ComboBox comboBox_ListenOn;
        private TextBox textBox_ListenPortRange;
        private Label lblDash;
        private CheckBox chkBox_ListenPortRange;
        private Label lblRequired;
        private ToolTip tTipSetProxy;
        private ComboBox comboBox_ConnectTo;
        private Label lblWSLIP;
        private Label lblDupe;
        private Label lblType;
        private Label lblRangeCount;
        private ProgressBar progBarRange;
        private Button btnCancel;
        private Label lblClone;
        private CheckBox chkAutoComment;
    }
}