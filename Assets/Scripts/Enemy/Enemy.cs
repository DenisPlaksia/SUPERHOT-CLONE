using UnityEngine;

/* Denis Plaksia */
public class Enemy : MonoBehaviour
{

    private float health;
    //test version
    public GameObject bullet;
    public GameObject gun;


    public bool canAttack = false;
    public void Attack()
    {
        if(!canAttack)
        {
            canAttack = true;
            Instantiate(bullet, gun.transform.position, Quaternion.identity);
            Invoke(nameof(ResetAttack), 5f);
        }
    }


    private void ResetAttack()
    {
        canAttack = false;
    }


    public void GetDamage(float damage)
    {
        health -= damage;

        if (health <= 0)
            DestroyEnemy();
    }

    private void DestroyEnemy() => Destroy(gameObject);

}
