using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BowControl : MonoBehaviour
{

    public float _charge;

    public float Chargemax;
    public float ChargeRate;

    public string DrawButton;

    public Rigidbody ArrowPrefab;
    public Transform Spawn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton(DrawButton) && _charge < Chargemax)
        {
            _charge += Time.deltaTime * ChargeRate;
            Debug.Log(_charge.ToString());
        }

        if (Input.GetButtonUp(DrawButton))
        {
            FireArrow(_charge);
        }

    }

    void FireArrow(float ShootingForce)
    {
        Rigidbody arrow = Instantiate(ArrowPrefab, Spawn.position, transform.rotation) as Rigidbody;
        arrow.GetComponent<ArrowClass>().Damage = ShootingForce;
        arrow.AddForce(Spawn.up * -ShootingForce, ForceMode.Impulse);

        _charge = 0;
    }

}
