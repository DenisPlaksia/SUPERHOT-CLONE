using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Vladyslav Kopylets */

public class PickUp : MonoBehaviour
{

    public float rayLength;
    public float throwingForce;
    public Transform equipPosition;

    private bool isGrabbed = false;
    private GameObject currentWeapon;
    private GameObject tmp;

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            RaycastHit hit;
            if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, rayLength))
            {
                if (isGrabbed == false && hit.transform.tag == "Weapon")
                {
                    tmp = hit.transform.gameObject;
                    GrabWeapon();
                }

                else if(isGrabbed == true)
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

        isGrabbed = true;
    }

    public void ThrowWeapon()
    {
        currentWeapon.GetComponent<Rigidbody>().isKinematic = false;
        currentWeapon.GetComponent<Rigidbody>().AddForce(Camera.main.transform.forward * throwingForce, ForceMode.Impulse);
        currentWeapon.transform.parent = null;
        currentWeapon = null;

        isGrabbed = false;
    }
}
