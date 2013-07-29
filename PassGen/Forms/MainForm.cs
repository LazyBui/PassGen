﻿using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using PassGen.Utilities;

namespace PassGen.Forms {
	public partial class MainForm : Form {
		public MainForm() {
			InitializeComponent();
			CheckCheckboxes();
		}

		private void btnGenerate_Click(object sender, EventArgs e) {
			uint maxLength = 0;
			if (uint.TryParse(txtLength.Text, out maxLength)) {
				string charString = string.Empty;
				if (chkDigits.Checked) charString += "0123456789";
				if (chkLettersLower.Checked) charString += "abcdefghijklmnopqrstuvwxyz";
				else if (chkHexLettersLower.Checked) charString += "abcdef";
				if (chkLettersUpper.Checked) charString += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
				else if (chkHexLettersUpper.Checked) charString += "ABCDEF";
				if (chkSpaces.Checked) charString += " ";
				if (chkSymbols.Checked) charString += txtSymbols.Text;

				string password = string.Empty;
				for (uint i = 0; i < maxLength; i++) {
					password += Generate(charString, password);
				}
				txtPassword.Text = password;
				btnClipboard.Enabled = true;
			}
			else {
				LengthError();
			}
		}

		private void btnExit_Click(object sender, EventArgs e) { Close(); }

		private char Generate(string pCharString, string pCurrentPassword) {
			return pCharString[Randomizer.GetInt32(pCharString.Length)];
		}

		private void CheckCheckboxes(bool pTestParse = true) {
			uint maxLength = 0;
			bool parsed = uint.TryParse(txtLength.Text, out maxLength);

			btnGenerate.Enabled = (chkDigits.Checked ||
									chkHexLettersLower.Checked ||
									chkHexLettersUpper.Checked ||
									chkLettersLower.Checked ||
									chkLettersUpper.Checked ||
									chkSpaces.Checked ||
									chkSymbols.Checked) &&
									parsed &&
									maxLength > 0;

			if (pTestParse && (!parsed || maxLength == 0)) {
				LengthError();
			}
		}

		private void LengthError() {
			MessageBox.Show(string.Format("Invalid password length (number must be between {0} and {1})", 1, uint.MaxValue));
		}

		private void chkSpaces_CheckedChanged(object sender, EventArgs e) { CheckCheckboxes(); }

		private void chkDigits_CheckedChanged(object sender, EventArgs e) { CheckCheckboxes(); }

		private void chkSymbols_CheckedChanged(object sender, EventArgs e) { CheckCheckboxes(); }

		private void chkHexLettersLower_CheckedChanged(object sender, EventArgs e) { CheckCheckboxes(); }

		private void chkHexLettersUpper_CheckedChanged(object sender, EventArgs e) { CheckCheckboxes(); }

		private void chkLettersLower_CheckedChanged(object sender, EventArgs e) { CheckCheckboxes(); }

		private void chkLettersUpper_CheckedChanged(object sender, EventArgs e) { CheckCheckboxes(); }

		private void txtLength_TextChanged(object sender, EventArgs e) { CheckCheckboxes(false); }

		private void btnClipboard_Click(object sender, EventArgs e) {
			try {
				Clipboard.Clear();
				Clipboard.SetDataObject(txtPassword.Text, true, 10, 100);
			}
			catch (ExternalException) { }
		}
	}
}