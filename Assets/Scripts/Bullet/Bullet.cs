using UnityEngine;


public class Bullet : MonoBehaviour
{
    private Rigidbody rb;
    private float force = 20f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(Weapun.ray1.direction * force, ForceMode.Impulse);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<IDamage>() != null)
        {
            collision.gameObject.GetComponent<IDamage>().GetDamage(100f);
        }
    }
}
