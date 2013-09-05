using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Topshelf.Logging;

namespace Topshelf.Common.Logging {
	public class CommonLogWriterFactory : LogWriterFactory {
		public LogWriter Get(string name) {
			return new CommonLogWriter(name);
		}

		public void Shutdown() {
			//throw new NotImplementedException();
		}

		internal static void Use() {
			HostLogger.UseLogger(new CommonLoggingConfigurator());
		}
	}
}
