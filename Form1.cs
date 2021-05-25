using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeechText
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			
		}

		private  async void button2_Click(object sender, EventArgs e)
		{
			string[] Subscription = { Program.speech_key, Program.service_region };
			await Program.RecognizeSpeechAsync(Subscription);
			textBox1.Text = Program.showMsg;
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}
