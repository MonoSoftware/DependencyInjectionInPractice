using DIPractice.Common.Weapons;
using DIPractice.Ex.Weapons;
using DIPractice.Weapons;
using System;

namespace DIPractice.Ex
{
    public class DIModule : Ninject.Modules.NinjectModule
    {
        #region Methods

        public override void Load()
        {
            Kernel.Rebind<ISword>().To<SwordEx>();
            Kernel.Rebind<IChoppedWeaponAction>().To<ChoppedWeaponActionEx>();
        }

        #endregion Methods
    }
}