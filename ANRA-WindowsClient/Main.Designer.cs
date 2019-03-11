namespace ANRA_WindowsClient
{
	partial class Main
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.cmbOperation = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label11 = new System.Windows.Forms.Label();
			this.UDPToggle = new MetroFramework.Controls.MetroToggle();
			this.label10 = new System.Windows.Forms.Label();
			this.SocketToggle = new MetroFramework.Controls.MetroToggle();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.panel6 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// cmbOperation
			// 
			this.cmbOperation.FormattingEnabled = true;
			this.cmbOperation.Location = new System.Drawing.Point(134, 132);
			this.cmbOperation.Margin = new System.Windows.Forms.Padding(2);
			this.cmbOperation.Name = "cmbOperation";
			this.cmbOperation.Size = new System.Drawing.Size(347, 21);
			this.cmbOperation.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(33, 132);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(89, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Operations(GUFI)";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label11);
			this.groupBox2.Controls.Add(this.UDPToggle);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.SocketToggle);
			this.groupBox2.Location = new System.Drawing.Point(36, 265);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox2.Size = new System.Drawing.Size(445, 93);
			this.groupBox2.TabIndex = 47;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Connections";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.BackColor = System.Drawing.Color.Transparent;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.Color.Black;
			this.label11.Location = new System.Drawing.Point(153, 30);
			this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(70, 17);
			this.label11.TabIndex = 45;
			this.label11.Text = "SOCKET";
			// 
			// UDPToggle
			// 
			this.UDPToggle.BackColor = System.Drawing.Color.Blue;
			this.UDPToggle.Location = new System.Drawing.Point(9, 51);
			this.UDPToggle.Margin = new System.Windows.Forms.Padding(2);
			this.UDPToggle.Name = "UDPToggle";
			this.UDPToggle.Size = new System.Drawing.Size(88, 20);
			this.UDPToggle.TabIndex = 42;
			this.UDPToggle.Text = "Off";
			this.UDPToggle.UseSelectable = true;
			this.UDPToggle.CheckedChanged += new System.EventHandler(this.UDPToggle_CheckedChanged);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.Black;
			this.label10.Location = new System.Drawing.Point(8, 30);
			this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(40, 17);
			this.label10.TabIndex = 43;
			this.label10.Text = "UDP";
			// 
			// SocketToggle
			// 
			this.SocketToggle.BackColor = System.Drawing.Color.White;
			this.SocketToggle.Location = new System.Drawing.Point(156, 51);
			this.SocketToggle.Margin = new System.Windows.Forms.Padding(2);
			this.SocketToggle.Name = "SocketToggle";
			this.SocketToggle.Size = new System.Drawing.Size(88, 20);
			this.SocketToggle.TabIndex = 44;
			this.SocketToggle.Text = "Off";
			this.SocketToggle.UseCustomBackColor = true;
			this.SocketToggle.UseCustomForeColor = true;
			this.SocketToggle.UseSelectable = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.panel6);
			this.groupBox1.Location = new System.Drawing.Point(486, 13);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(486, 415);
			this.groupBox1.TabIndex = 48;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "groupBox1";
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel6.Location = new System.Drawing.Point(3, 16);
			this.panel6.Margin = new System.Windows.Forms.Padding(4);
			this.panel6.Name = "panel6";
			this.panel6.Padding = new System.Windows.Forms.Padding(15);
			this.panel6.Size = new System.Drawing.Size(480, 396);
			this.panel6.TabIndex = 11;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(36, 4);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(188, 68);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 49;
			this.pictureBox1.TabStop = false;
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1001, 440);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cmbOperation);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "Main";
			this.Text = "Form1";
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cmbOperation;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label11;
		private MetroFramework.Controls.MetroToggle UDPToggle;
		private System.Windows.Forms.Label label10;
		private MetroFramework.Controls.MetroToggle SocketToggle;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}

