using UnityEngine;

/* Denis Plaksia */
public class Player : MonoBehaviour, IDamage
{
    private float health = 100f;
    public Weapun weapun;


    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Attack();
        }
    }

    private void Attack()
    {
        weapun.Shoot();
    }
    private void DestroyPlayer() => Destroy(gameObject);


    public void GetDamage(float damage)
    {
        health -= damage;

        if (health <= 0)
            DestroyPlayer();
    }
}
