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
    public class ChoppedWeaponAction : IWeaponAction
    {
        #region Methods

        /// <summary>
        /// Gets the weapon action.
        /// </summary>
        /// <returns>Action to perform.</returns>
        public string GetAction()
        {
            return "Chopped";
        }

        #endregion Methods
    }
}