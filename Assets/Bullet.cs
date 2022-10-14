using UnityEngine;
//using UnityEngine.Input;
using UnityEngine.InputSystem;

using System.Collections;

public class Bullet : MonoBehaviour
{ 
public GameObject projectile;
    public float projectileForce = 10000f;

    public void Onfire(InputAction.CallbackContext context)
    {

            //GameObject go = Instantiate(projectile);
            GameObject bullet = Instantiate(projectile, transform.position, Quaternion.identity) as GameObject;
            bullet.GetComponent<Rigidbody>().AddForce(transform.forward);




    }













    //public void OnFire(InputAction inputAction)



    //void Update()
    //{
    //if (Input.GetKeyDown(KeyCode.Space))
    //{

    //    GameObject bullet = Instantiate(projectile, transform.position, Quaternion.identity) as GameObject;
    //    bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 10000);

    //}
    // }
}