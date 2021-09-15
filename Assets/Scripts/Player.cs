using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    private Shoot gun;

    public void Start()
    {
        gun = bullet.GetComponent<Shoot>();
    }

    public void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
            gun.ShootCharge(bullet, this);

    }
}
