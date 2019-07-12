/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2019/7/11
 * 时间: 10:28
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
namespace RandomName
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button btnGenName1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Label labAuthor;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtLastname;
		private System.Windows.Forms.RadioButton rbnFemale;
		private System.Windows.Forms.RadioButton rbnCustom;
		private System.Windows.Forms.RadioButton rbnMale;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.btnGenName1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.rbnFemale = new System.Windows.Forms.RadioButton();
			this.btnClear = new System.Windows.Forms.Button();
			this.labAuthor = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtLastname = new System.Windows.Forms.TextBox();
			this.rbnCustom = new System.Windows.Forms.RadioButton();
			this.rbnMale = new System.Windows.Forms.RadioButton();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(12, 61);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox1.Size = new System.Drawing.Size(276, 235);
			this.textBox1.TabIndex = 0;
			// 
			// btnGenName1
			// 
			this.btnGenName1.Location = new System.Drawing.Point(213, 7);
			this.btnGenName1.Name = "btnGenName1";
			this.btnGenName1.Size = new System.Drawing.Size(75, 23);
			this.btnGenName1.TabIndex = 1;
			this.btnGenName1.Text = "生成";
			this.btnGenName1.UseVisualStyleBackColor = true;
			this.btnGenName1.Click += new System.EventHandler(this.BtnGenName1Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "数量：";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(47, 7);
			this.numericUpDown1.Minimum = new decimal(new int[] {
			1,
			0,
			0,
			0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(43, 21);
			this.numericUpDown1.TabIndex = 3;
			this.numericUpDown1.Value = new decimal(new int[] {
			20,
			0,
			0,
			0});
			// 
			// rbnFemale
			// 
			this.rbnFemale.Location = new System.Drawing.Point(148, 6);
			this.rbnFemale.Name = "rbnFemale";
			this.rbnFemale.Size = new System.Drawing.Size(33, 24);
			this.rbnFemale.TabIndex = 4;
			this.rbnFemale.Text = "女";
			this.rbnFemale.UseVisualStyleBackColor = true;
			this.rbnFemale.MouseEnter += new System.EventHandler(this.rbnCustomMouseEnter);
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(213, 32);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(75, 23);
			this.btnClear.TabIndex = 5;
			this.btnClear.Text = "清空";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.BtnClearClick);
			// 
			// labAuthor
			// 
			this.labAuthor.ForeColor = System.Drawing.Color.Blue;
			this.labAuthor.Location = new System.Drawing.Point(215, 299);
			this.labAuthor.Name = "labAuthor";
			this.labAuthor.Size = new System.Drawing.Size(73, 18);
			this.labAuthor.TabIndex = 6;
			this.labAuthor.Text = "By : Salitt";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 35);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 20);
			this.label2.TabIndex = 7;
			this.label2.Text = "姓：";
			// 
			// txtLastname
			// 
			this.txtLastname.Location = new System.Drawing.Point(47, 32);
			this.txtLastname.Name = "txtLastname";
			this.txtLastname.Size = new System.Drawing.Size(43, 21);
			this.txtLastname.TabIndex = 8;
			// 
			// rbnCustom
			// 
			this.rbnCustom.Location = new System.Drawing.Point(107, 31);
			this.rbnCustom.Name = "rbnCustom";
			this.rbnCustom.Size = new System.Drawing.Size(84, 24);
			this.rbnCustom.TabIndex = 9;
			this.rbnCustom.Text = "自定义字典";
			this.rbnCustom.UseVisualStyleBackColor = true;
			// 
			// rbnMale
			// 
			this.rbnMale.Checked = true;
			this.rbnMale.Location = new System.Drawing.Point(107, 6);
			this.rbnMale.Name = "rbnMale";
			this.rbnMale.Size = new System.Drawing.Size(35, 24);
			this.rbnMale.TabIndex = 10;
			this.rbnMale.TabStop = true;
			this.rbnMale.Text = "男";
			this.rbnMale.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(300, 317);
			this.Controls.Add(this.rbnMale);
			this.Controls.Add(this.rbnCustom);
			this.Controls.Add(this.txtLastname);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.labAuthor);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.rbnFemale);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnGenName1);
			this.Controls.Add(this.textBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "随机名字生成器 V1.05";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
