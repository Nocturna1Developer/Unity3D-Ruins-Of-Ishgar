using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuel : MonoBehaviour
{
    float fuelCooldown = 3f; 

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            fuelCooldown -= Time.deltaTime;
            Debug.Log(fuelCooldown);

            if (fuelCooldown <= 0)
            {
                fuelCooldown = 3f; 
            }
        }
    }
}