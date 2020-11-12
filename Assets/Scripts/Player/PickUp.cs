using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Vladyslav Kopylets */

public class PickUp : MonoBehaviour
{

    public float rayLength = 10f;
    public float throwingForce;
    public Transform equipPosition;

    public bool isGrabbed = false;
    private Weapon currentWeapon;
    //public  Weapon tmp;

    public Weapon GrabWeapon(Weapon tmp)
    {
        currentWeapon = tmp;
        currentWeapon.transform.position = equipPosition.position;
        currentWeapon.transform.parent = equipPosition;
        currentWeapon.transform.localEulerAngles = new Vector3(0, 0, 0);
        currentWeapon.GetComponent<Rigidbody>().isKinematic = true;

        isGrabbed = true;
        return currentWeapon;
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
