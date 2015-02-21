using System;

namespace DIPractice.Weapons
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