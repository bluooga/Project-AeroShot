using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowControl : MonoBehaviour
{

    public GameObject ArrowPrefab;
    public Vector3 objectSpawnOffset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            FireArrow();
        }
    }

    void FireArrow()
    {
        Instantiate(ArrowPrefab, transform.forward + objectSpawnOffset, Quaternion.Euler(0, transform.rotation.y, 0));
    }

}
