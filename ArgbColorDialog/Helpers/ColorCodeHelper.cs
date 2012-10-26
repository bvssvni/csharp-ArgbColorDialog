
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CutoutPro.Winforms.Helpers
{
	/// <summary>
	/// Description of ColorCodeHelper.
	/// </summary>
	public class ColorCodeHelper
	{
		private ArgbColorControl m_control;
		
		public void Step1_SetArgbColorControl(ArgbColorControl control)
		{
			m_control = control;
		}
		
		public void Step2_ColorCodeChanged()
		{
			TextBox code = m_control.code;
			Color color = Color.Black;
			ToolTip tip = m_control.tip;
			
			bool success = Utils.ColorFromHexString(code.Text, ref color);
			if (!success)
			{
				code.BackColor = Color.Red;
				tip.SetToolTip(code, "Use color format hexadecimal FFFFFF");
				return;
			}
			
			code.BackColor = SystemColors.Window;
			tip.SetToolTip(code, null);
			
			m_control.Settings.SetColor(Color.FromArgb(m_control.Color.A, color));
			RefreshColorHelper helper = new RefreshColorHelper();
			helper.Step1_SetArgbColorControl(m_control);
			helper.Step2_ChangeColorCode(false);
			helper.Step3_Refresh();
		}
	}
}
