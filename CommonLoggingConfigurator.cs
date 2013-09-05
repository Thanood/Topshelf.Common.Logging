using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Topshelf.Logging;

namespace Topshelf.Common.Logging {
	public class CommonLoggingConfigurator : HostLoggerConfigurator {
		public LogWriterFactory CreateLogWriterFactory() {
			return new CommonLogWriterFactory();
		}
	}
}
