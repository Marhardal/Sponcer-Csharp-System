namespace Sponcer_Csharp_System
{
    partial class Sponcer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sponcertxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Insertbtn = new Guna.UI.WinForms.GunaButton();
            this.Updatebtn = new Guna.UI.WinForms.GunaButton();
            this.SuspendLayout();
            // 
            // sponcertxt
            // 
            this.sponcertxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.sponcertxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.sponcertxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sponcertxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.sponcertxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sponcertxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.sponcertxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sponcertxt.HintForeColor = System.Drawing.Color.DimGray;
            this.sponcertxt.HintText = "Enter the Sponsers Name.";
            this.sponcertxt.isPassword = false;
            this.sponcertxt.LineFocusedColor = System.Drawing.Color.Blue;
            this.sponcertxt.LineIdleColor = System.Drawing.Color.Gray;
            this.sponcertxt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.sponcertxt.LineThickness = 3;
            this.sponcertxt.Location = new System.Drawing.Point(4, 90);
            this.sponcertxt.Margin = new System.Windows.Forms.Padding(4);
            this.sponcertxt.MaxLength = 32767;
            this.sponcertxt.Name = "sponcertxt";
            this.sponcertxt.Size = new System.Drawing.Size(426, 41);
            this.sponcertxt.TabIndex = 0;
            this.sponcertxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI Historic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(100, 10);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(216, 38);
            this.bunifuCustomLabel2.TabIndex = 4;
            this.bunifuCustomLabel2.Text = "Enter Sponcers";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(3, 55);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(156, 28);
            this.bunifuCustomLabel1.TabIndex = 5;
            this.bunifuCustomLabel1.Text = "Enter Sponcers";
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
            this.Insertbtn.Location = new System.Drawing.Point(122, 138);
            this.Insertbtn.Name = "Insertbtn";
            this.Insertbtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.Insertbtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Insertbtn.OnHoverForeColor = System.Drawing.Color.White;
            this.Insertbtn.OnHoverImage = null;
            this.Insertbtn.OnPressedColor = System.Drawing.Color.Black;
            this.Insertbtn.Size = new System.Drawing.Size(160, 42);
            this.Insertbtn.TabIndex = 6;
            this.Insertbtn.Text = "Enter Sponcer";
            this.Insertbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Insertbtn.Click += new System.EventHandler(this.Insertbtn_Click);
            // 
            // Updatebtn
            // 
            this.Updatebtn.AnimationHoverSpeed = 0.07F;
            this.Updatebtn.AnimationSpeed = 0.03F;
            this.Updatebtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Updatebtn.BorderColor = System.Drawing.Color.Black;
            this.Updatebtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Updatebtn.FocusedColor = System.Drawing.Color.Empty;
            this.Updatebtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updatebtn.ForeColor = System.Drawing.Color.White;
            this.Updatebtn.Image = null;
            this.Updatebtn.ImageSize = new System.Drawing.Size(20, 20);
            this.Updatebtn.Location = new System.Drawing.Point(122, 138);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.Updatebtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Updatebtn.OnHoverForeColor = System.Drawing.Color.White;
            this.Updatebtn.OnHoverImage = null;
            this.Updatebtn.OnPressedColor = System.Drawing.Color.Black;
            this.Updatebtn.Size = new System.Drawing.Size(160, 42);
            this.Updatebtn.TabIndex = 7;
            this.Updatebtn.Text = "Update Sponcer";
            this.Updatebtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // Sponcer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.sponcertxt);
            this.Controls.Add(this.Insertbtn);
            this.Controls.Add(this.Updatebtn);
            this.Name = "Sponcer";
            this.Size = new System.Drawing.Size(434, 191);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox sponcertxt;
        internal Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        internal Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        internal Guna.UI.WinForms.GunaButton Insertbtn;
        internal Guna.UI.WinForms.GunaButton Updatebtn;
    }
}
