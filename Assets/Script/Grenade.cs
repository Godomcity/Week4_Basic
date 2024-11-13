using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grenade : Weapon
{
    public override void InitSetting()
    {
        data.delayTime = 1f;
        data.speed = 10f;
        data.forceMode = ForceMode.VelocityChange;
        data.direction = transform.forward + transform.up;
        data.lifeTime = 3f;
    }

    public override void Using(Transform tip)
    {
        base.Using(tip);
    }
}
