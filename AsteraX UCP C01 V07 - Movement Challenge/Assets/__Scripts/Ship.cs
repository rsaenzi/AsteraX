using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Ship : MonoBehaviour
{

    private GameObject bulletPrefab;
    private Transform bulletContainer;

    void Awake()
    {
        bulletPrefab = Resources.Load<GameObject>("Prefabs/Bullet");
        bulletContainer = GameObject.Find("BulletContainer").transform;
    }

    // Start is called before the first frame update
    void Start()
    {

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
        newBullet.transform.position = transform.position;
    }
}