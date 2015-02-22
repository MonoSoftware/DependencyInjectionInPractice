using DIPractice.Common.Weapons;
using DIPractice.Weapons;
using System;

namespace DIPractice.Ex.Weapons
{
    public class SwordEx : ISword
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Sword" /> class.
        /// </summary>
        /// <param name="weaponAction">The weapon action.</param>
        public SwordEx(IChoppedWeaponAction weaponAction)
        {
            this.WeaponAction = weaponAction;
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the action.
        /// </summary>
        /// <value>The action.</value>
        private IWeaponAction WeaponAction { get; set; }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Hits the specified target.
        /// </summary>
        /// <param name="target">The target.</param>
        public void Hit(string target)
        {
            Console.WriteLine("SwordEx {0} {1} clean in half", WeaponAction.GetAction(), target);
        }

        #endregion Methods
    }
}