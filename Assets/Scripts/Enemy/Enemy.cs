using UnityEngine;

/* Denis Plaksia */
public class Enemy : MonoBehaviour
{

    private float health;
    private float timeBetweenAttack = 3f;
    private bool canAttack = false;

    //test version
    public GameObject bullet;
    public GameObject gun;  
    public void Attack()
    {
        if(!canAttack)
        {
            canAttack = true;
            Instantiate(bullet, gun.transform.position, Quaternion.identity);
            Invoke(nameof(ResetAttack), timeBetweenAttack);
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
