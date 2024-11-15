using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MySkill : MonoBehaviour
{
    public Skill skill;
    public Transform tip;
    public Transform player;

    void Start()
    {
        skill.InitSetting();
    }

    void Update()
    {
        skill.UseSkill(tip, player);
    }
}
