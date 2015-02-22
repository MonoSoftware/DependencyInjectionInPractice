using System;

namespace DIPractice.Weapons
{
    public class ChoppedWeaponAction : IChoppedWeaponAction
    {
        #region Methods

        /// <summary>
        /// Gets the weapon action.
        /// </summary>
        /// <returns>Action to perform.</returns>
        public string GetAction()
        {
            return "Chopped";
        }

        #endregion Methods
    }
}