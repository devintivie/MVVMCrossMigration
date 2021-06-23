using MvvmCross.ViewModels;
using MVVMCrossMigration.Core.ViewModels;
using System;

namespace MVVMCrossMigration.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            RegisterAppStart<RootViewModel>();
        }
    }
}
