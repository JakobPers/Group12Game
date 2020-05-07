using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{

    public float Health = 100f;

    public Slider HealthSlider;

    // Start is called before the first frame update
    void Start()
    {
        
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
}
