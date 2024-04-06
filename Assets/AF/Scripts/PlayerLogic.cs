using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLogic : MonoBehaviour
{
    [Tooltip("�ӵ��ڵ��Ԥ����")]
    public GameObject bulletPrefab;

    [Tooltip("�ӵ��ڵ�ĸ��ڵ�")]
    public Transform bulletFolder;

    [Tooltip("�ӵ�������")]
    public Transform firePoint;

    [Tooltip("������")]
    public float fireInterval = 0.1f;

    [Tooltip("�˶��ٶ�")]
    public float moveSpeed = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("createFire", fireInterval, fireInterval);
    }

    // Update is called once per frame
    void Update()
    {
        float dx = 0;

        if (Input.GetKey(KeyCode.A))
            dx = -moveSpeed;
        if (Input.GetKey(KeyCode.D))
            dx = moveSpeed;
        Debug.Log(dx);
        this.transform.Translate(dx, 0, 0, Space.World);
    }

    private void createFire()
    {
        GameObject node = Instantiate(bulletPrefab, bulletFolder);

        node.transform.position = firePoint.transform.position;
    }
}
