using Guna.UI2.WinForms;

namespace BankProjectClientSidev2
{
    partial class frmShowingClients
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pictureBox1 = new PictureBox();
            guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            showInformationsToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            upDateToolStripMenuItem = new ToolStripMenuItem();
            editPinCodeToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            errorProvider1 = new ErrorProvider(components);
            this.guna2CircleButton2 = new Guna.UI2.WinForms.Guna2CircleButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            guna2ContextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_user_groups_100;
            pictureBox1.Location = new Point(488, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(160, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // guna2CircleButton1
            // 
            guna2CircleButton1.DisabledState.BorderColor = Color.DarkGray;
            guna2CircleButton1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2CircleButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2CircleButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2CircleButton1.FillColor = Color.Crimson;
            guna2CircleButton1.Font = new Font("Segoe UI Variable Display Semib", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2CircleButton1.ForeColor = Color.White;
            guna2CircleButton1.Image = Properties.Resources.Add;
            guna2CircleButton1.ImageSize = new Size(35, 35);
            guna2CircleButton1.Location = new Point(1125, 217);
            guna2CircleButton1.Name = "guna2CircleButton1";
            guna2CircleButton1.ShadowDecoration.CustomizableEdges = customizableEdges7;
            guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CircleButton1.Size = new Size(57, 58);
            guna2CircleButton1.TabIndex = 2;
            guna2CircleButton1.Tag = "16";
            guna2CircleButton1.Click += guna2CircleButton1_Click;
            // 
            // guna2ComboBox1
            // 
            guna2ComboBox1.AutoRoundedCorners = true;
            guna2ComboBox1.BackColor = Color.Transparent;
            guna2ComboBox1.BorderRadius = 17;
            guna2ComboBox1.CustomizableEdges = customizableEdges8;
            guna2ComboBox1.DrawMode = DrawMode.OwnerDrawFixed;
            guna2ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            guna2ComboBox1.FocusedColor = Color.FromArgb(94, 148, 255);
            guna2ComboBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2ComboBox1.Font = new Font("Segoe UI", 10F);
            guna2ComboBox1.ForeColor = Color.FromArgb(68, 88, 112);
            guna2ComboBox1.ItemHeight = 30;
            guna2ComboBox1.Location = new Point(45, 239);
            guna2ComboBox1.Name = "guna2ComboBox1";
            guna2ComboBox1.ShadowDecoration.CustomizableEdges = customizableEdges9;
            guna2ComboBox1.Size = new Size(175, 36);
            guna2ComboBox1.TabIndex = 3;
            guna2ComboBox1.SelectedIndexChanged += guna2ComboBox1_SelectedIndexChanged;
            // 
            // guna2TextBox1
            // 
            guna2TextBox1.AutoRoundedCorners = true;
            guna2TextBox1.BorderRadius = 16;
            guna2TextBox1.CustomizableEdges = customizableEdges10;
            guna2TextBox1.DefaultText = "";
            guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Font = new Font("Segoe UI", 9F);
            guna2TextBox1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Location = new Point(226, 239);
            guna2TextBox1.Margin = new Padding(3, 4, 3, 4);
            guna2TextBox1.Name = "guna2TextBox1";
            guna2TextBox1.PasswordChar = '\0';
            guna2TextBox1.PlaceholderText = "";
            guna2TextBox1.SelectedText = "";
            guna2TextBox1.ShadowDecoration.CustomizableEdges = customizableEdges11;
            guna2TextBox1.Size = new Size(222, 35);
            guna2TextBox1.TabIndex = 4;
            guna2TextBox1.TextChanged += guna2TextBox1_TextChanged_1;
            guna2TextBox1.Validating += guna2TextBox1_Validating;
            // 
            // guna2ContextMenuStrip1
            // 
            guna2ContextMenuStrip1.ImageScalingSize = new Size(20, 20);
            guna2ContextMenuStrip1.Items.AddRange(new ToolStripItem[] { showInformationsToolStripMenuItem, deleteToolStripMenuItem, upDateToolStripMenuItem, editPinCodeToolStripMenuItem });
            guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            guna2ContextMenuStrip1.RenderStyle.ArrowColor = Color.FromArgb(151, 143, 255);
            guna2ContextMenuStrip1.RenderStyle.BorderColor = Color.Gainsboro;
            guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = Color.White;
            guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = Color.FromArgb(100, 88, 255);
            guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = Color.White;
            guna2ContextMenuStrip1.RenderStyle.SeparatorColor = Color.Gainsboro;
            guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            guna2ContextMenuStrip1.Size = new Size(207, 108);
            // 
            // showInformationsToolStripMenuItem
            // 
            showInformationsToolStripMenuItem.Image = Properties.Resources.icons8_info_64;
            showInformationsToolStripMenuItem.Name = "showInformationsToolStripMenuItem";
            showInformationsToolStripMenuItem.Size = new Size(206, 26);
            showInformationsToolStripMenuItem.Text = "Show Informations";
            showInformationsToolStripMenuItem.Click += showInformationsToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Image = Properties.Resources.icons8_delete_64;
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(206, 26);
            deleteToolStripMenuItem.Tag = "16";
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // upDateToolStripMenuItem
            // 
            upDateToolStripMenuItem.Image = Properties.Resources.icons8_edit_64;
            upDateToolStripMenuItem.Name = "upDateToolStripMenuItem";
            upDateToolStripMenuItem.Size = new Size(206, 26);
            upDateToolStripMenuItem.Tag = "16";
            upDateToolStripMenuItem.Text = "UpDate";
            upDateToolStripMenuItem.Click += upDateToolStripMenuItem_Click;
            // 
            // editPinCodeToolStripMenuItem
            // 
            editPinCodeToolStripMenuItem.Image = Properties.Resources.icons8_fingerprint_accepted_64;
            editPinCodeToolStripMenuItem.Name = "editPinCodeToolStripMenuItem";
            editPinCodeToolStripMenuItem.Size = new Size(206, 26);
            editPinCodeToolStripMenuItem.Tag = "16";
            editPinCodeToolStripMenuItem.Text = "Edit PinCode";
            editPinCodeToolStripMenuItem.Click += editPinCodeToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(235, 40, 79);
            label1.Location = new Point(654, 68);
            label1.Name = "label1";
            label1.Size = new Size(128, 46);
            label1.TabIndex = 39;
            label1.Text = "Clients";
            // 
            // guna2DataGridView1
            // 
            guna2DataGridView1.AllowUserToAddRows = false;
            guna2DataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = Color.White;
            guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.Crimson;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(235, 40, 79);
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            guna2DataGridView1.ColumnHeadersHeight = 30;
            guna2DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.White;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = Color.Crimson;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(255, 170, 167);
            dataGridViewCellStyle7.SelectionForeColor = Color.Crimson;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle7;
            guna2DataGridView1.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.Location = new Point(45, 291);
            guna2DataGridView1.Name = "guna2DataGridView1";
            guna2DataGridView1.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Control;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = Color.Crimson;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            guna2DataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            guna2DataGridView1.RowHeadersVisible = false;
            guna2DataGridView1.RowHeadersWidth = 51;
            guna2DataGridView1.Size = new Size(1137, 303);
            guna2DataGridView1.TabIndex = 40;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 30;
            guna2DataGridView1.ThemeStyle.ReadOnly = true;
            guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            guna2DataGridView1.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            guna2DataGridView1.ThemeStyle.RowsStyle.Height = 29;
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // guna2CircleButton2
            // 
            this.guna2CircleButton2.DisabledState.BorderColor = Color.DarkGray;
            this.guna2CircleButton2.DisabledState.CustomBorderColor = Color.DarkGray;
            this.guna2CircleButton2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            this.guna2CircleButton2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            this.guna2CircleButton2.FillColor = Color.Crimson;
            this.guna2CircleButton2.Font = new Font("Segoe UI Variable Display Semib", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.guna2CircleButton2.ForeColor = Color.White;
            this.guna2CircleButton2.Image = Properties.Resources.icons8_search_64__1_;
            this.guna2CircleButton2.ImageSize = new Size(35, 35);
            this.guna2CircleButton2.Location = new Point(1062, 217);
            this.guna2CircleButton2.Name = "guna2CircleButton2";
            this.guna2CircleButton2.ShadowDecoration.CustomizableEdges = customizableEdges12;
            this.guna2CircleButton2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton2.Size = new Size(57, 58);
            this.guna2CircleButton2.TabIndex = 41;
            this.guna2CircleButton2.Tag = "16";
            // 
            // frmShowingClients
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1210, 615);
            ContextMenuStrip = guna2ContextMenuStrip1;
            Controls.Add(this.guna2CircleButton2);
            Controls.Add(guna2DataGridView1);
            Controls.Add(label1);
            Controls.Add(guna2TextBox1);
            Controls.Add(guna2ComboBox1);
            Controls.Add(guna2CircleButton1);
            Controls.Add(pictureBox1);
            Name = "frmShowingClients";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "+";
            Load += frmShowingClients_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            guna2ContextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private ToolStripMenuItem showInformationsToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem upDateToolStripMenuItem;
        private ToolStripMenuItem editPinCodeToolStripMenuItem;
        private Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private ErrorProvider errorProvider1;
        private Guna2CircleButton guna2CircleButton2;
    }
}