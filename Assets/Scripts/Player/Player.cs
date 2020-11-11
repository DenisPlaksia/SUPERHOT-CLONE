using UnityEngine;

public class Player : MonoBehaviour, IDamage
{
    private float health = 100f;

    public void GetDamage(float damage)
    {
        health -= damage;

        if (health <= 0)
            DestroyPlayer();
    }

    private void DestroyPlayer() => Destroy(gameObject);
}
