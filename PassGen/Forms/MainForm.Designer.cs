namespace PassGen.Forms {
	partial class MainForm {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.chkLettersUpper = new System.Windows.Forms.CheckBox();
			this.chkLettersLower = new System.Windows.Forms.CheckBox();
			this.chkHexLettersUpper = new System.Windows.Forms.CheckBox();
			this.chkHexLettersLower = new System.Windows.Forms.CheckBox();
			this.chkDigits = new System.Windows.Forms.CheckBox();
			this.chkSpaces = new System.Windows.Forms.CheckBox();
			this.chkSymbols = new System.Windows.Forms.CheckBox();
			this.txtSymbols = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtLength = new System.Windows.Forms.TextBox();
			this.btnGenerate = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnClipboard = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(3, 5);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.ReadOnly = true;
			this.txtPassword.Size = new System.Drawing.Size(372, 21);
			this.txtPassword.TabIndex = 0;
			// 
			// chkLettersUpper
			// 
			this.chkLettersUpper.AutoSize = true;
			this.chkLettersUpper.Checked = true;
			this.chkLettersUpper.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkLettersUpper.Location = new System.Drawing.Point(3, 32);
			this.chkLettersUpper.Name = "chkLettersUpper";
			this.chkLettersUpper.Size = new System.Drawing.Size(88, 17);
			this.chkLettersUpper.TabIndex = 1;
			this.chkLettersUpper.Text = "Letters (A-Z)";
			this.chkLettersUpper.UseVisualStyleBackColor = true;
			this.chkLettersUpper.CheckedChanged += new System.EventHandler(this.chkLettersUpper_CheckedChanged);
			// 
			// chkLettersLower
			// 
			this.chkLettersLower.AutoSize = true;
			this.chkLettersLower.Checked = true;
			this.chkLettersLower.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkLettersLower.Location = new System.Drawing.Point(3, 55);
			this.chkLettersLower.Name = "chkLettersLower";
			this.chkLettersLower.Size = new System.Drawing.Size(86, 17);
			this.chkLettersLower.TabIndex = 2;
			this.chkLettersLower.Text = "Letters (a-z)";
			this.chkLettersLower.UseVisualStyleBackColor = true;
			this.chkLettersLower.CheckedChanged += new System.EventHandler(this.chkLettersLower_CheckedChanged);
			// 
			// chkHexLettersUpper
			// 
			this.chkHexLettersUpper.AutoSize = true;
			this.chkHexLettersUpper.Location = new System.Drawing.Point(3, 78);
			this.chkHexLettersUpper.Name = "chkHexLettersUpper";
			this.chkHexLettersUpper.Size = new System.Drawing.Size(110, 17);
			this.chkHexLettersUpper.TabIndex = 3;
			this.chkHexLettersUpper.Text = "Hex Letters (A-F)";
			this.chkHexLettersUpper.UseVisualStyleBackColor = true;
			this.chkHexLettersUpper.CheckedChanged += new System.EventHandler(this.chkHexLettersUpper_CheckedChanged);
			// 
			// chkHexLettersLower
			// 
			this.chkHexLettersLower.AutoSize = true;
			this.chkHexLettersLower.Location = new System.Drawing.Point(3, 101);
			this.chkHexLettersLower.Name = "chkHexLettersLower";
			this.chkHexLettersLower.Size = new System.Drawing.Size(107, 17);
			this.chkHexLettersLower.TabIndex = 4;
			this.chkHexLettersLower.Text = "Hex Letters (a-f)";
			this.chkHexLettersLower.UseVisualStyleBackColor = true;
			this.chkHexLettersLower.CheckedChanged += new System.EventHandler(this.chkHexLettersLower_CheckedChanged);
			// 
			// chkDigits
			// 
			this.chkDigits.AutoSize = true;
			this.chkDigits.Checked = true;
			this.chkDigits.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkDigits.Location = new System.Drawing.Point(197, 55);
			this.chkDigits.Name = "chkDigits";
			this.chkDigits.Size = new System.Drawing.Size(79, 17);
			this.chkDigits.TabIndex = 5;
			this.chkDigits.Text = "Digits (0-9)";
			this.chkDigits.UseVisualStyleBackColor = true;
			this.chkDigits.CheckedChanged += new System.EventHandler(this.chkDigits_CheckedChanged);
			// 
			// chkSpaces
			// 
			this.chkSpaces.AutoSize = true;
			this.chkSpaces.Location = new System.Drawing.Point(197, 78);
			this.chkSpaces.Name = "chkSpaces";
			this.chkSpaces.Size = new System.Drawing.Size(60, 17);
			this.chkSpaces.TabIndex = 6;
			this.chkSpaces.Text = "Spaces";
			this.chkSpaces.UseVisualStyleBackColor = true;
			this.chkSpaces.CheckedChanged += new System.EventHandler(this.chkSpaces_CheckedChanged);
			// 
			// chkSymbols
			// 
			this.chkSymbols.AutoSize = true;
			this.chkSymbols.Location = new System.Drawing.Point(197, 32);
			this.chkSymbols.Name = "chkSymbols";
			this.chkSymbols.Size = new System.Drawing.Size(69, 17);
			this.chkSymbols.TabIndex = 7;
			this.chkSymbols.Text = "Symbols:";
			this.chkSymbols.UseVisualStyleBackColor = true;
			this.chkSymbols.CheckedChanged += new System.EventHandler(this.chkSymbols_CheckedChanged);
			// 
			// txtSymbols
			// 
			this.txtSymbols.Location = new System.Drawing.Point(272, 30);
			this.txtSymbols.Name = "txtSymbols";
			this.txtSymbols.Size = new System.Drawing.Size(103, 21);
			this.txtSymbols.TabIndex = 8;
			this.txtSymbols.Text = "!@#$%^&*_-+~";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(215, 102);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 13);
			this.label1.TabIndex = 9;
			this.label1.Text = "Length:";
			// 
			// txtLength
			// 
			this.txtLength.Location = new System.Drawing.Point(272, 99);
			this.txtLength.MaxLength = 0;
			this.txtLength.Name = "txtLength";
			this.txtLength.Size = new System.Drawing.Size(103, 21);
			this.txtLength.TabIndex = 10;
			this.txtLength.Text = "10";
			this.txtLength.TextChanged += new System.EventHandler(this.txtLength_TextChanged);
			// 
			// btnGenerate
			// 
			this.btnGenerate.Enabled = false;
			this.btnGenerate.Location = new System.Drawing.Point(3, 143);
			this.btnGenerate.Name = "btnGenerate";
			this.btnGenerate.Size = new System.Drawing.Size(75, 23);
			this.btnGenerate.TabIndex = 11;
			this.btnGenerate.Text = "G&enerate";
			this.btnGenerate.UseVisualStyleBackColor = true;
			this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(300, 143);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(75, 23);
			this.btnExit.TabIndex = 12;
			this.btnExit.Text = "E&xit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnClipboard
			// 
			this.btnClipboard.Enabled = false;
			this.btnClipboard.Location = new System.Drawing.Point(84, 143);
			this.btnClipboard.Name = "btnClipboard";
			this.btnClipboard.Size = new System.Drawing.Size(75, 23);
			this.btnClipboard.TabIndex = 13;
			this.btnClipboard.Text = "&Clipboard";
			this.btnClipboard.UseVisualStyleBackColor = true;
			this.btnClipboard.Click += new System.EventHandler(this.btnClipboard_Click);
			// 
			// MainForm
			// 
			this.AcceptButton = this.btnGenerate;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(378, 168);
			this.Controls.Add(this.btnClipboard);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnGenerate);
			this.Controls.Add(this.txtLength);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtSymbols);
			this.Controls.Add(this.chkSymbols);
			this.Controls.Add(this.chkSpaces);
			this.Controls.Add(this.chkDigits);
			this.Controls.Add(this.chkHexLettersLower);
			this.Controls.Add(this.chkHexLettersUpper);
			this.Controls.Add(this.chkLettersLower);
			this.Controls.Add(this.chkLettersUpper);
			this.Controls.Add(this.txtPassword);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "PassGen";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.CheckBox chkLettersUpper;
		private System.Windows.Forms.CheckBox chkLettersLower;
		private System.Windows.Forms.CheckBox chkHexLettersUpper;
		private System.Windows.Forms.CheckBox chkHexLettersLower;
		private System.Windows.Forms.CheckBox chkDigits;
		private System.Windows.Forms.CheckBox chkSpaces;
		private System.Windows.Forms.CheckBox chkSymbols;
		private System.Windows.Forms.TextBox txtSymbols;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtLength;
		private System.Windows.Forms.Button btnGenerate;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnClipboard;
	}
}

