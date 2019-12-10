using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStatsUIManager : MonoBehaviour
{

    public GameObject Object;

    public float point;
    public float maxPoint;

    public Image Bar;

    public bool health;
    public bool BowCharge;

    private void Start()
    {
        if (health && !BowCharge)
        {
            maxPoint = Object.GetComponent<PlayerStats>().StartHealth;
        }
        if (BowCharge && !health)
        {
            maxPoint = Object.GetComponent<BowControl>().Chargemax;
        }
    }

    private void Update()
    {
        if (Object.gameObject != null)
        {
            if (health && !BowCharge)
            {
                point = Object.GetComponent<PlayerStats>().Health;
            }
            if (BowCharge && !health)
            {
                point = Object.GetComponent<BowControl>()._charge;
            }
            float ratio = point / maxPoint;
            Bar.rectTransform.localScale = new Vector3(ratio, 1, 1);
        }
        else
        {
            Bar.rectTransform.localScale = new Vector3(0, 1, 1);
        }


    }

}
