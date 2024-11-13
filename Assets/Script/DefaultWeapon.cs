using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultWeapon : Weapon
{
    public override void InitSetting()
    {
        data.delayTime = 0.5f;
        data.speed = 50f;
        data.forceMode = ForceMode.Impulse;
        data.direction = Vector3.forward;
        data.lifeTime = 1f;
    }

    public override void Using(Transform tip)
    {
        base.Using(tip);
    }
}
