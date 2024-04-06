using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLogic : MonoBehaviour
{
    public float Speed = 1.0f;

    public float lifetime = 3.0f;

    public GameObject explosionEffect;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("SelfDestory", lifetime);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(0, 0, Speed * Time.deltaTime, Space.Self);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name.StartsWith("怪兽"))
        {
            Destroy(this.gameObject);
            Destroy(other.gameObject);

            //创建粒子特效
            GameObject effectNode = Instantiate(explosionEffect, null);
            effectNode.transform.position = this.transform.position;
        }
    }

    private void SelfDestory()
    {
        Destroy(this.gameObject);
    }
}
