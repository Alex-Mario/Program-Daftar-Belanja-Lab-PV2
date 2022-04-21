/*
 * Created by SharpDevelop.
 * User: Alex
 * Date: 4/21/2022
 * Time: 10:42 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace CRUD_PV2
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		MySqlConnection co = new MySqlConnection("Server = localhost; Database = data_belanja; Uid = root");
		MySqlCommand mycommand = new MySqlCommand();
		MySqlDataAdapter myadapter = new MySqlDataAdapter();
		
		public void ReadData(){
			try{
				mycommand.Connection = co;
				myadapter.SelectCommand = mycommand;
				mycommand.CommandText = "select * from data_belanja";
				DataSet ds = new DataSet();

				if (myadapter.Fill(ds,"dftpesan") > 0){
					dataGridView1.DataSource = ds;
					dataGridView1.DataMember = "dftpesan";
				}
			}
			catch (Exception ex){
				MessageBox.Show(ex.ToString());
			}
		}
		
		public void InsertData(){
			try{
				mycommand.Connection=co;
				mycommand.CommandText="insert into data_belanja values('"+nomorTextBox.Text+"','"+nameTextBox.Text+"','"+hargaTextBox.Text	+"','"+jumlahTextBox.Text+"')";
				myadapter.SelectCommand= mycommand;
				if (mycommand.ExecuteNonQuery()==1){
					MessageBox.Show("Data berhasil dimasukan","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
					ReadData();
					ResetData();
				}
			}
			catch(Exception ex){
				MessageBox.Show(ex.ToString());
			}
		}
		
		public void UpdateData(){
			try{
				mycommand.Connection=co;
				mycommand.CommandText = "update data_belanja set id='"+nomorTextBox.Text+"',nama_barang='"+nameTextBox.Text+"',harga_satuan='"+hargaTextBox.Text+"',jumlah='"+jumlahTextBox.Text+"' where id ='"+nomorTextBox.Text+"'";
				myadapter.SelectCommand = mycommand;
				if (mycommand.ExecuteNonQuery()==1){
					MessageBox.Show("Data berhasil diupdate","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
					ReadData();
				}
			}
			catch(Exception ex){
				MessageBox.Show(ex.ToString());
			}
		}
		
		public void DeleteData(){
			try{
				mycommand.Connection=co;
				mycommand.CommandText="delete from data_belanja where id='"+nomorTextBox.Text+"'";
				myadapter.SelectCommand = mycommand;
				if (mycommand.ExecuteNonQuery()==1){
					MessageBox.Show("Data berhasil dihapus","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
					ReadData();
				}
			}
			catch(Exception ex){
				MessageBox.Show(ex.ToString());
			}
		}
		
		public void ResetData(){
			nomorTextBox.Text="";
			nameTextBox.Text="";
			hargaTextBox.Text="";
			jumlahTextBox.Text="";
		}
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			co.Open();
			ReadData();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		
		
		void DataGridView1CellClick(object sender, DataGridViewCellEventArgs e)
		{
			nomorTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
			nameTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
			hargaTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
			jumlahTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
		}
		
		void ResetbtnClick(object sender, EventArgs e)
		{
			ResetData();
		}
		
		
		void InsertbtnClick(object sender, EventArgs e)
		{
			InsertData();
		}
		
		void UpdatebtnClick(object sender, EventArgs e)
		{
			UpdateData();
		}
		
		void DeletebtnClick(object sender, EventArgs e)
		{
			DeleteData();
		}
	}
}
