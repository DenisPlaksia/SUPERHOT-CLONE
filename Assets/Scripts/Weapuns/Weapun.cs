using UnityEngine;

/* Denis Plaksia */
public class Weapun : MonoBehaviour
{
    public int amountAmmo;
    public static Ray ray1;
    //test variant
    public GameObject bullet;
    public GameObject point;

    private void Start()
    {
        amountAmmo = Random.Range(1, 16);
    }

    public void Shoot()
    {
        if(CheckAmmoAmount())
        {
            ray1 = new Ray(transform.position, transform.forward);
            Instantiate(bullet, point.transform.position, bullet.transform.rotation);
            amountAmmo--;
        }
    }

    private bool CheckAmmoAmount() => (amountAmmo > 0) ? true : false;
}
