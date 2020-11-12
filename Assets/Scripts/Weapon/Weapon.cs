using UnityEngine;

/* Denis Plaksia */
public class Weapon : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private GameObject spawnPoint;

    //Ray for bullet direction
    public static Ray Ray { get; private set; }
    public int AmountAmmo { get; private set; }

    protected virtual void RandomAmountAmmo(int maxAmmoutAmmo) => AmountAmmo = Random.Range(1, maxAmmoutAmmo);
    
    private bool CheckAmmoAmount() => (AmountAmmo > 0) ? true : false;

    public virtual void Shoot()
    {
        if (CheckAmmoAmount())
        {
            Ray = new Ray(transform.position, transform.forward);
            Instantiate(bullet, spawnPoint.transform.position, bullet.transform.rotation);
            AmountAmmo--;
        }
    }
}
