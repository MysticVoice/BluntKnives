using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GeneralItemScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private static int _stack = 1, _maxStack = 1;
    private static string _name, _type;

    public static int setName(string N) //self explanatory
    {

        _name = N;

        return 0;
    }

    public static int setType(string T) //self explanatory
    {

        _type = T;

        return 0;
    }

    public static int setMaxStack(int MX) //constraining max stack from 0 to 2147483647 (aka max int value)
    {

        if (MX < 0)
        {
            _maxStack = 0;
        }

        else
        {
            _maxStack = MX;
        }

        return 0;
    }

    public static int setStack(int S) //constraining stack from 0 to maxStack
    {

        if (S >= _maxStack)
        {

            _stack = _maxStack;

        }

        else if (S < 0)
        {
            _stack = 0;
        }

        else
        {
            _stack = S;
        }
        
        return 0;
    }

    public static string getName() //self explanatory
    {
        return _name;
    }

    public static string getType() //self explanatory
    {
        return _type;
    }

    public static int getStack() //self explanatory
    {
        return _stack;
    }

    public static int getMaxStack() //self explanatory
    {
        return _maxStack;
    }

    public static int consume(int C) //self explanatory
    {
        setStack(getStack() - C);

        return 0;
    }

}
