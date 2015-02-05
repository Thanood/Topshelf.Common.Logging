using Topshelf.HostConfigurators;

namespace Topshelf.Common.Logging {
	public static class CommonLoggingConfiguratorExtensions {
		public static void UseCommonLogging(this HostConfigurator configurator) {
			CommonLogWriterFactory.Use();
		}
	}
}
