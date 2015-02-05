using Topshelf.Logging;

namespace Topshelf.Common.Logging {
	public class CommonLoggingConfigurator : HostLoggerConfigurator {
		public LogWriterFactory CreateLogWriterFactory() {
			return new CommonLogWriterFactory();
		}
	}
}
