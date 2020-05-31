using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{

    private float Health;

    public Slider HealthSlider;

    // Start is called before the first frame update
    void Start()
    {
        Health = 100f;
    }

    // Update is called once per frame
    void Update()
    {

 
    }

    public void TakeDamage(float Damage)
    {
         Health -= Damage;
         HealthSlider.SetValueWithoutNotify(Health / 100f);        
    }

    public void PickUpHealth(float PickUp)
    {
        if (Health < 100)
        {
            Health += PickUp;

            if(Health > 100)
            {
                Health = 100f;
            }
            HealthSlider.SetValueWithoutNotify(Health / 100f);
        }
    }
}
