using DIPractice.Warriors;
using DIPractice.Weapons;
using Ninject;
using System;

namespace DIPractice
{
    public class Program
    {
        #region Methods

        /// <summary>
        /// Mains the specified arguments.
        /// </summary>
        /// <param name="args">The arguments.</param>
        private static void Main(string[] args)
        {
            IKernel kernel = new StandardKernel();
            kernel.Bind<IDagger>().To<Dagger>();
            kernel.Bind<IDaggerFactory>().To<DaggerFactory>();

            kernel.Bind<IWeapon>().To<Shuriken>();
            kernel.Bind<IWeapon>().To<Sword>();
            kernel.Bind<IWarrior>().To<Samurai>();

            var warrior1 = kernel.Get<IWarrior>();
            warrior1.Attack("the evildoers");
            warrior1.Attack("the enemy");
        }

        #endregion Methods
    }
}