
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using CutoutPro.Winforms;

namespace TestArgbColorDialog
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			Test_ColorConvertion_1();
			Test_ColorConvertion_2();
			Test_ColorConvertion_3();
			Test_ColorConvertion_4();
			Test_ColorConvertion_5();
			Test_ColorConvertion_6();
			Test_ColorConvertion_7();
		}
		
		private void Test_ColorConvertion_1()
		{
			string hex = "0000FF";
			Color c = Color.Black;
			bool success = Utils.ColorFromHexString(hex, ref c);
			Debug.Assert(success == true);
			Debug.Assert(c.B == 255);
			Debug.Assert(c.A == 255);
			Debug.Assert(c.R == 0);
			Debug.Assert(c.G == 0);
		}
		
		private void Test_ColorConvertion_2()
		{
			string hex = "00FEFF";
			Color c = Color.Black;
			bool success = Utils.ColorFromHexString(hex, ref c);
			Debug.Assert(success == true);
			Debug.Assert(c.B == 255);
			Debug.Assert(c.A == 255);
			Debug.Assert(c.R == 0);
			Debug.Assert(c.G == 254);
		}
		
		private void Test_ColorConvertion_3()
		{
			string hex = "FDFEFF";
			Color c = Color.Black;
			bool success = Utils.ColorFromHexString(hex, ref c);
			Debug.Assert(success == true);
			Debug.Assert(c.B == 255);
			Debug.Assert(c.A == 255);
			Debug.Assert(c.R == 253);
			Debug.Assert(c.G == 254);
		}
		
		private void Test_ColorConvertion_4()
		{
			string hex = "FDFE";
			Color c = Color.Black;
			bool success = Utils.ColorFromHexString(hex, ref c);
			Debug.Assert(success == true);
			Debug.Assert(c.B == 0);
			Debug.Assert(c.A == 255);
			Debug.Assert(c.R == 253);
			Debug.Assert(c.G == 254);
		}
		
		private void Test_ColorConvertion_5()
		{
			string hex = Utils.HexStringFromColor(Color.Blue);
			Debug.Assert(hex == "0000FF");
			
			hex = Utils.HexStringFromColor(Color.FromArgb(0, 254, 0));
			Debug.Assert(hex == "00FE00");
			
			hex = Utils.HexStringFromColor(Color.FromArgb(253, 0, 0));
			Debug.Assert(hex == "FD0000");
		}
		
		private void Test_ColorConvertion_6()
		{
			string hex = Utils.HexStringFromArgbColor(Color.FromArgb(255, 255, 0, 0));
			Debug.Assert(hex == "FF0000FF");
		}
		
		private void Test_ColorConvertion_7()
		{
			Color c = Color.Black;
			bool success = Utils.ArgbColorFromHexString("FFFEFDFC", ref c);
			Debug.Assert(success == true);
			Debug.Assert(c.R == 255);
			Debug.Assert(c.G == 254);
			Debug.Assert(c.B == 253);
			Debug.Assert(c.A == 252);
			
			// Check that when alpha is not added, that it evaluates to full intensity.
			success = Utils.ArgbColorFromHexString("FFFEFD", ref c);
			Debug.Assert(success == true);
			Debug.Assert(c.R == 255);
			Debug.Assert(c.G == 254);
			Debug.Assert(c.B == 253);
			Debug.Assert(c.A == 255);
		}
		
		void ColorDialogButtonClick(object sender, EventArgs e)
		{
			ArgbColorDialog dialog = new ArgbColorDialog();
			dialog.Color = Color.SkyBlue;
			if (dialog.ShowDialog() != DialogResult.OK) return;
		}
	}
}
