
public class Shotgun : Weapon
{
    public int maxAmmoutAmmo = 8;

    private void Start()
    {
        RandomAmountAmmo(maxAmmoutAmmo);
    }
    protected override void RandomAmountAmmo(int maxAmmoutAmmo)
    {
        base.RandomAmountAmmo(maxAmmoutAmmo);
    }

    public override void Shoot()
    {
        base.Shoot();
    }
}
