using DIPractice.Common.Weapons;
using System;

namespace DIPractice.Weapons
{
    public class Samurai : DIPractice.Common.Warriors.IWarrior
    {
        #region Fields

        private readonly IWeaponFactory weaponFactory;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Samurai" /> class.
        /// </summary>
        /// <param name="weaponFactory">The weapon factory.</param>
        public Samurai(IWeaponFactory weaponFactory)
        {
            this.weaponFactory = weaponFactory;
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Attacks the specified target.
        /// </summary>
        /// <param name="target">The target.</param>
        public void Attack(string target)
        {
            if (target.Contains("enemy"))
            {
                weaponFactory.CreateDagger().Hit(target);
            }
            else
            {
                weaponFactory.CreateSword().Hit(target);
                weaponFactory.CreateShuriken().Hit(target);
            }
        }

        #endregion Methods
    }
}