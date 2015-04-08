namespace Models.Gear.Shop
{
    using System;
    using System.Collections.Generic;

    using Models.Extensions;
    using Models.Gear.Items;
    using Models.Gear.Weapons;
    using Models.Interfaces;

    public struct GearInStock
    {
        private readonly IEnumerable<IWeapon> weapon;
        private readonly IEnumerable<IItem> item;

        public GearInStock(IEnumerable<IWeapon> weapon, IEnumerable<IItem> item)
        {
            this.weapon = weapon;
            this.item = item;
        }
    }
}
