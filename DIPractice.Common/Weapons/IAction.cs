using System;

namespace DIPractice.Common.Weapons
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