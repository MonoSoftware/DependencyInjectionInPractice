using DIPractice.Common.Weapons;
using DIPractice.Ex.Weapons;
using System;

namespace DIPractice.Ex
{
    public class DIModule : Ninject.Modules.NinjectModule
    {
        #region Methods

        public override void Load()
        {
            Kernel.Rebind<ISword>().To<SwordEx>();
            Kernel.Rebind<IWeaponFactory>().To<WeaponFactoryEx>();
        }

        #endregion Methods
    }
}