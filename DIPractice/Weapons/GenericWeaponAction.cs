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
    public class GenericWeaponAction : IWeaponAction
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="GenericWeaponAction" /> class.
        /// </summary>
        /// <param name="action">The action.</param>
        public GenericWeaponAction(string action)
        {
            this.Action = action;
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the action.
        /// </summary>
        /// <value>The action.</value>
        public string Action { get; set; }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Gets the weapon action.
        /// </summary>
        /// <returns>Action to perform.</returns>
        public string GetAction()
        {
            return Action;
        }

        #endregion Methods
    }
}