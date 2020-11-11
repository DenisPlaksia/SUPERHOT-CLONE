using UnityEngine;


public class Bullet : MonoBehaviour
{
    private Rigidbody rb;
    private float force = 20f;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        BulletPush();
    }

    private void BulletPush() => rb.AddForce(Weapun.Ray.direction * force, ForceMode.Impulse);

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<IDamage>() != null)
        {
            collision.gameObject.GetComponent<IDamage>().GetDamage(100f);
        }
    }
}
