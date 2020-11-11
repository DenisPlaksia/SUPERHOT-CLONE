using UnityEngine;

/* Denis Plaksia */
public class Enemy : MonoBehaviour, IDamage
{

    private float health = 100f;
    private float timeBetweenAttack = 1.5f;
    private bool canAttack = false;

    //test version
    public Weapun weapun;
    public void Attack()
    {
        if(!canAttack)
        {
            canAttack = true;
            weapun.Shoot();
            Invoke(nameof(ResetAttack), timeBetweenAttack);
        }
    }
    private void ResetAttack() => canAttack = false;

    public void GetDamage(float damage)
    {
        health -= damage;

        if (health <= 0)
        {
            DestroyEnemy();
        }
    }

    private void DestroyEnemy() => Destroy(gameObject);

}
