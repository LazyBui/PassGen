using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace PassGen.Forms {
	public partial class MainForm : Form {
		private SecureRandom RandomSource { get; set; }

		public MainForm() {
			InitializeComponent();
			CheckCheckboxes();
			RandomSource = new SecureRandom();
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
				if (chkExtendedAscii.Checked) {
					// We duplicate the chance of all of the other symbols since there are so many extended ASCII
					// They're also intended to pepper the password, not overtake it
					charString += charString + charString;
					charString += string.Join(string.Empty, Enumerable.Range(127, 256 - 127).Select(i => (char)i));
				}

				var password = new StringBuilder();
				for (uint i = 0; i < maxLength; i++) {
					password.Append(charString[RandomSource.NextInt32(charString.Length)]);
				}
				txtPassword.Text = password.ToString();
				btnClipboard.Enabled = true;
			}
			else {
				LengthError();
			}
		}

		private void btnExit_Click(object sender, EventArgs e) { Close(); }

		private void CheckCheckboxes(bool testParse = true) {
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

			if (testParse && (!parsed || maxLength == 0)) {
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

		private void chkExtendedAscii_CheckedChanged(object sender, EventArgs e) { CheckCheckboxes(); }

		private void txtLength_ValueChanged(object sender, EventArgs e) {
			CheckCheckboxes(false);
		}

		private void btnClipboard_Click(object sender, EventArgs e) {
			try {
				Clipboard.Clear();
				Clipboard.SetDataObject(txtPassword.Text, true, 10, 100);
			}
			catch (ExternalException) { }
		}
	}
}
