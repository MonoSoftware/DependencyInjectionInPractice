using System;

namespace DIPractice.Weapons
{
    public class Samurai : DIPractice.Warriors.IWarrior
    {
        #region Fields

        private readonly IWeaponFactory weaponFactory;

        #endregion Fields

        #region Properties

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        protected long Id { get; private set; }

        #endregion Properties

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Samurai" /> class.
        /// </summary>
        /// <param name="weaponFactory">The weapon factory.</param>
        public Samurai(IWeaponFactory weaponFactory)
        {
            this.weaponFactory = weaponFactory;
            this.Id = DateTime.UtcNow.Ticks;
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Attacks the specified target.
        /// </summary>
        /// <param name="target">The target.</param>
        public void Attack(string target)
        {
            Console.WriteLine("Samurai id: {0}", Id);
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