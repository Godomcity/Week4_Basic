using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : Skill
{
    [SerializeField] private GameObject healEffect;
    public override void InitSetting()
    {
        data.forceMode = ForceMode.Force;
        data.coolTime = 4f;
        data.speed = 0f;
        data.direction = Vector3.zero;
        data.skillObject = healEffect;
        data.skillType = SkillType.Buff;
        data.lifeTime = 1.5f;
    }

    public override void UseSkill(Transform tip, Transform player)
    {
        base.UseSkill(tip, player);
    }
}
