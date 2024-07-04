using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sample;

namespace ConsoleApp
{
	internal class Program
	{
		static void Main(string[] args)
		{
			MonitorUpdaterManagerSample.UpdateMonitor("C:\\tmp\\monitor", "C:\\tmp\\installation", "1.0");
		}
	}
}
