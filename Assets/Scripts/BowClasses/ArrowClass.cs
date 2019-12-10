using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowClass : MonoBehaviour
{

    Rigidbody rb;
    [SerializeField] public float Damage;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.LookRotation(rb.velocity);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<EntityScript>() != null)
        {
            other.gameObject.GetComponent<EntityScript>().TakeDamage(Damage);
        }   
    }


    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }

}
