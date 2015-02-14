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
    public class Samurai
    {
        #region Fields

        private readonly IWeapon weapon;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Samurai" /> class.
        /// </summary>
        /// <param name="weapon">The weapon.</param>
        public Samurai(IWeapon weapon)
        {
            this.weapon = weapon;
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Attacks the specified target.
        /// </summary>
        /// <param name="target">The target.</param>
        public void Attack(string target)
        {
            this.weapon.Hit(target);
        }

        #endregion Methods
    }
}