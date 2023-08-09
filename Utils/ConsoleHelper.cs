using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public static class ConsoleHelper
    {
		//This class will contain methods to better work with consoles in forms

		public static void UpdateConsoleText(string message)
		{
			if (txt_box_server_console.InvokeRequired)
				txt_box_server_console.Invoke(new Action<string>(UpdateConsoleText), $"{message}{Environment.NewLine}");
			else
				txt_box_server_console.Text += $"{message}{Environment.NewLine}";
		}
	}
}
