using UnityEngine;


public class Bullet : MonoBehaviour
{
    private Rigidbody rb;
    private float force = 1000f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * force * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.GetComponent<Player>() != null)
        {
            collision.gameObject.GetComponent<Player>().GetDamage(100f);
        }
        else
        {
            Destroy(gameObject,100f);
        }
    }
}
