using DIPractice.Common.Warriors;
using DIPractice.Common.Weapons;
using DIPractice.Weapons;
using Ninject;
using Ninject.Extensions.Factory;
using System;

namespace DIPractice
{
    public class Program
    {
        #region Methods

        private static void Attack(IKernel kernel)
        {
            var warrior1 = kernel.Get<IWarrior>();
            warrior1.Attack("the evildoers");
            warrior1.Attack("the enemy");
        }

        /// <summary>
        /// Mains the specified arguments.
        /// </summary>
        /// <param name="args">The arguments.</param>
        private static void Main(string[] args)
        {
            //NOTE: Composition Root
            IKernel kernel = new StandardKernel();
            kernel.Bind<IDagger>().To<Dagger>();
            kernel.Bind<IDaggerFactory>().ToFactory();
            kernel.Bind<IChoppedWeaponAction>().To<ChoppedWeaponAction>().InSingletonScope();
            kernel.Bind<IShuriken>().To<Shuriken>();
            kernel.Bind<IWeapon>().To<Shuriken>();
            kernel.Bind<ISword>().To<Sword>();
            kernel.Bind<IWeapon>().To<Sword>();
            kernel.Bind<IWeaponFactory>().ToFactory();
            kernel.Bind<IWarrior>().To<Samurai>();

            kernel.Load(new DIPractice.Ex.DIModule());

            Attack(kernel);
        }

        #endregion Methods
    }
}