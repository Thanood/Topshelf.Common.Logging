using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Topshelf.HostConfigurators;

namespace Topshelf.Common.Logging {
	public static class CommonLoggingConfiguratorExtensions {
		public static void UseCommonLogging(this HostConfigurator configurator) {
			CommonLogWriterFactory.Use();
		}
	}
}
