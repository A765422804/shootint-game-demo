using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class EnemyLogic : MonoBehaviour
{
    public float zSpeed = 15;

    public float lifeTime = 10;

    float xSpeed = 0;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SnakeMove", 0.5f, 0.5f);
        Invoke("SelfDestory", lifeTime);
    }

    // Update is called once per frame
    void Update()
    {
        float dz = zSpeed * Time.deltaTime;
        float dx = xSpeed * Time.deltaTime;

        this.transform.Translate(dx, 0, dz, Space.Self);
    }

    void SnakeMove()
    {
        float[] options = { -20, -10, 10, 20 };

        int sel = Random.Range(0, options.Length);

        xSpeed = options[sel];
    }

    void SelfDestory()
    {
        Destroy(this.gameObject);
    }
}
