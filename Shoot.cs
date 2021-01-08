using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Transform Bulletspawn;
    Rigidbody2D clone;
    public Rigidbody2D bulletPrefap;
    public float bulletSpeed = 100f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Attack()
    {
        clone = Instantiate(bulletPrefap, Bulletspawn.position, Bulletspawn.rotation);
        clone.AddForce(Bulletspawn.transform.right * bulletSpeed);

    }
}
