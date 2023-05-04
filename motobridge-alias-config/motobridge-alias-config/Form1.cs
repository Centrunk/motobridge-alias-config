/*
*   Copyright (C) 2022 by N5UWU
*   This program is distributed WITHOUT WARRANTY.
*/

using CsvHelper;
using System.IO;
using System.Text;

namespace motobridge_alias_config
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private string path = "";
		private string opath = "";
		private string val1 = "";
		private string val2 = "";

		//private string[] output = new string[];
		private List<string> output = new List<string>();

		private void button4_Click(object sender, EventArgs e)
		{
			openFileDialog1.ShowDialog();
			textBox1.Text = openFileDialog1.FileName;
			path = openFileDialog1.FileName;
			//error handle
			if (path == "as2121ab")
			{
				path = "";
				MessageBox.Show("Please select a valid file");
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			//open file line by line
			//split strings by comma
			//put first half without comma in val1
			//put second half without comma in val2
			//put val1 and val2 in output array following format
			int i = 0;
			const Int32 BufferSize = 128;
			using (var fileStream = File.OpenRead(path))
			using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize))
			{
				output.Add("[VERSION]");
				output.Add("sysver=0006000006");
				output.Add("appver=4.5");
				output.Add("signature=1683151782");
				output.Add("GUupdated=1");
				output.Add("ACIM=0");
				i = 6;
				string line;
				while ((line = streamReader.ReadLine()) != null)
				{
					var linesplit = line.Split(",");
					val1 = linesplit[0];
					val2 = linesplit[1];
					output.Add("[" + val1 + "]");
					i++;
					output.Add("cN=" + val1);
					i++;
					output.Add("tID=0");
					i++;
					output.Add("ID=" + val2);
					i++;
				}
				System.IO.TextWriter tw;
				tw = new StreamWriter(opath);
				foreach (String s in output)
				{
					tw.WriteLine(s);
				}
				tw.Close();
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			saveFileDialog1.ShowDialog();
			textBox2.Text = saveFileDialog1.FileName;
			opath = saveFileDialog1.FileName;
			saveFileDialog1.Dispose();
		}
	}
}