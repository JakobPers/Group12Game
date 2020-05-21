using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{

    
    public GameObject gameOverObject; 

    public float Health = 100f;

    public Slider HealthSlider;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        if (Health <= 0) {
            PlayerDead ();
        }
    }

    public void PlayerDead () 
    {
        gameOverObject.SetActive (true);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None; 
        // Camera.main.GetComponent<camerafollow>().enabled = false;
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
