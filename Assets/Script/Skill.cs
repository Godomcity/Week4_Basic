using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum SkillType
{
    Attack,
    Buff
}

public struct SKillData
{
    // 파이어볼, 힐 스킬
    public ForceMode forceMode;
    public float coolTime;
    public float speed;
    public Vector3 direction;
    public GameObject skillObject;
    public SkillType skillType;
    public float lifeTime;
}

public abstract class Skill : MonoBehaviour
{
    public SKillData data;
    Rigidbody rigidBody;
    ParticleSystem particleSystem;
    bool isUse = true;
    float resetTime = 0;

    public abstract void InitSetting();

    public virtual void UseSkill(Transform tip, Transform player)
    {
        if(Input.GetKey(KeyCode.E) && isUse)
        {
            if (data.skillType == SkillType.Attack)
            {
                GameObject go = Instantiate(data.skillObject);
                go.transform.position = tip.position;
                rigidBody = go.GetComponent<Rigidbody>();
                rigidBody.AddForce(data.direction * data.speed, data.forceMode);

                Destroy(go, data.lifeTime);

                isUse = false;
            }
            else
            {
                GameObject go = Instantiate(data.skillObject);
                go.transform.position = player.position;
                particleSystem = go.GetComponent<ParticleSystem>();
                particleSystem.Play();

                Destroy(go, data.lifeTime);
                isUse = false;
            }
        }

        if (isUse == false)
        {
            resetTime += Time.deltaTime;
            if(resetTime >= data.coolTime)
            {
                isUse = true;
                resetTime = 0;
            }
        }
    }
}
