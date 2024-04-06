using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyCreator : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float interval = 1f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateEnemy", 0.1f, interval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void CreateEnemy()
    {
        GameObject node = Object.Instantiate(enemyPrefab, this.transform);
        node.transform.position = this.transform.position;
        node.transform.localEulerAngles = new Vector3(0, 180, 0);

        float dx = Random.Range(-50, 50);
        node.transform.Translate(dx, 0, 0, Space.Self);
    }
}
