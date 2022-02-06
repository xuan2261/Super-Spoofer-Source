using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Siticone.UI.WinForms;

namespace SUPER
{
	public sealed class settingsstats : Form
	{
		private IContainer dashboard = AssistantHelper.dashboard;

		private SiticoneGroupBox siticoneGroupBox1;

		private Label label2;

		private Label label1;

		private Label label3;

		private SiticoneGroupBox siticoneGroupBox2;

		private Label label5;

		private Label label6;

		private SiticoneGroupBox siticoneGroupBox3;

		private Label label8;

		private SiticoneRadioButton siticoneRadioButton25;

		private SiticoneRadioButton siticoneRadioButton2;

		private Label label7;

		private SiticoneRadioButton siticoneRadioButton1;

		private Label label4;

		public settingsstats()
		{
			MainLoad();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && dashboard > AssistantHelper.dashboard)
				dashboard.Dispose();
			base.Dispose(disposing);
		}

		private void MainLoad()
		{
			siticoneGroupBox1 = new SiticoneGroupBox();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			siticoneGroupBox2 = new SiticoneGroupBox();
			label5 = new Label();
			label6 = new Label();
			siticoneGroupBox3 = new SiticoneGroupBox();
			label8 = new Label();
			siticoneRadioButton25 = new SiticoneRadioButton();
			siticoneRadioButton1 = new SiticoneRadioButton();
			label4 = new Label();
			siticoneRadioButton2 = new SiticoneRadioButton();
			label7 = new Label();
			siticoneGroupBox1.SuspendLayout();
			siticoneGroupBox2.SuspendLayout();
			siticoneGroupBox3.SuspendLayout();
			SuspendLayout();
			siticoneGroupBox1.BorderColor = Color.FromArgb(65, 71, 85);
			siticoneGroupBox1.Controls.Add(label3);
			siticoneGroupBox1.Controls.Add(label2);
			siticoneGroupBox1.Controls.Add(label1);
			siticoneGroupBox1.CustomBorderColor = Color.FromArgb(65, 71, 85);
			siticoneGroupBox1.FillColor = Color.FromArgb(25, 26, 30);
			siticoneGroupBox1.Font = new Font("Segoe UI", 9f);
			siticoneGroupBox1.ForeColor = Color.FromArgb(125, 137, 149);
			siticoneGroupBox1.Location = new Point(12, 12);
			siticoneGroupBox1.Name = "siticoneGroupBox1";
			siticoneGroupBox1.ShadowDecoration.Parent = siticoneGroupBox1;
			siticoneGroupBox1.Size = new Size(235, 135);
			siticoneGroupBox1.TabIndex = 100;
			siticoneGroupBox1.Text = "Total Customers Stats:";
			label1.AutoSize = true;
			label1.Font = new Font("Lucida Sans Unicode", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			label1.ForeColor = Color.White;
			label1.Location = new Point(11, 49);
			label1.Name = "label1";
			label1.Size = new Size(105, 16);
			label1.TabIndex = 101;
			label1.Text = "Total Customers:";
			label2.AutoSize = true;
			label2.Font = new Font("Lucida Sans Unicode", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			label2.ForeColor = Color.White;
			label2.Location = new Point(11, 74);
			label2.Name = "label2";
			label2.Size = new Size(92, 16);
			label2.TabIndex = 102;
			label2.Text = "Total Licenses:";
			label3.AutoSize = true;
			label3.Font = new Font("Lucida Sans Unicode", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			label3.ForeColor = Color.White;
			label3.Location = new Point(11, 100);
			label3.Name = "label3";
			label3.Size = new Size(116, 16);
			label3.TabIndex = 103;
			label3.Text = "Total Users Online:";
			siticoneGroupBox2.BorderColor = Color.FromArgb(65, 71, 85);
			siticoneGroupBox2.Controls.Add(label5);
			siticoneGroupBox2.Controls.Add(label6);
			siticoneGroupBox2.CustomBorderColor = Color.FromArgb(65, 71, 85);
			siticoneGroupBox2.FillColor = Color.FromArgb(25, 26, 30);
			siticoneGroupBox2.Font = new Font("Segoe UI", 9f);
			siticoneGroupBox2.ForeColor = Color.FromArgb(125, 137, 149);
			siticoneGroupBox2.Location = new Point(12, 450);
			siticoneGroupBox2.Name = "siticoneGroupBox2";
			siticoneGroupBox2.ShadowDecoration.Parent = siticoneGroupBox2;
			siticoneGroupBox2.Size = new Size(630, 109);
			siticoneGroupBox2.TabIndex = 104;
			siticoneGroupBox2.Text = "Total Customers Stats:";
			label5.AutoSize = true;
			label5.Font = new Font("Lucida Sans Unicode", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			label5.ForeColor = Color.White;
			label5.Location = new Point(11, 74);
			label5.Name = "label5";
			label5.Size = new Size(142, 16);
			label5.TabIndex = 102;
			label5.Text = "Auto update download:";
			label6.AutoSize = true;
			label6.Font = new Font("Lucida Sans Unicode", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			label6.ForeColor = Color.White;
			label6.Location = new Point(11, 49);
			label6.Name = "label6";
			label6.Size = new Size(131, 16);
			label6.TabIndex = 101;
			label6.Text = "Auto update version: ";
			siticoneGroupBox3.BorderColor = Color.FromArgb(65, 71, 85);
			siticoneGroupBox3.Controls.Add(siticoneRadioButton2);
			siticoneGroupBox3.Controls.Add(label7);
			siticoneGroupBox3.Controls.Add(siticoneRadioButton1);
			siticoneGroupBox3.Controls.Add(label4);
			siticoneGroupBox3.Controls.Add(siticoneRadioButton25);
			siticoneGroupBox3.Controls.Add(label8);
			siticoneGroupBox3.CustomBorderColor = Color.FromArgb(65, 71, 85);
			siticoneGroupBox3.FillColor = Color.FromArgb(25, 26, 30);
			siticoneGroupBox3.Font = new Font("Segoe UI", 9f);
			siticoneGroupBox3.ForeColor = Color.FromArgb(125, 137, 149);
			siticoneGroupBox3.Location = new Point(474, 12);
			siticoneGroupBox3.Name = "siticoneGroupBox3";
			siticoneGroupBox3.ShadowDecoration.Parent = siticoneGroupBox3;
			siticoneGroupBox3.Size = new Size(168, 135);
			siticoneGroupBox3.TabIndex = 104;
			siticoneGroupBox3.Text = "Stats Statisitcs:";
			label8.AutoSize = true;
			label8.Font = new Font("Lucida Sans Unicode", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			label8.ForeColor = Color.White;
			label8.Location = new Point(11, 49);
			label8.Name = "label8";
			label8.Size = new Size(87, 16);
			label8.TabIndex = 101;
			label8.Text = "Servers Status";
			siticoneRadioButton25.AutoCheck = false;
			siticoneRadioButton25.AutoSize = true;
			siticoneRadioButton25.Checked = true;
			siticoneRadioButton25.CheckedState.BorderColor = Color.Lime;
			siticoneRadioButton25.CheckedState.BorderThickness = 1;
			siticoneRadioButton25.CheckedState.FillColor = Color.DarkGreen;
			siticoneRadioButton25.CheckedState.InnerColor = Color.DarkGreen;
			siticoneRadioButton25.CheckedState.InnerOffset = 1;
			siticoneRadioButton25.Location = new Point(119, 51);
			siticoneRadioButton25.Name = "siticoneRadioButton25";
			siticoneRadioButton25.Size = new Size(14, 13);
			siticoneRadioButton25.TabIndex = 108;
			siticoneRadioButton25.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
			siticoneRadioButton25.UncheckedState.BorderThickness = 2;
			siticoneRadioButton25.UncheckedState.FillColor = Color.Transparent;
			siticoneRadioButton25.UncheckedState.InnerColor = Color.Transparent;
			siticoneRadioButton25.UseVisualStyleBackColor = true;
			siticoneRadioButton1.AutoCheck = false;
			siticoneRadioButton1.AutoSize = true;
			siticoneRadioButton1.Checked = true;
			siticoneRadioButton1.CheckedState.BorderColor = Color.Lime;
			siticoneRadioButton1.CheckedState.BorderThickness = 1;
			siticoneRadioButton1.CheckedState.FillColor = Color.DarkGreen;
			siticoneRadioButton1.CheckedState.InnerColor = Color.DarkGreen;
			siticoneRadioButton1.CheckedState.InnerOffset = 1;
			siticoneRadioButton1.Location = new Point(119, 76);
			siticoneRadioButton1.Name = "siticoneRadioButton1";
			siticoneRadioButton1.Size = new Size(14, 13);
			siticoneRadioButton1.TabIndex = 110;
			siticoneRadioButton1.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
			siticoneRadioButton1.UncheckedState.BorderThickness = 2;
			siticoneRadioButton1.UncheckedState.FillColor = Color.Transparent;
			siticoneRadioButton1.UncheckedState.InnerColor = Color.Transparent;
			siticoneRadioButton1.UseVisualStyleBackColor = true;
			label4.AutoSize = true;
			label4.Font = new Font("Lucida Sans Unicode", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			label4.ForeColor = Color.White;
			label4.Location = new Point(11, 74);
			label4.Name = "label4";
			label4.Size = new Size(63, 16);
			label4.TabIndex = 109;
			label4.Text = "API Status";
			siticoneRadioButton2.AutoCheck = false;
			siticoneRadioButton2.AutoSize = true;
			siticoneRadioButton2.Checked = true;
			siticoneRadioButton2.CheckedState.BorderColor = Color.Lime;
			siticoneRadioButton2.CheckedState.BorderThickness = 1;
			siticoneRadioButton2.CheckedState.FillColor = Color.DarkGreen;
			siticoneRadioButton2.CheckedState.InnerColor = Color.DarkGreen;
			siticoneRadioButton2.CheckedState.InnerOffset = 1;
			siticoneRadioButton2.Location = new Point(119, 102);
			siticoneRadioButton2.Name = "siticoneRadioButton2";
			siticoneRadioButton2.Size = new Size(14, 13);
			siticoneRadioButton2.TabIndex = 112;
			siticoneRadioButton2.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
			siticoneRadioButton2.UncheckedState.BorderThickness = 2;
			siticoneRadioButton2.UncheckedState.FillColor = Color.Transparent;
			siticoneRadioButton2.UncheckedState.InnerColor = Color.Transparent;
			siticoneRadioButton2.UseVisualStyleBackColor = true;
			label7.AutoSize = true;
			label7.Font = new Font("Lucida Sans Unicode", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			label7.ForeColor = Color.White;
			label7.Location = new Point(11, 100);
			label7.Name = "label7";
			label7.Size = new Size(102, 16);
			label7.TabIndex = 111;
			label7.Text = "Stable Response";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(25, 26, 30);
			base.ClientSize = new Size(654, 571);
			base.Controls.Add(siticoneGroupBox3);
			base.Controls.Add(siticoneGroupBox2);
			base.Controls.Add(siticoneGroupBox1);
			base.FormBorderStyle = FormBorderStyle.None;
			base.Name = "settingsstats";
			Text = "settingsstats";
			siticoneGroupBox1.ResumeLayout(false);
			siticoneGroupBox1.PerformLayout();
			siticoneGroupBox2.ResumeLayout(false);
			siticoneGroupBox2.PerformLayout();
			siticoneGroupBox3.ResumeLayout(false);
			siticoneGroupBox3.PerformLayout();
			ResumeLayout(false);
		}
	}
}
