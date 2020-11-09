using UnityEngine;


public class Bullet : MonoBehaviour
{
    private Rigidbody rb;
    private float force = 25f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(Vector3.right * force,ForceMode.Impulse);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.GetComponent<Player>() != null)
        {
            collision.gameObject.GetComponent<Player>().GetDamage(100f);
        }
    }
}
