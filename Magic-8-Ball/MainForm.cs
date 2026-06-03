/*
 * Created by SharpDevelop.
 * User: Byro
 * Date: 3/6/2026
 * Time: 11:22 am
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Magic_8_Ball
{
	public partial class MainForm : Form
	{
		public string[] M8B_ans = 
			{
				//Affirmative Answers
				"It is certain",
				"It is decidedly so",
				"Without a doubt",
				"Yes definitely",
				"You may rely on it",
				"As I see it, yes",
				"Most likely",
				"Outlook good",
				"Yes",
				"Signs point to yes",
				//Non – Committal Answers
				"Reply hazy, try again",
				"Ask again later",
				"Better not tell you now",
				"Cannot predict now",
				"Concentrate and ask again",
				//Negative Answers
				"Don’t count on it",
				"My reply is no",
				"My sources say no",
				"Outlook not so good",
				"Very doubtful"
			};
			 public Random random = new Random();
		
		public MainForm() 
		{
			InitializeComponent();
			
		}
		public void TbxUserInputTextChanged(object sender, EventArgs e)
		{
			string userinput = tbxUserInput.Text;
		}
		public void BtnAsksClick(object sender, EventArgs e)
		{
			string ballshow = M8B_ans[random.Next(M8B_ans.Length)];
			MessageBox.Show(ballshow);
			tbxUserInput.Clear();
		}
	}
}
