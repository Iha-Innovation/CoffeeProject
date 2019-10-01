namespace CoffeeProject
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnLogin = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuButton2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bunifuButton1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(526, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 577);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(567, 375);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnLogin);
            this.panel2.Controls.Add(this.PasswordBox);
            this.panel2.Controls.Add(this.EmailBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(526, 577);
            this.panel2.TabIndex = 1;
            // 
            // BtnLogin
            // 
            this.EmailBox.AcceptsReturn = false;
            this.EmailBox.AcceptsTab = false;
            this.EmailBox.AnimationSpeed = 200;
            this.EmailBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.EmailBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.EmailBox.BackColor = System.Drawing.Color.Transparent;
            this.EmailBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EmailBox.BackgroundImage")));
            this.EmailBox.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.EmailBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.EmailBox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.EmailBox.BorderColorIdle = System.Drawing.Color.Silver;
            this.EmailBox.BorderRadius = 1;
            this.EmailBox.BorderThickness = 1;
            this.EmailBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.EmailBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmailBox.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.EmailBox.DefaultText = "";
            this.EmailBox.FillColor = System.Drawing.Color.White;
            this.EmailBox.HideSelection = true;
            this.EmailBox.IconLeft = null;
            this.EmailBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.EmailBox.IconPadding = 10;
            this.EmailBox.IconRight = null;
            this.EmailBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.EmailBox.Lines = new string[0];
            this.EmailBox.Location = new System.Drawing.Point(70, 96);
            this.EmailBox.MaxLength = 32767;
            this.EmailBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.EmailBox.Modified = false;
            this.EmailBox.Multiline = false;
            this.EmailBox.Name = "EmailBox";
            stateProperties7.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.EmailBox.OnActiveState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Empty;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.EmailBox.OnDisabledState = stateProperties8;
            stateProperties9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.EmailBox.OnHoverState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.Silver;
            stateProperties10.FillColor = System.Drawing.Color.White;
            stateProperties10.ForeColor = System.Drawing.Color.Empty;
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.EmailBox.OnIdleState = stateProperties10;
            this.EmailBox.PasswordChar = '\0';
            this.EmailBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.EmailBox.PlaceholderText = "Email";
            this.EmailBox.ReadOnly = false;
            this.EmailBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.EmailBox.SelectedText = "";
            this.EmailBox.SelectionLength = 0;
            this.EmailBox.SelectionStart = 0;
            this.EmailBox.ShortcutsEnabled = true;
            this.EmailBox.Size = new System.Drawing.Size(216, 34);
            this.EmailBox.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.EmailBox.TabIndex = 0;
            this.EmailBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.EmailBox.TextMarginBottom = 0;
            this.EmailBox.TextMarginLeft = 5;
            this.EmailBox.TextMarginTop = 0;
            this.EmailBox.TextPlaceholder = "Email";
            this.EmailBox.UseSystemPasswordChar = false;
            this.EmailBox.WordWrap = true;
            // 
            // PasswordBox
            // 
            this.PasswordBox.AcceptsReturn = false;
            this.PasswordBox.AcceptsTab = false;
            this.PasswordBox.AnimationSpeed = 200;
            this.PasswordBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.PasswordBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.PasswordBox.BackColor = System.Drawing.Color.Transparent;
            this.PasswordBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PasswordBox.BackgroundImage")));
            this.PasswordBox.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.PasswordBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.PasswordBox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.PasswordBox.BorderColorIdle = System.Drawing.Color.Silver;
            this.PasswordBox.BorderRadius = 1;
            this.PasswordBox.BorderThickness = 1;
            this.PasswordBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.PasswordBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordBox.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.PasswordBox.DefaultText = "";
            this.PasswordBox.FillColor = System.Drawing.Color.White;
            this.PasswordBox.HideSelection = true;
            this.PasswordBox.IconLeft = null;
            this.PasswordBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordBox.IconPadding = 10;
            this.PasswordBox.IconRight = null;
            this.PasswordBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordBox.Lines = new string[0];
            this.PasswordBox.Location = new System.Drawing.Point(76, 235);
            this.PasswordBox.MaxLength = 32767;
            this.PasswordBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.PasswordBox.Modified = false;
            this.PasswordBox.Multiline = false;
            this.PasswordBox.Name = "PasswordBox";
            stateProperties17.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties17.FillColor = System.Drawing.Color.Empty;
            stateProperties17.ForeColor = System.Drawing.Color.Empty;
            stateProperties17.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.PasswordBox.OnActiveState = stateProperties17;
            stateProperties18.BorderColor = System.Drawing.Color.Empty;
            stateProperties18.FillColor = System.Drawing.Color.White;
            stateProperties18.ForeColor = System.Drawing.Color.Empty;
            stateProperties18.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.PasswordBox.OnDisabledState = stateProperties18;
            stateProperties19.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties19.FillColor = System.Drawing.Color.Empty;
            stateProperties19.ForeColor = System.Drawing.Color.Empty;
            stateProperties19.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.PasswordBox.OnHoverState = stateProperties19;
            stateProperties20.BorderColor = System.Drawing.Color.Silver;
            stateProperties20.FillColor = System.Drawing.Color.White;
            stateProperties20.ForeColor = System.Drawing.Color.Empty;
            stateProperties20.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.PasswordBox.OnIdleState = stateProperties20;
            this.PasswordBox.PasswordChar = '\0';
            this.PasswordBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.PasswordBox.PlaceholderText = "Password";
            this.PasswordBox.ReadOnly = false;
            this.PasswordBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PasswordBox.SelectedText = "";
            this.PasswordBox.SelectionLength = 0;
            this.PasswordBox.SelectionStart = 0;
            this.PasswordBox.ShortcutsEnabled = true;
            this.PasswordBox.Size = new System.Drawing.Size(344, 57);
            this.PasswordBox.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.PasswordBox.TabIndex = 1;
            this.PasswordBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PasswordBox.TextMarginBottom = 0;
            this.PasswordBox.TextMarginLeft = 5;
            this.PasswordBox.TextMarginTop = 0;
            this.PasswordBox.TextPlaceholder = "Password";
            this.PasswordBox.UseSystemPasswordChar = false;
            this.PasswordBox.WordWrap = true;
            // 
            // BtnLogin
            // 
            this.BtnLogin.AllowToggling = false;
            this.BtnLogin.AnimationSpeed = 200;
            this.BtnLogin.AutoGenerateColors = false;
            this.BtnLogin.BackColor = System.Drawing.Color.Transparent;
            this.BtnLogin.BackColor1 = System.Drawing.Color.Gray;
            this.BtnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnLogin.BackgroundImage")));
            this.BtnLogin.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnLogin.ButtonText = "Se connecter";
            this.BtnLogin.ButtonTextMarginLeft = 0;
            this.BtnLogin.ColorContrastOnClick = 45;
            this.BtnLogin.ColorContrastOnHover = 45;
            this.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.BtnLogin.CustomizableEdges = borderEdges1;
            this.BtnLogin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnLogin.DisabledBorderColor = System.Drawing.Color.Empty;
            this.BtnLogin.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtnLogin.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtnLogin.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.BtnLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.BtnLogin.ForeColor = System.Drawing.Color.White;
            this.BtnLogin.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogin.IconMarginLeft = 11;
            this.BtnLogin.IconPadding = 10;
            this.BtnLogin.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogin.IdleBorderColor = System.Drawing.Color.Transparent;
            this.BtnLogin.IdleBorderRadius = 3;
            this.BtnLogin.IdleBorderThickness = 1;
            this.BtnLogin.IdleFillColor = System.Drawing.Color.Gray;
            this.BtnLogin.IdleIconLeftImage = null;
            this.BtnLogin.IdleIconRightImage = null;
            this.BtnLogin.IndicateFocus = false;
            this.BtnLogin.Location = new System.Drawing.Point(97, 217);
            this.BtnLogin.Name = "BtnLogin";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties1.BorderRadius = 3;
            stateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties1.ForeColor = System.Drawing.Color.White;
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.BtnLogin.onHoverState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 3;
            stateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.ForeColor = System.Drawing.Color.White;
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.BtnLogin.OnPressedState = stateProperties2;
            this.BtnLogin.Size = new System.Drawing.Size(152, 35);
            this.BtnLogin.TabIndex = 2;
            this.BtnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnLogin.TextMarginLeft = 0;
            this.BtnLogin.UseDefaultRadiusAndThickness = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // bunifuButton2
            // 
            this.bunifuButton2.AllowToggling = false;
            this.bunifuButton2.AnimationSpeed = 200;
            this.bunifuButton2.AutoGenerateColors = false;
            this.bunifuButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton2.BackColor1 = System.Drawing.Color.Gray;
            this.bunifuButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton2.BackgroundImage")));
            this.bunifuButton2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton2.ButtonText = "Se connecter";
            this.bunifuButton2.ButtonTextMarginLeft = 0;
            this.bunifuButton2.ColorContrastOnClick = 45;
            this.bunifuButton2.ColorContrastOnHover = 45;
            this.bunifuButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.bunifuButton2.CustomizableEdges = borderEdges2;
            this.bunifuButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton2.DisabledBorderColor = System.Drawing.Color.Empty;
            this.bunifuButton2.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton2.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton2.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.bunifuButton2.ForeColor = System.Drawing.Color.White;
            this.bunifuButton2.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuButton2.IconMarginLeft = 11;
            this.bunifuButton2.IconPadding = 10;
            this.bunifuButton2.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuButton2.IdleBorderColor = System.Drawing.Color.Transparent;
            this.bunifuButton2.IdleBorderRadius = 3;
            this.bunifuButton2.IdleBorderThickness = 1;
            this.bunifuButton2.IdleFillColor = System.Drawing.Color.Gray;
            this.bunifuButton2.IdleIconLeftImage = null;
            this.bunifuButton2.IdleIconRightImage = null;
            this.bunifuButton2.IndicateFocus = false;
            this.bunifuButton2.Location = new System.Drawing.Point(519, 0);
            this.bunifuButton2.Name = "bunifuButton2";
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties11.BorderRadius = 3;
            stateProperties11.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties11.BorderThickness = 1;
            stateProperties11.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties11.ForeColor = System.Drawing.Color.White;
            stateProperties11.IconLeftImage = null;
            stateProperties11.IconRightImage = null;
            this.bunifuButton2.onHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties12.BorderRadius = 3;
            stateProperties12.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties12.BorderThickness = 1;
            stateProperties12.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties12.ForeColor = System.Drawing.Color.White;
            stateProperties12.IconLeftImage = null;
            stateProperties12.IconRightImage = null;
            this.bunifuButton2.OnPressedState = stateProperties12;
            this.bunifuButton2.Size = new System.Drawing.Size(48, 50);
            this.bunifuButton2.TabIndex = 3;
            this.bunifuButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton2.TextMarginLeft = 0;
            this.bunifuButton2.UseDefaultRadiusAndThickness = true;
            this.bunifuButton2.Click += new System.EventHandler(this.bunifuButton2_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 577);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Login";
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton BtnLogin;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox PasswordBox;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox EmailBox;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl3;
    }
}