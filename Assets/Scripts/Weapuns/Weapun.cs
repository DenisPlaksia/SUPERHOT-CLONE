using UnityEngine;

public class Weapun : MonoBehaviour
{
    public int amountAmmo;

    public static Ray ray1;
    //test variant
    public GameObject bullet;
    public GameObject point;

    private void Start()
    {
        amountAmmo = Random.Range(1, 16);
    }

    private void Update()
    {
        //RaycastHit raycastHit;
        ray1 = new Ray(transform.position, transform.forward);
        Debug.Log(ray1.direction);
        Debug.DrawRay(transform.position,transform.forward * 100f,Color.red);
        if (Input.GetMouseButtonDown(0))
        {
            Shot();
        }
    }
    public void Shot()
    {
        if(CheckAmmoAmount())
        {         
            
            Instantiate(bullet, point.transform.position, bullet.transform.rotation);
            //amountAmmo--;
        }
    }

    private bool CheckAmmoAmount() => (amountAmmo > 0) ? true : false;
}
