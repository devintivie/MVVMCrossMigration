using Microsoft.Extensions.Logging;
using MvvmCross.IoC;
using MvvmCross.Platforms.Wpf.Core;
using MvvmCross.Platforms.Wpf.Presenters;
using Serilog;
using Serilog.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace MVVMCrossMigration.DesktopApp
{
    public class Setup : MvxWpfSetup<Core.App>
    {
        protected override ILoggerProvider CreateLogProvider()
        {
            return new SerilogLoggerProvider();
        }

        protected override ILoggerFactory CreateLogFactory()
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .CreateLogger();

            return new SerilogLoggerFactory();
        }

        //protected override IDictionary<Type, Type> InitializeLookupDictionary(IMvxIoCProvider iocProvider)
        //{
        //    var tmp = base.InitializeLookupDictionary(iocProvider);
        //    return tmp;
        //}

        protected override IMvxWpfViewPresenter CreateViewPresenter(ContentControl root)
        {
            return new GeneralWpfViewPresenter(root);
        }
    }
}
