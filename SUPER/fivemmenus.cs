using System;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using FastColoredTextBoxNS;
using Siticone.UI.WinForms;

namespace SUPER
{
	public sealed class fivemmenus : Form
	{
		private IContainer dashboard = AssistantHelper.dashboard;

		private ListBox listBox1;

		private SiticoneRoundedGradientButton siticoneRoundedGradientButton5;

		private FastColoredTextBox fastColoredTextBox1;

		private SiticoneRoundedGradientButton siticoneRoundedGradientButton1;

		private SiticoneRoundedGradientButton siticoneRoundedGradientButton2;

		private SiticoneRoundedGradientButton siticoneRoundedGradientButton3;

		private SiticoneRoundedGradientButton siticoneRoundedGradientButton4;

		public fivemmenus()
		{
			MainLoad();
		}

		private void fivemmenusLoad(object sender, EventArgs param_503)
		{
			listBox1.Items.Add("Absolute V2");
			listBox1.Items.Add("ATG Menu");
		}

		private void siticoneRoundedGradientButton5Click(object sender, EventArgs param_505)
		{
			if (listBox1.SelectedIndex == -1)
				MessageBox.Show("Please select an Item first!");
			if (listBox1.SelectedItem.ToString() == "Absolute V2")
				new WebClient().DownloadFile("https://cdn.discordapp.com/attachments/909940221263638632/929296738416746546/Absolute2.lua", "C:\\Menus\\AbsoluteV2.lua");
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && dashboard > AssistantHelper.dashboard)
				dashboard.Dispose();
			base.Dispose(disposing);
		}

		private void MainLoad()
		{
			dashboard = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(fivemmenus));
			listBox1 = new ListBox();
			siticoneRoundedGradientButton5 = new SiticoneRoundedGradientButton();
			fastColoredTextBox1 = new FastColoredTextBox();
			siticoneRoundedGradientButton1 = new SiticoneRoundedGradientButton();
			siticoneRoundedGradientButton2 = new SiticoneRoundedGradientButton();
			siticoneRoundedGradientButton3 = new SiticoneRoundedGradientButton();
			siticoneRoundedGradientButton4 = new SiticoneRoundedGradientButton();
			((ISupportInitialize)fastColoredTextBox1).BeginInit();
			SuspendLayout();
			listBox1.BackColor = Color.FromArgb(25, 26, 30);
			listBox1.BorderStyle = BorderStyle.FixedSingle;
			listBox1.Font = new Font("Courier New", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			listBox1.ForeColor = Color.White;
			listBox1.FormattingEnabled = true;
			listBox1.ItemHeight = 16;
			listBox1.Location = new Point(12, 12);
			listBox1.Name = "listBox1";
			listBox1.Size = new Size(298, 546);
			listBox1.TabIndex = 0;
			siticoneRoundedGradientButton5.BorderThickness = 1;
			siticoneRoundedGradientButton5.CheckedState.Parent = siticoneRoundedGradientButton5;
			siticoneRoundedGradientButton5.CustomImages.Parent = siticoneRoundedGradientButton5;
			siticoneRoundedGradientButton5.FillColor = Color.DimGray;
			siticoneRoundedGradientButton5.FillColor2 = Color.DimGray;
			siticoneRoundedGradientButton5.Font = new Font("Segoe UI", 8f, FontStyle.Bold);
			siticoneRoundedGradientButton5.ForeColor = Color.White;
			siticoneRoundedGradientButton5.HoveredState.Parent = siticoneRoundedGradientButton5;
			siticoneRoundedGradientButton5.Location = new Point(12, 564);
			siticoneRoundedGradientButton5.Name = "siticoneRoundedGradientButton5";
			siticoneRoundedGradientButton5.ShadowDecoration.Parent = siticoneRoundedGradientButton5;
			siticoneRoundedGradientButton5.Size = new Size(298, 30);
			siticoneRoundedGradientButton5.TabIndex = 118;
			siticoneRoundedGradientButton5.Text = "Load Selected Menu";
			siticoneRoundedGradientButton5.Click += siticoneRoundedGradientButton5Click;
			fastColoredTextBox1.AutoCompleteBracketsList = new char[10] { '(', ')', '{', '}', '[', ']', '"', '"', '\'', '\'' };
			fastColoredTextBox1.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>.+)\r\n";
			fastColoredTextBox1.AutoScrollMinSize = new Size(29, 16);
			fastColoredTextBox1.BackBrush = PcitureSerializer.dashboard;
			fastColoredTextBox1.BackColor = Color.Transparent;
			fastColoredTextBox1.BookmarkColor = Color.MediumVioletRed;
			fastColoredTextBox1.BorderStyle = BorderStyle.FixedSingle;
			fastColoredTextBox1.BracketsHighlightStrategy = BracketsHighlightStrategy.Strategy2;
			fastColoredTextBox1.CaretVisible = false;
			fastColoredTextBox1.CharHeight = 16;
			fastColoredTextBox1.CharWidth = 9;
			fastColoredTextBox1.CommentPrefix = "--";
			fastColoredTextBox1.CurrentLineColor = Color.White;
			fastColoredTextBox1.Cursor = Cursors.IBeam;
			fastColoredTextBox1.DisabledColor = Color.FromArgb(100, 180, 180, 180);
			fastColoredTextBox1.Font = new Font("Courier New", 11.25f);
			fastColoredTextBox1.ForeColor = Color.White;
			fastColoredTextBox1.HighlightingRangeType = HighlightingRangeType.VisibleRange;
			fastColoredTextBox1.IndentBackColor = Color.FromArgb(25, 26, 30);
			fastColoredTextBox1.IsReplaceMode = false;
			fastColoredTextBox1.Language = Language.Lua;
			fastColoredTextBox1.LeftBracket = '(';
			fastColoredTextBox1.LeftBracket2 = '{';
			fastColoredTextBox1.LineNumberColor = SystemColors.Window;
			fastColoredTextBox1.Location = new Point(316, 12);
			fastColoredTextBox1.Name = "fastColoredTextBox1";
			fastColoredTextBox1.PaddingBackColor = SystemColors.WindowFrame;
			fastColoredTextBox1.Paddings = new Padding(0);
			fastColoredTextBox1.RightBracket = ')';
			fastColoredTextBox1.RightBracket2 = '}';
			fastColoredTextBox1.SelectionColor = Color.FromArgb(200, 0, 200, 255);
			fastColoredTextBox1.ServiceColors = (ServiceColors)componentResourceManager.GetObject("fastColoredTextBox1.ServiceColors");
			fastColoredTextBox1.Size = new Size(545, 546);
			fastColoredTextBox1.TabIndex = 119;
			fastColoredTextBox1.Zoom = 100;
			siticoneRoundedGradientButton1.BorderThickness = 1;
			siticoneRoundedGradientButton1.CheckedState.Parent = siticoneRoundedGradientButton1;
			siticoneRoundedGradientButton1.CustomImages.Parent = siticoneRoundedGradientButton1;
			siticoneRoundedGradientButton1.FillColor = Color.DimGray;
			siticoneRoundedGradientButton1.FillColor2 = Color.DimGray;
			siticoneRoundedGradientButton1.Font = new Font("Segoe UI", 8f, FontStyle.Bold);
			siticoneRoundedGradientButton1.ForeColor = Color.White;
			siticoneRoundedGradientButton1.HoveredState.Parent = siticoneRoundedGradientButton1;
			siticoneRoundedGradientButton1.Location = new Point(316, 564);
			siticoneRoundedGradientButton1.Name = "siticoneRoundedGradientButton1";
			siticoneRoundedGradientButton1.ShadowDecoration.Parent = siticoneRoundedGradientButton1;
			siticoneRoundedGradientButton1.Size = new Size(128, 30);
			siticoneRoundedGradientButton1.TabIndex = 120;
			siticoneRoundedGradientButton1.Text = "Open LUA FIle";
			siticoneRoundedGradientButton2.BorderThickness = 1;
			siticoneRoundedGradientButton2.CheckedState.Parent = siticoneRoundedGradientButton2;
			siticoneRoundedGradientButton2.CustomImages.Parent = siticoneRoundedGradientButton2;
			siticoneRoundedGradientButton2.FillColor = Color.DimGray;
			siticoneRoundedGradientButton2.FillColor2 = Color.DimGray;
			siticoneRoundedGradientButton2.Font = new Font("Segoe UI", 8f, FontStyle.Bold);
			siticoneRoundedGradientButton2.ForeColor = Color.White;
			siticoneRoundedGradientButton2.HoveredState.Parent = siticoneRoundedGradientButton2;
			siticoneRoundedGradientButton2.Location = new Point(450, 564);
			siticoneRoundedGradientButton2.Name = "siticoneRoundedGradientButton2";
			siticoneRoundedGradientButton2.ShadowDecoration.Parent = siticoneRoundedGradientButton2;
			siticoneRoundedGradientButton2.Size = new Size(128, 30);
			siticoneRoundedGradientButton2.TabIndex = 121;
			siticoneRoundedGradientButton2.Text = "Save LUA FIle";
			siticoneRoundedGradientButton3.BorderThickness = 1;
			siticoneRoundedGradientButton3.CheckedState.Parent = siticoneRoundedGradientButton3;
			siticoneRoundedGradientButton3.CustomImages.Parent = siticoneRoundedGradientButton3;
			siticoneRoundedGradientButton3.FillColor = Color.DimGray;
			siticoneRoundedGradientButton3.FillColor2 = Color.DimGray;
			siticoneRoundedGradientButton3.Font = new Font("Segoe UI", 8f, FontStyle.Bold);
			siticoneRoundedGradientButton3.ForeColor = Color.White;
			siticoneRoundedGradientButton3.HoveredState.Parent = siticoneRoundedGradientButton3;
			siticoneRoundedGradientButton3.Location = new Point(733, 564);
			siticoneRoundedGradientButton3.Name = "siticoneRoundedGradientButton3";
			siticoneRoundedGradientButton3.ShadowDecoration.Parent = siticoneRoundedGradientButton3;
			siticoneRoundedGradientButton3.Size = new Size(128, 30);
			siticoneRoundedGradientButton3.TabIndex = 122;
			siticoneRoundedGradientButton3.Text = "Clear Text";
			siticoneRoundedGradientButton4.BorderThickness = 1;
			siticoneRoundedGradientButton4.CheckedState.Parent = siticoneRoundedGradientButton4;
			siticoneRoundedGradientButton4.CustomImages.Parent = siticoneRoundedGradientButton4;
			siticoneRoundedGradientButton4.FillColor = Color.DimGray;
			siticoneRoundedGradientButton4.FillColor2 = Color.DimGray;
			siticoneRoundedGradientButton4.Font = new Font("Segoe UI", 8f, FontStyle.Bold);
			siticoneRoundedGradientButton4.ForeColor = Color.White;
			siticoneRoundedGradientButton4.HoveredState.Parent = siticoneRoundedGradientButton4;
			siticoneRoundedGradientButton4.Location = new Point(599, 564);
			siticoneRoundedGradientButton4.Name = "siticoneRoundedGradientButton4";
			siticoneRoundedGradientButton4.ShadowDecoration.Parent = siticoneRoundedGradientButton4;
			siticoneRoundedGradientButton4.Size = new Size(128, 30);
			siticoneRoundedGradientButton4.TabIndex = 123;
			siticoneRoundedGradientButton4.Text = "Copy Text";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(25, 26, 30);
			base.ClientSize = new Size(873, 597);
			base.Controls.Add(siticoneRoundedGradientButton4);
			base.Controls.Add(siticoneRoundedGradientButton3);
			base.Controls.Add(siticoneRoundedGradientButton2);
			base.Controls.Add(siticoneRoundedGradientButton1);
			base.Controls.Add(fastColoredTextBox1);
			base.Controls.Add(siticoneRoundedGradientButton5);
			base.Controls.Add(listBox1);
			base.FormBorderStyle = FormBorderStyle.None;
			base.Name = "fivemmenus";
			Text = "fivemmenus";
			base.Load += fivemmenusLoad;
			((ISupportInitialize)fastColoredTextBox1).EndInit();
			ResumeLayout(false);
		}
	}
}
