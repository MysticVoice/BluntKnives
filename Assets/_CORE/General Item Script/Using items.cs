using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Usingitems : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static int use(int U) //Sample tamplate for using items
    {
        //whatever we want it to do

        GeneralItemScript.consume(U);

        return 0;
    }

}
