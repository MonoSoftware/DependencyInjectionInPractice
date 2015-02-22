using DIPractice.Common.Weapons;
using Moq;
using System;

namespace DIPractice.Ex.Weapons
{
    internal class WeaponFactoryEx : IWeaponFactory
    {
        #region Methods

        /// <summary>
        /// Creates this instance.
        /// </summary>
        /// <returns></returns>
        public IDagger CreateDagger()
        {
            //Note: This will just skip the console output
            var target = new Mock<IDagger>();
            target.Setup(p => p.Hit(It.IsAny<string>()));
            return target.Object;
        }

        /// <summary>
        /// Creates the shuriken.
        /// </summary>
        /// <returns></returns>
        public IShuriken CreateShuriken()
        {
            //Note: This will just skip the console output
            var target = new Mock<IShuriken>();
            target.Setup(p => p.Hit(It.IsAny<string>()));
            return target.Object;
        }

        /// <summary>
        /// Creates the sword.
        /// </summary>
        /// <returns></returns>
        public ISword CreateSword()
        {
            return new SwordEx(new ChoppedWeaponActionEx());
        }

        #endregion Methods
    }
}