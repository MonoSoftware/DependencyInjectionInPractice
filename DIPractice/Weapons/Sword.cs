﻿/*
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
    public class Sword : IWeapon
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Sword" /> class.
        /// </summary>
        /// <param name="weaponAction">The weapon action.</param>
        public Sword(ChoppedWeaponAction weaponAction)
        {
            this.WeaponAction = weaponAction;
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the action.
        /// </summary>
        /// <value>The action.</value>
        private IWeaponAction WeaponAction { get; set; }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Hits the specified target.
        /// </summary>
        /// <param name="target">The target.</param>
        public void Hit(string target)
        {
            Console.WriteLine("{0} {1} clean in half", WeaponAction.GetAction(), target);
        }

        #endregion Methods
    }
}