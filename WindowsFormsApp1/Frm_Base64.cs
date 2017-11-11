using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace WindowsFormsApp1
{
	public partial class Frm_BiwTestBase64Frm : Form
	{
		public Frm_BiwTestBase64Frm()
		{
			InitializeComponent();
		}

		private string EncodeBase64(Encoding encode, string source)
		{
			string enString = "";

			try
			{
				byte[] bytes = encode.GetBytes(source);
				enString = Convert.ToBase64String(bytes);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			return enString;

		}


		private string EncodeBase64(string source)
		{
			return EncodeBase64(Encoding.UTF8, source);
		}


		private string DecodeBase64(Encoding encode, string result)
		{
			string decode = "";
			try
			{
				byte[] bytes = Convert.FromBase64String(result);
				decode = encode.GetString(bytes);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			return decode;
		}


		private string DecodeBase64(string result)
		{
			return DecodeBase64(Encoding.UTF8, result);
		}

		private void Btn_Encode_Click(object sender, EventArgs e)
		{
			if (this.Txt_Encode.Text.Trim() == "")
			{
				MessageBox.Show("请输入字符并进行编码");
			}
			else
			{

				Txt_Decode.Text = EncodeBase64(Txt_Encode.Text);
				Btn_WriteXml.Enabled = true;
			}
		}
		private void Btn_Decode_Click(object sender, EventArgs e)
		{
			if (this.Txt_Decode.Text.Trim() == "")
			{
				MessageBox.Show("请输入字符并进行解码");
			}
			else
			{
				Txt_Encode.Text = DecodeBase64(Txt_Decode.Text);
				Btn_WriteXml.Enabled = true;
			}
		}
		private void Txt_Change(object sender, EventArgs e)
		{
			this.Btn_WriteXml.Enabled = false;
		}
		private void Btn_WriteXml_Click(object sender, EventArgs e)
		{
			if (this.Txt_SaveLocal.Text.Trim() == "")
			{
				MessageBox.Show("请选择保存路径");
			}
			else
			{
				XmlDocument doc = new XmlDocument();
				XmlElement Base64s;
				if (File.Exists(Txt_SaveLocal.Text + "\\Base64.xml"))
				{
					doc.Load(Txt_SaveLocal.Text + "\\Base64.xml");
					Base64s = doc.DocumentElement;
				}
				else
				{
					XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf-8", null);
					doc.AppendChild(dec);
					Base64s = doc.CreateElement("Base64s");
					doc.AppendChild(Base64s);
				}
				XmlElement Base64 = doc.CreateElement("Base64");
				Base64s.AppendChild(Base64);
				XmlElement Encode = doc.CreateElement("Encode");
				Encode.InnerText = Txt_Encode.Text;
				Base64.AppendChild(Encode);
				XmlElement Decode = doc.CreateElement("Decode");
				Decode.InnerText = Txt_Decode.Text;
				Base64.AppendChild(Decode);
				doc.Save(Txt_SaveLocal.Text + "\\Base64.xml");
				MessageBox.Show("添加成功");

			}

		}
			private void Btn_Local_Click(object sender, EventArgs e)
			{
				FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
				if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)//打开文件夹对话框
					this.Txt_SaveLocal.Text = folderBrowserDialog1.SelectedPath;
			}
		}
	}
