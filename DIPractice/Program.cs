/*
 * Dependency Injection in Practice
 * Copyright 2015 Kristijan Horvat
 *
 * Examples taken from Ninject  Wiki
 * https://github.com/ninject/Ninject/wiki/
 *
 * */

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
            kernel.Bind<IWarrior>().To<Samurai>();
            kernel.Bind<IWeapon>().To<Shuriken>();

            var warrior1 = kernel.Get<IWarrior>();
            warrior1.Attack("the evildoers");
        }

        #endregion Methods
    }
}