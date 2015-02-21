using System;

namespace DIPractice.Weapons
{
    public interface IGenericWeaponActionFactory
    {
        #region Methods

        //NOTE: This is Non-Abstract Factory, it is implementation specific and therefor anti-pattern

        /// <summary>
        /// Creates this instance.
        /// </summary>
        /// <param name="action">The action.</param>
        /// <returns></returns>
        IGenericWeaponAction Create(string action);

        #endregion Methods
    }

    internal class GenericWeaponActionFactory : IGenericWeaponActionFactory
    {
        #region Methods

        //NOTE: This is Non-Abstract Factory, it is implementation specific and therefor anti-pattern

        /// <summary>
        /// Creates this instance.
        /// </summary>
        /// <param name="action">The action.</param>
        /// <returns></returns>
        public IGenericWeaponAction Create(string action)
        {
            return new GenericWeaponAction(action);
        }

        #endregion Methods
    }
}