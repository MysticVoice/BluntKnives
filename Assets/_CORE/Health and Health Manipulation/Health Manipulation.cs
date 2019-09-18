using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HealthManipulation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static int Heal(int H) //self explanatory
    {

        Health.setHealth(Health.getHealth() + H);

        return 0;
    }

    public static int Damage(int D) //self explanatory
    {

        Health.setHealth(Health.getHealth() - D);

        return 0;
    }
}
