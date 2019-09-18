using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private int _maxH = 100, _H = 100; //health and max health whith a default value of 100

    
    Health() { } //if the health class is called without a variable it will keep the default values for health and max health


    Health(int maxH)    //when the Health class is called for the first time in a context you will eider provide both Current health and maxHealth or just maxHealth which will defoult Health to maxHealth
    {

        _H = maxH;
        _maxH = maxH;

    }

    Health(int H, int maxH)
    {

        if (H <= maxH)
        {

            _H = H;
            _maxH = maxH;

        }

        else
        {

            _H = maxH;
            _maxH = maxH;

        }

    }

    int getHealth() //self explanatory
    {
        return _H;
    }
    int getMaxHealth() //if you wuld ever need it
    {
        return _maxH;
    }

    int setHealth(int H) //self explanatory
    {

        if (H <= _maxH)
        {

            _H = H;

        }

        else
        {

            _H = _maxH;

        }

        return 0;
    }

    int setMaxHealth(int maxH) //for level-ups and sutch
    {
        _maxH = maxH;
        return 0;
    }

    bool alive() // quick way to check if you are alive
    {

        if (getHealth() > 0)
        {
            return true;
        }

        else
        {
            return false;
        }

    }

    int Heal(int H) //self explanatory
    {

        setHealth(getHealth() + H);

        return 0;
    }

    int Damage(int D) //self explanatory
    {

        setHealth(getHealth() - D);

        return 0;
    }

}
