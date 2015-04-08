namespace Models.Interfaces
{
    public interface IItemShop
    {
        IWeapon WeaponUpgrade(IWeapon weapon);

        IItem ItemUpgrade(IItem item);
    }
}
