using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weaponchange : MonoBehaviour
{
    public bool[] isweaponavailable = {false,false,false,false,false,false,false,false,false};

    public GameObject[] weapons;

    public int curweaponindex;

    void OnWeapon1()
    {
        if(isweaponavailable[0])
        {
            curweaponindex = 0;
        }
        SelectWeapon();
    }
    void OnWeapon2()
    {
        if(isweaponavailable[1])
        {
            curweaponindex = 1;
        }
        SelectWeapon();
    }
    void OnWeapon3()
    {
        if(isweaponavailable[2])
        {
            curweaponindex = 2;
        }
        SelectWeapon();
    }
    void OnWeapon4()
    {
        if(isweaponavailable[3])
        {
            curweaponindex = 3;
        }
        SelectWeapon();
    }
    void OnWeapon5()
    {
        if(isweaponavailable[4])
        {
            curweaponindex = 4;
        }
        SelectWeapon();
    }
    void OnWeapon6()
    {
        if(isweaponavailable[5])
        {
            curweaponindex = 5;
        }
        SelectWeapon();
    }
    void OnWeapon7()
    {
        if(isweaponavailable[6])
        {
            curweaponindex = 6;
        }
        SelectWeapon();
    }
    void OnWeapon8()
    {
        if(isweaponavailable[7])
        {
            curweaponindex = 7;
        }
        SelectWeapon();
    }
    void OnWeapon9()
    {
        if(isweaponavailable[8])
        {
            curweaponindex = 8;
        }
        SelectWeapon();
    }

    void Start()
    {
        SelectWeapon();
    }

    void SelectWeapon()
    {
        int i = 0;
        foreach(GameObject x in weapons)
        {
            if(i == curweaponindex && isweaponavailable[i] == true)
            {
                x.SetActive(true);
            }
            else
            {
                x.SetActive(false);
            }
            i++;
        }
    }
}