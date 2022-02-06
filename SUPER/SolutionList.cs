using System;
using System.Windows.Forms;

namespace SUPER
{
	internal static class SolutionList
	{
		[STAThread]
		private static void MainLoad()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Main());
		}
	}
}
