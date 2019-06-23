using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Ship : MonoBehaviour
{

    private GameObject bulletPrefab;
    private Transform bulletContainer;
    private Transform turret;

    void Awake()
    {
        bulletPrefab = Resources.Load<GameObject>("Prefabs/Bullet");
        bulletContainer = GameObject.Find("BulletContainer").transform;
        turret = transform.Find("TurretRotator");
    }

    // Update is called once per frame
    void Update()
    {
        // Fire
        if (CrossPlatformInputManager.GetButtonDown("Fire1"))
        {
            Fire();
        }
    }

    private void Fire()
    {
        GameObject newBullet = Instantiate(bulletPrefab, bulletContainer, true);
        newBullet.transform.position = turret.position;
        newBullet.transform.rotation = turret.rotation;
    }
}