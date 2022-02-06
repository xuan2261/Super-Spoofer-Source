using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Siticone.UI.WinForms;

namespace SUPER
{
	public sealed class supershop : Form
	{
		private IContainer dashboard = AssistantHelper.dashboard;

		private AlphaGradientPanel alphaGradientPanel1;

		private SiticoneRoundedButton siticoneRoundedButton1;

		private PictureBox pictureBox1;

		private Label label1;

		private Label label5;

		private AlphaGradientPanel alphaGradientPanel2;

		private Label label2;

		private Label label3;

		private SiticoneRoundedButton siticoneRoundedButton2;

		private PictureBox pictureBox2;

		private AlphaGradientPanel alphaGradientPanel3;

		private Label label4;

		private Label label6;

		private SiticoneRoundedButton siticoneRoundedButton3;

		private PictureBox pictureBox3;

		private AlphaGradientPanel alphaGradientPanel4;

		private Label label7;

		private Label label8;

		private SiticoneRoundedButton siticoneRoundedButton4;

		private PictureBox pictureBox4;

		private AlphaGradientPanel alphaGradientPanel5;

		private Label label9;

		private Label label10;

		private SiticoneRoundedButton siticoneRoundedButton5;

		private PictureBox pictureBox5;

		private AlphaGradientPanel alphaGradientPanel6;

		private Label label11;

		private Label label12;

		private SiticoneRoundedButton siticoneRoundedButton6;

		private PictureBox pictureBox6;

		private AlphaGradientPanel alphaGradientPanel7;

		private Label label13;

		private Label label14;

		private SiticoneRoundedButton siticoneRoundedButton7;

		private PictureBox pictureBox7;

		private AlphaGradientPanel alphaGradientPanel8;

		private Label label15;

		private Label label16;

		private SiticoneRoundedButton siticoneRoundedButton8;

		private PictureBox pictureBox8;

		private Label label17;

		public supershop()
		{
			MainLoad();
		}

		private void supershopLoad(object sender, EventArgs param_376)
		{
		}

		private void siticoneRoundedButton1Click(object sender, EventArgs param_378)
		{
			Process.Start("https://shoppy.gg/product/xBQagTN");
		}

		private void siticoneRoundedButton2Click(object sender, EventArgs param_380)
		{
			Process.Start("https://shoppy.gg/product/x80YCSU");
		}

		private void siticoneRoundedButton4Click(object sender, EventArgs param_382)
		{
			Process.Start("https://shoppy.gg/product/iw8irGm");
		}

		private void siticoneRoundedButton3Click(object sender, EventArgs param_384)
		{
			Process.Start("https://shoppy.gg/product/21cU4mU");
		}

		private void siticoneRoundedButton5Click(object sender, EventArgs param_386)
		{
			Process.Start("https://shoppy.gg/product/f3nktbs");
		}

		private void siticoneRoundedButton6Click(object sender, EventArgs param_388)
		{
			Process.Start("https://shoppy.gg/product/MWTw594");
		}

		private void siticoneRoundedButton7Click(object sender, EventArgs param_390)
		{
			Process.Start("https://shoppy.gg/product/bWo5oZl");
		}

		private void siticoneRoundedButton8Click(object sender, EventArgs param_392)
		{
			Process.Start("https://shoppy.gg/product/xkp2bfl");
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && dashboard > AssistantHelper.dashboard)
				dashboard.Dispose();
			base.Dispose(disposing);
		}

		private void MainLoad()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(supershop));
			alphaGradientPanel1 = new AlphaGradientPanel();
			label5 = new Label();
			label1 = new Label();
			siticoneRoundedButton1 = new SiticoneRoundedButton();
			pictureBox1 = new PictureBox();
			alphaGradientPanel2 = new AlphaGradientPanel();
			label2 = new Label();
			label3 = new Label();
			siticoneRoundedButton2 = new SiticoneRoundedButton();
			pictureBox2 = new PictureBox();
			alphaGradientPanel3 = new AlphaGradientPanel();
			label4 = new Label();
			label6 = new Label();
			siticoneRoundedButton3 = new SiticoneRoundedButton();
			pictureBox3 = new PictureBox();
			alphaGradientPanel4 = new AlphaGradientPanel();
			label7 = new Label();
			label8 = new Label();
			siticoneRoundedButton4 = new SiticoneRoundedButton();
			pictureBox4 = new PictureBox();
			alphaGradientPanel5 = new AlphaGradientPanel();
			label9 = new Label();
			label10 = new Label();
			siticoneRoundedButton5 = new SiticoneRoundedButton();
			pictureBox5 = new PictureBox();
			alphaGradientPanel6 = new AlphaGradientPanel();
			label11 = new Label();
			label12 = new Label();
			siticoneRoundedButton6 = new SiticoneRoundedButton();
			pictureBox6 = new PictureBox();
			alphaGradientPanel7 = new AlphaGradientPanel();
			label13 = new Label();
			label14 = new Label();
			siticoneRoundedButton7 = new SiticoneRoundedButton();
			pictureBox7 = new PictureBox();
			alphaGradientPanel8 = new AlphaGradientPanel();
			label15 = new Label();
			label16 = new Label();
			siticoneRoundedButton8 = new SiticoneRoundedButton();
			pictureBox8 = new PictureBox();
			label17 = new Label();
			alphaGradientPanel1.SuspendLayout();
			((ISupportInitialize)pictureBox1).BeginInit();
			alphaGradientPanel2.SuspendLayout();
			((ISupportInitialize)pictureBox2).BeginInit();
			alphaGradientPanel3.SuspendLayout();
			((ISupportInitialize)pictureBox3).BeginInit();
			alphaGradientPanel4.SuspendLayout();
			((ISupportInitialize)pictureBox4).BeginInit();
			alphaGradientPanel5.SuspendLayout();
			((ISupportInitialize)pictureBox5).BeginInit();
			alphaGradientPanel6.SuspendLayout();
			((ISupportInitialize)pictureBox6).BeginInit();
			alphaGradientPanel7.SuspendLayout();
			((ISupportInitialize)pictureBox7).BeginInit();
			alphaGradientPanel8.SuspendLayout();
			((ISupportInitialize)pictureBox8).BeginInit();
			SuspendLayout();
			alphaGradientPanel1.BackColor = Color.Transparent;
			alphaGradientPanel1.Border = true;
			alphaGradientPanel1.BorderColor = SystemColors.ActiveBorder;
			alphaGradientPanel1.ContentPadding = new Padding(0);
			alphaGradientPanel1.Controls.Add(label5);
			alphaGradientPanel1.Controls.Add(label1);
			alphaGradientPanel1.Controls.Add(siticoneRoundedButton1);
			alphaGradientPanel1.Controls.Add(pictureBox1);
			alphaGradientPanel1.CornerRadius = 20;
			alphaGradientPanel1.Corners = Corner.All;
			alphaGradientPanel1.Gradient = true;
			alphaGradientPanel1.GradientMode = LinearGradientMode.Vertical;
			alphaGradientPanel1.GradientOffset = 1f;
			alphaGradientPanel1.GradientSize = new Size(0, 0);
			alphaGradientPanel1.GradientWrapMode = WrapMode.Tile;
			alphaGradientPanel1.Grayscale = false;
			alphaGradientPanel1.Image = AssemblyTable.dashboard;
			alphaGradientPanel1.ImageAlpha = 75;
			alphaGradientPanel1.ImagePadding = new Padding(5);
			alphaGradientPanel1.ImagePosition = ImagePosition.BottomRight;
			alphaGradientPanel1.ImageSize = new Size(48, 48);
			alphaGradientPanel1.Location = new Point(12, 12);
			alphaGradientPanel1.Name = "alphaGradientPanel1";
			alphaGradientPanel1.Rounded = true;
			alphaGradientPanel1.Size = new Size(203, 151);
			alphaGradientPanel1.TabIndex = 1;
			label5.AutoSize = true;
			label5.Font = new Font("Consolas", 9.75f, FontStyle.Underline, GraphicsUnit.Point, 0);
			label5.ForeColor = Color.White;
			label5.Location = new Point(19, 94);
			label5.Name = "label5";
			label5.Size = new Size(161, 15);
			label5.TabIndex = 4;
			label5.Text = "Super Spoofer - Weekly";
			label1.AutoSize = true;
			label1.Font = new Font("Lucida Console", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			label1.ForeColor = Color.White;
			label1.Location = new Point(5, 122);
			label1.Name = "label1";
			label1.Size = new Size(75, 19);
			label1.TabIndex = 2;
			label1.Text = "7,00 €";
			siticoneRoundedButton1.CheckedState.Parent = siticoneRoundedButton1;
			siticoneRoundedButton1.Cursor = Cursors.Hand;
			siticoneRoundedButton1.CustomImages.Parent = siticoneRoundedButton1;
			siticoneRoundedButton1.Font = new Font("Courier New", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			siticoneRoundedButton1.ForeColor = Color.White;
			siticoneRoundedButton1.HoveredState.Parent = siticoneRoundedButton1;
			siticoneRoundedButton1.Location = new Point(97, 118);
			siticoneRoundedButton1.Name = "siticoneRoundedButton1";
			siticoneRoundedButton1.ShadowDecoration.Parent = siticoneRoundedButton1;
			siticoneRoundedButton1.Size = new Size(103, 28);
			siticoneRoundedButton1.TabIndex = 1;
			siticoneRoundedButton1.Text = "PURCHASE";
			siticoneRoundedButton1.Click += siticoneRoundedButton1Click;
			pictureBox1.Image = DeviceLayout.e543raYLQcWgcOlLuY0D4tSolRctqPNE7I3KMjb2;
			pictureBox1.Location = new Point(7, 7);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(190, 85);
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 1;
			pictureBox1.TabStop = false;
			alphaGradientPanel2.BackColor = Color.Transparent;
			alphaGradientPanel2.Border = true;
			alphaGradientPanel2.BorderColor = SystemColors.ActiveBorder;
			alphaGradientPanel2.ContentPadding = new Padding(0);
			alphaGradientPanel2.Controls.Add(label2);
			alphaGradientPanel2.Controls.Add(label3);
			alphaGradientPanel2.Controls.Add(siticoneRoundedButton2);
			alphaGradientPanel2.Controls.Add(pictureBox2);
			alphaGradientPanel2.CornerRadius = 20;
			alphaGradientPanel2.Corners = Corner.All;
			alphaGradientPanel2.Gradient = true;
			alphaGradientPanel2.GradientMode = LinearGradientMode.Vertical;
			alphaGradientPanel2.GradientOffset = 1f;
			alphaGradientPanel2.GradientSize = new Size(0, 0);
			alphaGradientPanel2.GradientWrapMode = WrapMode.Tile;
			alphaGradientPanel2.Grayscale = false;
			alphaGradientPanel2.Image = AssemblyTable.dashboard;
			alphaGradientPanel2.ImageAlpha = 75;
			alphaGradientPanel2.ImagePadding = new Padding(5);
			alphaGradientPanel2.ImagePosition = ImagePosition.BottomRight;
			alphaGradientPanel2.ImageSize = new Size(48, 48);
			alphaGradientPanel2.Location = new Point(221, 12);
			alphaGradientPanel2.Name = "alphaGradientPanel2";
			alphaGradientPanel2.Rounded = true;
			alphaGradientPanel2.Size = new Size(203, 151);
			alphaGradientPanel2.TabIndex = 5;
			label2.AutoSize = true;
			label2.Font = new Font("Consolas", 9.75f, FontStyle.Underline, GraphicsUnit.Point, 0);
			label2.ForeColor = Color.White;
			label2.Location = new Point(19, 94);
			label2.Name = "label2";
			label2.Size = new Size(168, 15);
			label2.TabIndex = 4;
			label2.Text = "Super Spoofer - Monthly";
			label3.AutoSize = true;
			label3.Font = new Font("Lucida Console", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			label3.ForeColor = Color.White;
			label3.Location = new Point(5, 122);
			label3.Name = "label3";
			label3.Size = new Size(86, 19);
			label3.TabIndex = 2;
			label3.Text = "14,00 €";
			siticoneRoundedButton2.CheckedState.Parent = siticoneRoundedButton2;
			siticoneRoundedButton2.Cursor = Cursors.Hand;
			siticoneRoundedButton2.CustomImages.Parent = siticoneRoundedButton2;
			siticoneRoundedButton2.Font = new Font("Courier New", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			siticoneRoundedButton2.ForeColor = Color.White;
			siticoneRoundedButton2.HoveredState.Parent = siticoneRoundedButton2;
			siticoneRoundedButton2.Location = new Point(97, 118);
			siticoneRoundedButton2.Name = "siticoneRoundedButton2";
			siticoneRoundedButton2.ShadowDecoration.Parent = siticoneRoundedButton2;
			siticoneRoundedButton2.Size = new Size(103, 28);
			siticoneRoundedButton2.TabIndex = 1;
			siticoneRoundedButton2.Text = "PURCHASE";
			siticoneRoundedButton2.Click += siticoneRoundedButton2Click;
			pictureBox2.Image = DeviceLayout.e543raYLQcWgcOlLuY0D4tSolRctqPNE7I3KMjb2;
			pictureBox2.Location = new Point(7, 7);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(190, 85);
			pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox2.TabIndex = 1;
			pictureBox2.TabStop = false;
			alphaGradientPanel3.BackColor = Color.Transparent;
			alphaGradientPanel3.Border = true;
			alphaGradientPanel3.BorderColor = SystemColors.ActiveBorder;
			alphaGradientPanel3.ContentPadding = new Padding(0);
			alphaGradientPanel3.Controls.Add(label4);
			alphaGradientPanel3.Controls.Add(label6);
			alphaGradientPanel3.Controls.Add(siticoneRoundedButton3);
			alphaGradientPanel3.Controls.Add(pictureBox3);
			alphaGradientPanel3.CornerRadius = 20;
			alphaGradientPanel3.Corners = Corner.All;
			alphaGradientPanel3.Gradient = true;
			alphaGradientPanel3.GradientMode = LinearGradientMode.Vertical;
			alphaGradientPanel3.GradientOffset = 1f;
			alphaGradientPanel3.GradientSize = new Size(0, 0);
			alphaGradientPanel3.GradientWrapMode = WrapMode.Tile;
			alphaGradientPanel3.Grayscale = false;
			alphaGradientPanel3.Image = AssemblyTable.dashboard;
			alphaGradientPanel3.ImageAlpha = 75;
			alphaGradientPanel3.ImagePadding = new Padding(5);
			alphaGradientPanel3.ImagePosition = ImagePosition.BottomRight;
			alphaGradientPanel3.ImageSize = new Size(48, 48);
			alphaGradientPanel3.Location = new Point(663, 12);
			alphaGradientPanel3.Name = "alphaGradientPanel3";
			alphaGradientPanel3.Rounded = true;
			alphaGradientPanel3.Size = new Size(203, 151);
			alphaGradientPanel3.TabIndex = 5;
			label4.AutoSize = true;
			label4.Font = new Font("Consolas", 9.75f, FontStyle.Underline, GraphicsUnit.Point, 0);
			label4.ForeColor = Color.White;
			label4.Location = new Point(14, 94);
			label4.Name = "label4";
			label4.Size = new Size(175, 15);
			label4.TabIndex = 4;
			label4.Text = "Super Spoofer - Lifetime";
			label6.AutoSize = true;
			label6.Font = new Font("Lucida Console", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			label6.ForeColor = Color.White;
			label6.Location = new Point(5, 122);
			label6.Name = "label6";
			label6.Size = new Size(86, 19);
			label6.TabIndex = 2;
			label6.Text = "30,00 €";
			siticoneRoundedButton3.CheckedState.Parent = siticoneRoundedButton3;
			siticoneRoundedButton3.Cursor = Cursors.Hand;
			siticoneRoundedButton3.CustomImages.Parent = siticoneRoundedButton3;
			siticoneRoundedButton3.Font = new Font("Courier New", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			siticoneRoundedButton3.ForeColor = Color.White;
			siticoneRoundedButton3.HoveredState.Parent = siticoneRoundedButton3;
			siticoneRoundedButton3.Location = new Point(97, 118);
			siticoneRoundedButton3.Name = "siticoneRoundedButton3";
			siticoneRoundedButton3.ShadowDecoration.Parent = siticoneRoundedButton3;
			siticoneRoundedButton3.Size = new Size(103, 28);
			siticoneRoundedButton3.TabIndex = 1;
			siticoneRoundedButton3.Text = "PURCHASE";
			siticoneRoundedButton3.Click += siticoneRoundedButton3Click;
			pictureBox3.Image = DeviceLayout.e543raYLQcWgcOlLuY0D4tSolRctqPNE7I3KMjb2;
			pictureBox3.Location = new Point(7, 7);
			pictureBox3.Name = "pictureBox3";
			pictureBox3.Size = new Size(190, 85);
			pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox3.TabIndex = 1;
			pictureBox3.TabStop = false;
			alphaGradientPanel4.BackColor = Color.Transparent;
			alphaGradientPanel4.Border = true;
			alphaGradientPanel4.BorderColor = SystemColors.ActiveBorder;
			alphaGradientPanel4.ContentPadding = new Padding(0);
			alphaGradientPanel4.Controls.Add(label7);
			alphaGradientPanel4.Controls.Add(label8);
			alphaGradientPanel4.Controls.Add(siticoneRoundedButton4);
			alphaGradientPanel4.Controls.Add(pictureBox4);
			alphaGradientPanel4.CornerRadius = 20;
			alphaGradientPanel4.Corners = Corner.All;
			alphaGradientPanel4.Gradient = true;
			alphaGradientPanel4.GradientMode = LinearGradientMode.Vertical;
			alphaGradientPanel4.GradientOffset = 1f;
			alphaGradientPanel4.GradientSize = new Size(0, 0);
			alphaGradientPanel4.GradientWrapMode = WrapMode.Tile;
			alphaGradientPanel4.Grayscale = false;
			alphaGradientPanel4.Image = AssemblyTable.dashboard;
			alphaGradientPanel4.ImageAlpha = 75;
			alphaGradientPanel4.ImagePadding = new Padding(5);
			alphaGradientPanel4.ImagePosition = ImagePosition.BottomRight;
			alphaGradientPanel4.ImageSize = new Size(48, 48);
			alphaGradientPanel4.Location = new Point(454, 12);
			alphaGradientPanel4.Name = "alphaGradientPanel4";
			alphaGradientPanel4.Rounded = true;
			alphaGradientPanel4.Size = new Size(203, 151);
			alphaGradientPanel4.TabIndex = 5;
			label7.AutoSize = true;
			label7.Font = new Font("Consolas", 9.75f, FontStyle.Underline, GraphicsUnit.Point, 0);
			label7.ForeColor = Color.White;
			label7.Location = new Point(15, 93);
			label7.Name = "label7";
			label7.Size = new Size(175, 15);
			label7.TabIndex = 4;
			label7.Text = "Super Spoofer - 3 Months";
			label8.AutoSize = true;
			label8.Font = new Font("Lucida Console", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			label8.ForeColor = Color.White;
			label8.Location = new Point(5, 122);
			label8.Name = "label8";
			label8.Size = new Size(86, 19);
			label8.TabIndex = 2;
			label8.Text = "22,00 €";
			siticoneRoundedButton4.CheckedState.Parent = siticoneRoundedButton4;
			siticoneRoundedButton4.Cursor = Cursors.Hand;
			siticoneRoundedButton4.CustomImages.Parent = siticoneRoundedButton4;
			siticoneRoundedButton4.Font = new Font("Courier New", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			siticoneRoundedButton4.ForeColor = Color.White;
			siticoneRoundedButton4.HoveredState.Parent = siticoneRoundedButton4;
			siticoneRoundedButton4.Location = new Point(97, 118);
			siticoneRoundedButton4.Name = "siticoneRoundedButton4";
			siticoneRoundedButton4.ShadowDecoration.Parent = siticoneRoundedButton4;
			siticoneRoundedButton4.Size = new Size(103, 28);
			siticoneRoundedButton4.TabIndex = 1;
			siticoneRoundedButton4.Text = "PURCHASE";
			siticoneRoundedButton4.Click += siticoneRoundedButton4Click;
			pictureBox4.Image = DeviceLayout.e543raYLQcWgcOlLuY0D4tSolRctqPNE7I3KMjb2;
			pictureBox4.Location = new Point(7, 7);
			pictureBox4.Name = "pictureBox4";
			pictureBox4.Size = new Size(190, 85);
			pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox4.TabIndex = 1;
			pictureBox4.TabStop = false;
			alphaGradientPanel5.BackColor = Color.Transparent;
			alphaGradientPanel5.Border = true;
			alphaGradientPanel5.BorderColor = SystemColors.ActiveBorder;
			alphaGradientPanel5.ContentPadding = new Padding(0);
			alphaGradientPanel5.Controls.Add(label9);
			alphaGradientPanel5.Controls.Add(label10);
			alphaGradientPanel5.Controls.Add(siticoneRoundedButton5);
			alphaGradientPanel5.Controls.Add(pictureBox5);
			alphaGradientPanel5.CornerRadius = 20;
			alphaGradientPanel5.Corners = Corner.All;
			alphaGradientPanel5.Gradient = true;
			alphaGradientPanel5.GradientMode = LinearGradientMode.Vertical;
			alphaGradientPanel5.GradientOffset = 1f;
			alphaGradientPanel5.GradientSize = new Size(0, 0);
			alphaGradientPanel5.GradientWrapMode = WrapMode.Tile;
			alphaGradientPanel5.Grayscale = false;
			alphaGradientPanel5.Image = AssemblyTable.dashboard;
			alphaGradientPanel5.ImageAlpha = 75;
			alphaGradientPanel5.ImagePadding = new Padding(5);
			alphaGradientPanel5.ImagePosition = ImagePosition.BottomRight;
			alphaGradientPanel5.ImageSize = new Size(48, 48);
			alphaGradientPanel5.Location = new Point(12, 169);
			alphaGradientPanel5.Name = "alphaGradientPanel5";
			alphaGradientPanel5.Rounded = true;
			alphaGradientPanel5.Size = new Size(203, 151);
			alphaGradientPanel5.TabIndex = 5;
			label9.AutoSize = true;
			label9.Font = new Font("Consolas", 9.75f, FontStyle.Underline, GraphicsUnit.Point, 0);
			label9.ForeColor = Color.White;
			label9.Location = new Point(16, 94);
			label9.Name = "label9";
			label9.Size = new Size(168, 15);
			label9.TabIndex = 4;
			label9.Text = "Spoofer Bundle - Weekly";
			label10.AutoSize = true;
			label10.Font = new Font("Lucida Console", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			label10.ForeColor = Color.White;
			label10.Location = new Point(5, 122);
			label10.Name = "label10";
			label10.Size = new Size(75, 19);
			label10.TabIndex = 2;
			label10.Text = "4,50 €";
			siticoneRoundedButton5.CheckedState.Parent = siticoneRoundedButton5;
			siticoneRoundedButton5.Cursor = Cursors.Hand;
			siticoneRoundedButton5.CustomImages.Parent = siticoneRoundedButton5;
			siticoneRoundedButton5.Font = new Font("Courier New", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			siticoneRoundedButton5.ForeColor = Color.White;
			siticoneRoundedButton5.HoveredState.Parent = siticoneRoundedButton5;
			siticoneRoundedButton5.Location = new Point(97, 118);
			siticoneRoundedButton5.Name = "siticoneRoundedButton5";
			siticoneRoundedButton5.ShadowDecoration.Parent = siticoneRoundedButton5;
			siticoneRoundedButton5.Size = new Size(103, 28);
			siticoneRoundedButton5.TabIndex = 1;
			siticoneRoundedButton5.Text = "PURCHASE";
			siticoneRoundedButton5.Click += siticoneRoundedButton5Click;
			pictureBox5.Image = (Image)componentResourceManager.GetObject("pictureBox5.Image");
			pictureBox5.Location = new Point(7, 7);
			pictureBox5.Name = "pictureBox5";
			pictureBox5.Size = new Size(190, 85);
			pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox5.TabIndex = 1;
			pictureBox5.TabStop = false;
			alphaGradientPanel6.BackColor = Color.Transparent;
			alphaGradientPanel6.Border = true;
			alphaGradientPanel6.BorderColor = SystemColors.ActiveBorder;
			alphaGradientPanel6.ContentPadding = new Padding(0);
			alphaGradientPanel6.Controls.Add(label11);
			alphaGradientPanel6.Controls.Add(label12);
			alphaGradientPanel6.Controls.Add(siticoneRoundedButton6);
			alphaGradientPanel6.Controls.Add(pictureBox6);
			alphaGradientPanel6.CornerRadius = 20;
			alphaGradientPanel6.Corners = Corner.All;
			alphaGradientPanel6.Gradient = true;
			alphaGradientPanel6.GradientMode = LinearGradientMode.Vertical;
			alphaGradientPanel6.GradientOffset = 1f;
			alphaGradientPanel6.GradientSize = new Size(0, 0);
			alphaGradientPanel6.GradientWrapMode = WrapMode.Tile;
			alphaGradientPanel6.Grayscale = false;
			alphaGradientPanel6.Image = AssemblyTable.dashboard;
			alphaGradientPanel6.ImageAlpha = 75;
			alphaGradientPanel6.ImagePadding = new Padding(5);
			alphaGradientPanel6.ImagePosition = ImagePosition.BottomRight;
			alphaGradientPanel6.ImageSize = new Size(48, 48);
			alphaGradientPanel6.Location = new Point(221, 169);
			alphaGradientPanel6.Name = "alphaGradientPanel6";
			alphaGradientPanel6.Rounded = true;
			alphaGradientPanel6.Size = new Size(203, 151);
			alphaGradientPanel6.TabIndex = 5;
			label11.AutoSize = true;
			label11.Font = new Font("Consolas", 9.75f, FontStyle.Underline, GraphicsUnit.Point, 0);
			label11.ForeColor = Color.White;
			label11.Location = new Point(11, 94);
			label11.Name = "label11";
			label11.Size = new Size(182, 15);
			label11.TabIndex = 4;
			label11.Text = "Spoofer Bundle - Lifetime";
			label12.AutoSize = true;
			label12.Font = new Font("Lucida Console", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			label12.ForeColor = Color.White;
			label12.Location = new Point(5, 122);
			label12.Name = "label12";
			label12.Size = new Size(86, 19);
			label12.TabIndex = 2;
			label12.Text = "13,00 €";
			siticoneRoundedButton6.CheckedState.Parent = siticoneRoundedButton6;
			siticoneRoundedButton6.Cursor = Cursors.Hand;
			siticoneRoundedButton6.CustomImages.Parent = siticoneRoundedButton6;
			siticoneRoundedButton6.Font = new Font("Courier New", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			siticoneRoundedButton6.ForeColor = Color.White;
			siticoneRoundedButton6.HoveredState.Parent = siticoneRoundedButton6;
			siticoneRoundedButton6.Location = new Point(97, 118);
			siticoneRoundedButton6.Name = "siticoneRoundedButton6";
			siticoneRoundedButton6.ShadowDecoration.Parent = siticoneRoundedButton6;
			siticoneRoundedButton6.Size = new Size(103, 28);
			siticoneRoundedButton6.TabIndex = 1;
			siticoneRoundedButton6.Text = "PURCHASE";
			siticoneRoundedButton6.Click += siticoneRoundedButton6Click;
			pictureBox6.Image = (Image)componentResourceManager.GetObject("pictureBox6.Image");
			pictureBox6.Location = new Point(7, 7);
			pictureBox6.Name = "pictureBox6";
			pictureBox6.Size = new Size(190, 85);
			pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox6.TabIndex = 1;
			pictureBox6.TabStop = false;
			alphaGradientPanel7.BackColor = Color.Transparent;
			alphaGradientPanel7.Border = true;
			alphaGradientPanel7.BorderColor = SystemColors.ActiveBorder;
			alphaGradientPanel7.ContentPadding = new Padding(0);
			alphaGradientPanel7.Controls.Add(label13);
			alphaGradientPanel7.Controls.Add(label14);
			alphaGradientPanel7.Controls.Add(siticoneRoundedButton7);
			alphaGradientPanel7.Controls.Add(pictureBox7);
			alphaGradientPanel7.CornerRadius = 20;
			alphaGradientPanel7.Corners = Corner.All;
			alphaGradientPanel7.Gradient = true;
			alphaGradientPanel7.GradientMode = LinearGradientMode.Vertical;
			alphaGradientPanel7.GradientOffset = 1f;
			alphaGradientPanel7.GradientSize = new Size(0, 0);
			alphaGradientPanel7.GradientWrapMode = WrapMode.Tile;
			alphaGradientPanel7.Grayscale = false;
			alphaGradientPanel7.Image = AssemblyTable.dashboard;
			alphaGradientPanel7.ImageAlpha = 75;
			alphaGradientPanel7.ImagePadding = new Padding(5);
			alphaGradientPanel7.ImagePosition = ImagePosition.BottomRight;
			alphaGradientPanel7.ImageSize = new Size(48, 48);
			alphaGradientPanel7.Location = new Point(454, 169);
			alphaGradientPanel7.Name = "alphaGradientPanel7";
			alphaGradientPanel7.Rounded = true;
			alphaGradientPanel7.Size = new Size(203, 151);
			alphaGradientPanel7.TabIndex = 5;
			label13.AutoSize = true;
			label13.Font = new Font("Consolas", 9.75f, FontStyle.Underline, GraphicsUnit.Point, 0);
			label13.ForeColor = Color.White;
			label13.Location = new Point(49, 94);
			label13.Name = "label13";
			label13.Size = new Size(105, 15);
			label13.TabIndex = 4;
			label13.Text = "Rockstar FiveM";
			label14.AutoSize = true;
			label14.Font = new Font("Lucida Console", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			label14.ForeColor = Color.White;
			label14.Location = new Point(5, 122);
			label14.Name = "label14";
			label14.Size = new Size(75, 19);
			label14.TabIndex = 2;
			label14.Text = "2,00 €";
			siticoneRoundedButton7.CheckedState.Parent = siticoneRoundedButton7;
			siticoneRoundedButton7.Cursor = Cursors.Hand;
			siticoneRoundedButton7.CustomImages.Parent = siticoneRoundedButton7;
			siticoneRoundedButton7.Font = new Font("Courier New", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			siticoneRoundedButton7.ForeColor = Color.White;
			siticoneRoundedButton7.HoveredState.Parent = siticoneRoundedButton7;
			siticoneRoundedButton7.Location = new Point(97, 118);
			siticoneRoundedButton7.Name = "siticoneRoundedButton7";
			siticoneRoundedButton7.ShadowDecoration.Parent = siticoneRoundedButton7;
			siticoneRoundedButton7.Size = new Size(103, 28);
			siticoneRoundedButton7.TabIndex = 1;
			siticoneRoundedButton7.Text = "PURCHASE";
			siticoneRoundedButton7.Click += siticoneRoundedButton7Click;
			pictureBox7.Image = (Image)componentResourceManager.GetObject("pictureBox7.Image");
			pictureBox7.Location = new Point(7, 7);
			pictureBox7.Name = "pictureBox7";
			pictureBox7.Size = new Size(190, 85);
			pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox7.TabIndex = 1;
			pictureBox7.TabStop = false;
			alphaGradientPanel8.BackColor = Color.Transparent;
			alphaGradientPanel8.Border = true;
			alphaGradientPanel8.BorderColor = SystemColors.ActiveBorder;
			alphaGradientPanel8.ContentPadding = new Padding(0);
			alphaGradientPanel8.Controls.Add(label15);
			alphaGradientPanel8.Controls.Add(label16);
			alphaGradientPanel8.Controls.Add(siticoneRoundedButton8);
			alphaGradientPanel8.Controls.Add(pictureBox8);
			alphaGradientPanel8.CornerRadius = 20;
			alphaGradientPanel8.Corners = Corner.All;
			alphaGradientPanel8.Gradient = true;
			alphaGradientPanel8.GradientMode = LinearGradientMode.Vertical;
			alphaGradientPanel8.GradientOffset = 1f;
			alphaGradientPanel8.GradientSize = new Size(0, 0);
			alphaGradientPanel8.GradientWrapMode = WrapMode.Tile;
			alphaGradientPanel8.Grayscale = false;
			alphaGradientPanel8.Image = AssemblyTable.dashboard;
			alphaGradientPanel8.ImageAlpha = 75;
			alphaGradientPanel8.ImagePadding = new Padding(5);
			alphaGradientPanel8.ImagePosition = ImagePosition.BottomRight;
			alphaGradientPanel8.ImageSize = new Size(48, 48);
			alphaGradientPanel8.Location = new Point(663, 169);
			alphaGradientPanel8.Name = "alphaGradientPanel8";
			alphaGradientPanel8.Rounded = true;
			alphaGradientPanel8.Size = new Size(203, 151);
			alphaGradientPanel8.TabIndex = 5;
			label15.AutoSize = true;
			label15.Font = new Font("Consolas", 9.75f, FontStyle.Underline, GraphicsUnit.Point, 0);
			label15.ForeColor = Color.White;
			label15.Location = new Point(24, 94);
			label15.Name = "label15";
			label15.Size = new Size(154, 15);
			label15.TabIndex = 4;
			label15.Text = "Rockstar GTA Download";
			label16.AutoSize = true;
			label16.Font = new Font("Lucida Console", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			label16.ForeColor = Color.White;
			label16.Location = new Point(5, 122);
			label16.Name = "label16";
			label16.Size = new Size(75, 19);
			label16.TabIndex = 2;
			label16.Text = "4,50 €";
			siticoneRoundedButton8.CheckedState.Parent = siticoneRoundedButton8;
			siticoneRoundedButton8.Cursor = Cursors.Hand;
			siticoneRoundedButton8.CustomImages.Parent = siticoneRoundedButton8;
			siticoneRoundedButton8.Font = new Font("Courier New", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			siticoneRoundedButton8.ForeColor = Color.White;
			siticoneRoundedButton8.HoveredState.Parent = siticoneRoundedButton8;
			siticoneRoundedButton8.Location = new Point(97, 118);
			siticoneRoundedButton8.Name = "siticoneRoundedButton8";
			siticoneRoundedButton8.ShadowDecoration.Parent = siticoneRoundedButton8;
			siticoneRoundedButton8.Size = new Size(103, 28);
			siticoneRoundedButton8.TabIndex = 1;
			siticoneRoundedButton8.Text = "PURCHASE";
			siticoneRoundedButton8.Click += siticoneRoundedButton8Click;
			pictureBox8.Image = (Image)componentResourceManager.GetObject("pictureBox8.Image");
			pictureBox8.Location = new Point(7, 7);
			pictureBox8.Name = "pictureBox8";
			pictureBox8.Size = new Size(190, 85);
			pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox8.TabIndex = 1;
			pictureBox8.TabStop = false;
			label17.AutoSize = true;
			label17.FlatStyle = FlatStyle.Flat;
			label17.Font = new Font("Courier New", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			label17.ForeColor = Color.White;
			label17.Location = new Point(12, 487);
			label17.Name = "label17";
			label17.Size = new Size(458, 17);
			label17.TabIndex = 12;
			label17.Text = "Cant find your payment method? Ask in the discord!";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(50, 55, 67);
			base.ClientSize = new Size(873, 520);
			base.Controls.Add(label17);
			base.Controls.Add(alphaGradientPanel8);
			base.Controls.Add(alphaGradientPanel7);
			base.Controls.Add(alphaGradientPanel6);
			base.Controls.Add(alphaGradientPanel5);
			base.Controls.Add(alphaGradientPanel4);
			base.Controls.Add(alphaGradientPanel3);
			base.Controls.Add(alphaGradientPanel2);
			base.Controls.Add(alphaGradientPanel1);
			base.FormBorderStyle = FormBorderStyle.None;
			base.Name = "supershop";
			Text = "supershop";
			base.Load += supershopLoad;
			alphaGradientPanel1.ResumeLayout(false);
			alphaGradientPanel1.PerformLayout();
			((ISupportInitialize)pictureBox1).EndInit();
			alphaGradientPanel2.ResumeLayout(false);
			alphaGradientPanel2.PerformLayout();
			((ISupportInitialize)pictureBox2).EndInit();
			alphaGradientPanel3.ResumeLayout(false);
			alphaGradientPanel3.PerformLayout();
			((ISupportInitialize)pictureBox3).EndInit();
			alphaGradientPanel4.ResumeLayout(false);
			alphaGradientPanel4.PerformLayout();
			((ISupportInitialize)pictureBox4).EndInit();
			alphaGradientPanel5.ResumeLayout(false);
			alphaGradientPanel5.PerformLayout();
			((ISupportInitialize)pictureBox5).EndInit();
			alphaGradientPanel6.ResumeLayout(false);
			alphaGradientPanel6.PerformLayout();
			((ISupportInitialize)pictureBox6).EndInit();
			alphaGradientPanel7.ResumeLayout(false);
			alphaGradientPanel7.PerformLayout();
			((ISupportInitialize)pictureBox7).EndInit();
			alphaGradientPanel8.ResumeLayout(false);
			alphaGradientPanel8.PerformLayout();
			((ISupportInitialize)pictureBox8).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}
	}
}
