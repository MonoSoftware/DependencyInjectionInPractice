using System;
using System.Collections.Generic;

namespace DIPractice.Weapons
{
    public class Samurai : DIPractice.Warriors.IWarrior
    {
        #region Fields

        private readonly IDaggerFactory daggerFactory;
        private readonly List<IWeapon> weapons;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Samurai" /> class.
        /// </summary>
        /// <param name="weapons">The weapons.</param>
        /// <param name="daggerFactory">The dagger factory.</param>
        public Samurai(List<IWeapon> weapons, IDaggerFactory daggerFactory)
        {
            this.weapons = weapons;
            this.daggerFactory = daggerFactory;
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
                daggerFactory.Create().Hit(target);
            }
            this.weapons.ForEach(w => w.Hit(target));
        }

        #endregion Methods
    }
}