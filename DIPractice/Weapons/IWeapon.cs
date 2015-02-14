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
    public interface IWeapon
    {
        #region Methods

        /// <summary>
        /// Hits the specified target.
        /// </summary>
        /// <param name="target">The target.</param>
        void Hit(string target);

        #endregion Methods
    }
}