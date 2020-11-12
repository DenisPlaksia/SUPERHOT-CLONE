using UnityEngine;

/* Denis Plaksia */
public class Player : MonoBehaviour, IDamage
{
    private float health = 100f;
    private Weapon weapun;
    public PickUp pickUp;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Attack();
        }

        if (Input.GetMouseButtonDown(1))
        {
            TakeWeapon();
        }
    }

    private void TakeWeapon()
    {
        RaycastHit hit;
        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, pickUp.rayLength))
        {
            if (pickUp.isGrabbed == false && hit.transform.gameObject.GetComponent<Weapon>() != null)
            {
                weapun = pickUp.GrabWeapon(hit.transform.gameObject.GetComponent<Weapon>());
            }
            else if (pickUp.isGrabbed == true)
            {
                weapun = null;
                pickUp.ThrowWeapon();
            }
        }
    }
    private void Attack()
    {
        if (weapun == null)
        {

        }
        else
        {
            weapun.Shoot();
        }
    }
    private void DestroyPlayer() => Destroy(gameObject);
    public void GetDamage(float damage)
    {
        health -= damage;

        if (health <= 0)
            DestroyPlayer();
    }
}
