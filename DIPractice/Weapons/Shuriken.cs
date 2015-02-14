/*
 * Dependency Injection in Practice
 * Copyright 2015 Kristijan Horvat
 *
 * Examples taken from Ninject  Wiki
 * https://github.com/ninject/Ninject/wiki/
 *
 * */

using System;

namespace DIPractice.Weapons
{
    public class Shuriken : IWeapon
    {
        #region Methods

        /// <summary>
        /// Hits the specified target.
        /// </summary>
        /// <param name="target">The target.</param>
        public void Hit(string target)
        {
            Console.WriteLine("Pierced {0}'s armor", target);
        }

        #endregion Methods
    }
}