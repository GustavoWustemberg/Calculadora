/*
 * Created by SharpDevelop.
 * User: GustavoWustemberg
 * Date: 04/06/2022
 * Time: 17:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Globalization;

namespace Calculadora
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		decimal value1 = 0, value2 = 0;
		string operation = "";
			
		public MainForm()
		{
			InitializeComponent();
			
			
		}
		void MainFormLoad(object sender, EventArgs e)
		{
	
		}
		void Button13Click(object sender, EventArgs e)
		{
			txtresult.Text +=  "0";
		}
		void Button9Click(object sender, EventArgs e)
		{
			txtresult.Text += "1";
		}
		void Button10Click(object sender, EventArgs e)
		{
			txtresult.Text += "2";
		}
		void Button11Click(object sender, EventArgs e)
		{
			txtresult.Text += "3";
		}
		void Button5Click(object sender, EventArgs e)
		{
			txtresult.Text += "4";
		}
		void Button6Click(object sender, EventArgs e)
		{
			txtresult.Text += "5";
		}
		void Button7Click(object sender, EventArgs e)
		{
			txtresult.Text += "6";
		}
		void Button1Click(object sender, EventArgs e)
		{
			txtresult.Text += "7";
		}
		void Button2Click(object sender, EventArgs e)
		{
			txtresult.Text += "8";
		}
		void Button3Click(object sender, EventArgs e)
		{
			txtresult.Text += "9";
		}
		void Button14Click(object sender, EventArgs e)
		{
			txtresult.Text += ".";
		}
		void Button4Click(object sender, EventArgs e)
		{
			if(txtresult.Text != "")
			{
				value1 = decimal.Parse(txtresult.Text, CultureInfo.InvariantCulture);
				txtresult.Text = "";
				operation = "Sum";
				lblOperation.Text = "+";
			}
			else
			{
				MessageBox.Show("Informe algum valor para efetuar a soma.");
			}
			
			
		}
		void Button18Click(object sender, EventArgs e)
		{
			value2 = decimal.Parse(txtresult.Text, CultureInfo.InvariantCulture);
			
			if(operation == "Sum")
			{
				txtresult.Text = Convert.ToString(value1 + value2);
			}
			else if(operation == "Subtraction")
			{
				txtresult.Text =Convert.ToString(value1 - value2);
			}
			else if(operation == "Multiplication")
			{
				txtresult.Text =Convert.ToString(value1 * value2);
			}
			else
			{
				txtresult.Text =Convert.ToString(value1 / value2);
			}
		}
		void Button8Click(object sender, EventArgs e)
		{	
			if(txtresult.Text != "")
			{
				value1 = decimal.Parse(txtresult.Text, CultureInfo.InvariantCulture);
				txtresult.Text = "";
				operation = "Subtraction";
				lblOperation.Text = "-";
			}
			else
			{
				MessageBox.Show("Informe algum valor para efetuar a subtrção.");
			}
		}
		void Button12Click(object sender, EventArgs e)
		{
			if(txtresult.Text != "")
			{
				value1 = decimal.Parse(txtresult.Text, CultureInfo.InvariantCulture);
				txtresult.Text = "";
				operation = "Multiplication";
				lblOperation.Text = "x";
			}
			else
			{
				MessageBox.Show("Informe algum valor para efetuar a multiplicação.");
			}
		}
		void Button15Click(object sender, EventArgs e)
		{
			if(txtresult.Text != "")
			{
				value1 = decimal.Parse(txtresult.Text, CultureInfo.InvariantCulture);
				txtresult.Text = "";
				operation = "Division";
				lblOperation.Text = "/";
			}
			else
			{
				MessageBox.Show("Informe algum valor para efetuar a divisão.");
			}
		}
		void Button16Click(object sender, EventArgs e)
		{
			txtresult.Text = "";
		}
		void Button17Click(object sender, EventArgs e)
		{
			txtresult.Text = "";
			value1 = 0;
			value2 = 0;
			lblOperation.Text = "";
		}
		void LblOperationClick(object sender, EventArgs e)
		{
	
		}
	}
}
