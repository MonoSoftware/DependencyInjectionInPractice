using System;

namespace DIPractice.Common.Weapons
{
    public interface IWeaponFactory
    {
        #region Methods

        /// <summary>
        /// Creates the dagger.
        /// </summary>
        /// <returns></returns>
        IDagger CreateDagger();

        /// <summary>
        /// Creates the shuriken.
        /// </summary>
        /// <returns></returns>
        IShuriken CreateShuriken();

        /// <summary>
        /// Creates the sword.
        /// </summary>
        /// <returns></returns>
        ISword CreateSword();

        #endregion Methods
    }
}