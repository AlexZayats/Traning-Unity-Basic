using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            var newBullet = Instantiate(bullet, transform.position + transform.right, Quaternion.identity);
            newBullet.GetComponent<Rigidbody>().AddForce(transform.forward * 50);
            //StartCoroutine(DestroyBullet(newBullet));
        }
    }
}
