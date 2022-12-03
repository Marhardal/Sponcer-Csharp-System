namespace Sponcer_Csharp_System
{
    partial class User
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
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.passtxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.usnmtxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Insertbtn = new Guna.UI.WinForms.GunaButton();
            this.Login = new Guna.UI.WinForms.GunaButton();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(9, 134);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(102, 28);
            this.bunifuCustomLabel3.TabIndex = 34;
            this.bunifuCustomLabel3.Text = "Password";
            // 
            // passtxt
            // 
            this.passtxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.passtxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.passtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passtxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.passtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passtxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.passtxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passtxt.HintForeColor = System.Drawing.Color.DimGray;
            this.passtxt.HintText = "Enter the User Password.";
            this.passtxt.isPassword = false;
            this.passtxt.LineFocusedColor = System.Drawing.Color.Blue;
            this.passtxt.LineIdleColor = System.Drawing.Color.Gray;
            this.passtxt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.passtxt.LineThickness = 3;
            this.passtxt.Location = new System.Drawing.Point(9, 168);
            this.passtxt.Margin = new System.Windows.Forms.Padding(4);
            this.passtxt.MaxLength = 32767;
            this.passtxt.Name = "passtxt";
            this.passtxt.Size = new System.Drawing.Size(426, 41);
            this.passtxt.TabIndex = 33;
            this.passtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(9, 53);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(107, 28);
            this.bunifuCustomLabel1.TabIndex = 32;
            this.bunifuCustomLabel1.Text = "Username";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI Historic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(108, 9);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(198, 38);
            this.bunifuCustomLabel2.TabIndex = 31;
            this.bunifuCustomLabel2.Text = "Enter Student";
            // 
            // usnmtxt
            // 
            this.usnmtxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.usnmtxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.usnmtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usnmtxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.usnmtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usnmtxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.usnmtxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.usnmtxt.HintForeColor = System.Drawing.Color.DimGray;
            this.usnmtxt.HintText = "Enter the User Username.";
            this.usnmtxt.isPassword = false;
            this.usnmtxt.LineFocusedColor = System.Drawing.Color.Blue;
            this.usnmtxt.LineIdleColor = System.Drawing.Color.Gray;
            this.usnmtxt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.usnmtxt.LineThickness = 3;
            this.usnmtxt.Location = new System.Drawing.Point(9, 87);
            this.usnmtxt.Margin = new System.Windows.Forms.Padding(4);
            this.usnmtxt.MaxLength = 32767;
            this.usnmtxt.Name = "usnmtxt";
            this.usnmtxt.Size = new System.Drawing.Size(426, 41);
            this.usnmtxt.TabIndex = 30;
            this.usnmtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Insertbtn
            // 
            this.Insertbtn.AnimationHoverSpeed = 0.07F;
            this.Insertbtn.AnimationSpeed = 0.03F;
            this.Insertbtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Insertbtn.BorderColor = System.Drawing.Color.Black;
            this.Insertbtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Insertbtn.FocusedColor = System.Drawing.Color.Empty;
            this.Insertbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insertbtn.ForeColor = System.Drawing.Color.White;
            this.Insertbtn.Image = null;
            this.Insertbtn.ImageSize = new System.Drawing.Size(20, 20);
            this.Insertbtn.Location = new System.Drawing.Point(132, 216);
            this.Insertbtn.Name = "Insertbtn";
            this.Insertbtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.Insertbtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Insertbtn.OnHoverForeColor = System.Drawing.Color.White;
            this.Insertbtn.OnHoverImage = null;
            this.Insertbtn.OnPressedColor = System.Drawing.Color.Black;
            this.Insertbtn.Size = new System.Drawing.Size(160, 42);
            this.Insertbtn.TabIndex = 43;
            this.Insertbtn.Text = "Register";
            this.Insertbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Insertbtn.Click += new System.EventHandler(this.Insertbtn_Click);
            // 
            // Login
            // 
            this.Login.AnimationHoverSpeed = 0.07F;
            this.Login.AnimationSpeed = 0.03F;
            this.Login.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Login.BorderColor = System.Drawing.Color.Black;
            this.Login.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Login.FocusedColor = System.Drawing.Color.Empty;
            this.Login.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.ForeColor = System.Drawing.Color.White;
            this.Login.Image = null;
            this.Login.ImageSize = new System.Drawing.Size(20, 20);
            this.Login.Location = new System.Drawing.Point(132, 216);
            this.Login.Name = "Login";
            this.Login.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.Login.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Login.OnHoverForeColor = System.Drawing.Color.White;
            this.Login.OnHoverImage = null;
            this.Login.OnPressedColor = System.Drawing.Color.Black;
            this.Login.Size = new System.Drawing.Size(160, 42);
            this.Login.TabIndex = 44;
            this.Login.Text = "Login";
            this.Login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 270);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Insertbtn);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.passtxt);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.usnmtxt);
            this.Name = "User";
            this.Text = "User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox passtxt;
        internal Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        internal Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox usnmtxt;
        internal Guna.UI.WinForms.GunaButton Insertbtn;
        internal Guna.UI.WinForms.GunaButton Login;
    }
}