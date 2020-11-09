using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Vladyslav Kopylets */

public class PickUp : MonoBehaviour
{

    public float rayLength = 10;
    public Transform equipPosition;

    private bool isGrabbed = false;
    private GameObject currentWeapon;
    private GameObject tmp;
    // Start is called before the first frame update
    private void Start()
    {


    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            RaycastHit hit;
            if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, rayLength))
            {
                Debug.Log(hit.transform.tag);

                if (isGrabbed == false && hit.transform.tag == "Weapon")
                {
                    tmp = hit.transform.gameObject;
                    GrabWeapon();
                }

                else
                    ThrowWeapon();
                
            }
        }
    }

    public void GrabWeapon()
    {
        currentWeapon = tmp;
        currentWeapon.transform.position = equipPosition.position;
        currentWeapon.transform.parent = equipPosition;
        currentWeapon.transform.localEulerAngles = new Vector3(0, 180, 0);
        currentWeapon.GetComponent<Rigidbody>().isKinematic = true;
        Debug.Log("yes");
        isGrabbed = true;
    }

    public void ThrowWeapon()
    {
        Debug.Log("no");
        isGrabbed = false;
    }
}
