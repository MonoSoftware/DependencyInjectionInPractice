using System;

namespace DIPractice.Weapons
{
    public class Shuriken : IWeapon
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Shuriken" /> class.
        /// </summary>
        /// <param name="weaponAction">The weapon action.</param>
        public Shuriken(PiercedWeaponAction weaponAction)
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
            Console.WriteLine("{0} {1}'s armor", WeaponAction.GetAction(), target);
        }

        #endregion Methods
    }
}