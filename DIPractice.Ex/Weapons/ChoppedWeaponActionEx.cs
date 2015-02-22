using DIPractice.Weapons;
using System;

namespace DIPractice.Ex.Weapons
{
    public class ChoppedWeaponActionEx : IChoppedWeaponAction
    {
        #region Methods

        /// <summary>
        /// Gets the weapon action.
        /// </summary>
        /// <returns>Action to perform.</returns>
        public string GetAction()
        {
            return "Extended Chopped";
        }

        #endregion Methods
    }
}