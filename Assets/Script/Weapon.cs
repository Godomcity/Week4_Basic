using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public struct Data
{
    public ForceMode forceMode;
    public float delayTime;
    public float speed;
    public Vector3 direction;
    public float lifeTime;
}

public abstract class Weapon : MonoBehaviour
{
    public Data data;
    public GameObject bullet;
    public Rigidbody rigidbody;

    bool shoot = true;
    float resetTime = 0;

    public abstract void InitSetting();

    public virtual void Using(Transform tip)
    {
        if (Input.GetKey(KeyCode.Space) && shoot)
        {
            GameObject go = Instantiate(bullet);
            go.transform.position = tip.position;
            rigidbody = go.GetComponent<Rigidbody>();
            rigidbody.AddForce(data.direction * data.speed, data.forceMode);

            Destroy(go, data.lifeTime);

            shoot = false;
            Debug.Log(data.forceMode);
        }

        if (shoot == false)
        {
            resetTime += Time.deltaTime;
            if (resetTime >= data.delayTime)
            {
                shoot = true;
                resetTime = 0;
            }
        }
    }
}
