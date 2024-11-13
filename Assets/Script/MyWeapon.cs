using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyWeapon : MonoBehaviour
{
    public Weapon weapon;
    public Transform tip;

    private void Start()
    {
        weapon.InitSetting();
    }

    void Update()
    {
        weapon.Using(tip);
    }
}
