using DIPractice.Common.Weapons;
using System;

namespace DIPractice.Weapons
{
    internal class WeaponFactory : IWeaponFactory
    {
        #region Methods

        /// <summary>
        /// Creates this instance.
        /// </summary>
        /// <returns></returns>
        public IDagger CreateDagger()
        {
            return new Dagger();
        }

        /// <summary>
        /// Creates the shuriken.
        /// </summary>
        /// <returns></returns>
        public IShuriken CreateShuriken()
        {
            return new Shuriken(new PiercedWeaponAction());
        }

        /// <summary>
        /// Creates the sword.
        /// </summary>
        /// <returns></returns>
        public ISword CreateSword()
        {
            return new Sword(new ChoppedWeaponAction());
        }

        #endregion Methods
    }
}