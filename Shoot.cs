using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Transform Bulletspawn;
    Rigidbody2D clone;
    public Rigidbody2D bulletPrefap;
    public float bulletSpeed = 100f;


    void Attack()
    {
        clone = Instantiate(bulletPrefap, Bulletspawn.position, Bulletspawn.rotation);
        clone.AddForce(Bulletspawn.transform.right * bulletSpeed);

    }
}
