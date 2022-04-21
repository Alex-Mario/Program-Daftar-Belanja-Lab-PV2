/*
 * Created by SharpDevelop.
 * User: Alex
 * Date: 4/21/2022
 * Time: 10:42 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace CRUD_PV2
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.nomorTextBox = new System.Windows.Forms.TextBox();
			this.nameTextBox = new System.Windows.Forms.TextBox();
			this.hargaTextBox = new System.Windows.Forms.TextBox();
			this.jumlahTextBox = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Insertbtn = new System.Windows.Forms.Button();
			this.Updatebtn = new System.Windows.Forms.Button();
			this.Deletebtn = new System.Windows.Forms.Button();
			this.Resetbtn = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label1.Location = new System.Drawing.Point(36, 79);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "ID Kode";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label2.Location = new System.Drawing.Point(36, 117);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Nama Barang";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label3.Location = new System.Drawing.Point(36, 160);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Harga Satuan";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label4.Location = new System.Drawing.Point(36, 205);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Jumlah";
			// 
			// nomorTextBox
			// 
			this.nomorTextBox.Location = new System.Drawing.Point(142, 76);
			this.nomorTextBox.Name = "nomorTextBox";
			this.nomorTextBox.Size = new System.Drawing.Size(214, 20);
			this.nomorTextBox.TabIndex = 4;
			// 
			// nameTextBox
			// 
			this.nameTextBox.Location = new System.Drawing.Point(142, 114);
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.Size = new System.Drawing.Size(214, 20);
			this.nameTextBox.TabIndex = 5;
			// 
			// hargaTextBox
			// 
			this.hargaTextBox.Location = new System.Drawing.Point(142, 157);
			this.hargaTextBox.Name = "hargaTextBox";
			this.hargaTextBox.Size = new System.Drawing.Size(214, 20);
			this.hargaTextBox.TabIndex = 6;
			// 
			// jumlahTextBox
			// 
			this.jumlahTextBox.Location = new System.Drawing.Point(142, 202);
			this.jumlahTextBox.Name = "jumlahTextBox";
			this.jumlahTextBox.Size = new System.Drawing.Size(214, 20);
			this.jumlahTextBox.TabIndex = 7;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(381, 76);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(444, 356);
			this.dataGridView1.TabIndex = 8;
			// 
			// Insertbtn
			// 
			this.Insertbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.Insertbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Insertbtn.Location = new System.Drawing.Point(48, 249);
			this.Insertbtn.Name = "Insertbtn";
			this.Insertbtn.Size = new System.Drawing.Size(91, 44);
			this.Insertbtn.TabIndex = 9;
			this.Insertbtn.Text = "Insert";
			this.Insertbtn.UseVisualStyleBackColor = false;
			this.Insertbtn.Click += new System.EventHandler(this.InsertbtnClick);
			// 
			// Updatebtn
			// 
			this.Updatebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.Updatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Updatebtn.Location = new System.Drawing.Point(48, 301);
			this.Updatebtn.Name = "Updatebtn";
			this.Updatebtn.Size = new System.Drawing.Size(91, 44);
			this.Updatebtn.TabIndex = 10;
			this.Updatebtn.Text = "Update";
			this.Updatebtn.UseVisualStyleBackColor = false;
			this.Updatebtn.Click += new System.EventHandler(this.UpdatebtnClick);
			// 
			// Deletebtn
			// 
			this.Deletebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.Deletebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Deletebtn.Location = new System.Drawing.Point(202, 301);
			this.Deletebtn.Name = "Deletebtn";
			this.Deletebtn.Size = new System.Drawing.Size(91, 44);
			this.Deletebtn.TabIndex = 11;
			this.Deletebtn.Text = "Delete";
			this.Deletebtn.UseVisualStyleBackColor = false;
			this.Deletebtn.Click += new System.EventHandler(this.DeletebtnClick);
			// 
			// Resetbtn
			// 
			this.Resetbtn.BackColor = System.Drawing.Color.OrangeRed;
			this.Resetbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Resetbtn.Location = new System.Drawing.Point(182, 249);
			this.Resetbtn.Name = "Resetbtn";
			this.Resetbtn.Size = new System.Drawing.Size(126, 34);
			this.Resetbtn.TabIndex = 12;
			this.Resetbtn.Text = "Reset";
			this.Resetbtn.UseVisualStyleBackColor = false;
			this.Resetbtn.Click += new System.EventHandler(this.ResetbtnClick);
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
			this.label5.Location = new System.Drawing.Point(381, 9);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(340, 37);
			this.label5.TabIndex = 13;
			this.label5.Text = "DAFTAR BELANJA";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(25, 383);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(283, 23);
			this.label6.TabIndex = 14;
			this.label6.Text = "Alex Mario Simanjuntak   (201401034)";
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(25, 415);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(287, 27);
			this.label7.TabIndex = 15;
			this.label7.Text = "Daniel Tambunan             (201401146)";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SkyBlue;
			this.ClientSize = new System.Drawing.Size(841, 461);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.Resetbtn);
			this.Controls.Add(this.Deletebtn);
			this.Controls.Add(this.Updatebtn);
			this.Controls.Add(this.Insertbtn);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.jumlahTextBox);
			this.Controls.Add(this.hargaTextBox);
			this.Controls.Add(this.nameTextBox);
			this.Controls.Add(this.nomorTextBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "CRUD_PV2";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button Resetbtn;
		private System.Windows.Forms.Button Deletebtn;
		private System.Windows.Forms.Button Updatebtn;
		private System.Windows.Forms.Button Insertbtn;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox jumlahTextBox;
		private System.Windows.Forms.TextBox hargaTextBox;
		private System.Windows.Forms.TextBox nameTextBox;
		private System.Windows.Forms.TextBox nomorTextBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
