using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : Skill
{
    [SerializeField] private GameObject fireBallPrefabs;
    public override void InitSetting()
    {
        data.forceMode = ForceMode.Impulse;
        data.coolTime = 2f;
        data.speed = 5f;
        data.direction = Vector3.forward;
        data.skillObject = fireBallPrefabs;
        data.skillType = SkillType.Attack;
        data.lifeTime = 2f;
    }

    public override void UseSkill(Transform tip, Transform player)
    {
        base.UseSkill(tip, player);
    }
}
