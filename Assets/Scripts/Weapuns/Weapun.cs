using UnityEngine;

/* Denis Plaksia */
public class Weapun : MonoBehaviour
{
    private static Ray ray;
    [SerializeField] private GameObject bullet;
    [SerializeField] private GameObject spawnPoint;

    public int AmountAmmo { get; private set; }
    public static Ray Ray { get => ray; private set => ray = value; }

    private void Start()
    {
        RandomAmountAmmo();
    }
    private void RandomAmountAmmo() => AmountAmmo = Random.Range(1, 8);
    
    private bool CheckAmmoAmount() => (AmountAmmo > 0) ? true : false;

    public void Shoot()
    {
        if (CheckAmmoAmount())
        {
            Ray = new Ray(transform.position, transform.forward);
            Instantiate(bullet, spawnPoint.transform.position, bullet.transform.rotation);
            AmountAmmo--;
        }
    }
}
