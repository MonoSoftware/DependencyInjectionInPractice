/*
 * Dependency Injection in Practice
 * Copyright 2015 Kristijan Horvat
 *
 * Examples taken from Ninject  Wiki
 * https://github.com/ninject/Ninject/wiki/
 *
 * */

using System;
using System.Collections.Generic;

namespace DIPractice.Weapons
{
    public class Samurai : DIPractice.Warriors.IWarrior
    {
        #region Fields

        private readonly List<IWeapon> weapons;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Samurai" /> class.
        /// </summary>
        /// <param name="weapons">The weapons.</param>
        public Samurai(List<IWeapon> weapons)
        {
            this.weapons = weapons;
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Attacks the specified target.
        /// </summary>
        /// <param name="target">The target.</param>
        public void Attack(string target)
        {
            this.weapons.ForEach(w => w.Hit(target));
        }

        #endregion Methods
    }
}