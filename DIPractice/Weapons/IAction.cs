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
    public interface IWeaponAction
    {
        #region Methods

        /// <summary>
        /// Gets the warrior action.
        /// </summary>
        /// <returns>Action to perform.</returns>
        string GetAction();

        #endregion Methods
    }
}