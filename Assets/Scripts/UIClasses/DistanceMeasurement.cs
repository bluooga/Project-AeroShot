using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DistanceMeasurement : MonoBehaviour
{

    float distance;

    public TextMeshProUGUI Object;
    public TextMeshProUGUI Distance;
    public TextMeshProUGUI Health;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {


        RaycastHit hit;
        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit)){
            Object.SetText("Object: " + hit.transform.name);
            Distance.SetText("Distance: " + hit.distance.ToString("F2") + " m");
            if (hit.transform.GetComponent<EntityScript>() != null)
            {
                Health.SetText("Health: " + hit.transform.GetComponent<EntityScript>().Health.ToString("F1"));
            }
            if (hit.transform.GetComponent<EnemyScript>() != null)
            {
                Object.SetText("Entity: " + hit.transform.GetComponent<EnemyScript>().EnemyType);
            }
            if (hit.transform.GetComponent<EntityScript>() == null)
            {
                Health.SetText(" ");
            }
        }
        else
        {
            Object.SetText("Object: ");
            Distance.SetText("Distance: ");
            Health.SetText(" ");
        }

    }
}
