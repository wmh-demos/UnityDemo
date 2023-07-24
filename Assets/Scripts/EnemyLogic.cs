using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class EnemyLogic : MonoBehaviour
{
    [Tooltip("Enemy Z轴移动速度")]
    public float speed = 3;

    private float[] xPositionArr = { -15f, -10f, -5f, 0, 5f, 10f };
    private float maxZPosition = -10f;

    // Start is called before the first frame update
    void Start()
    {
        // 关闭重力
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.useGravity = false;

        InvokeRepeating(nameof(updateXOrder), 0, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.localPosition;
        if (pos.z <= maxZPosition)
        {
            Destroy(gameObject);
            return;
        }

        updateZOrder();
    }

    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("OnCollisionEnter: " + other.gameObject.name);
        if (other.gameObject.name.StartsWith("Bullet"))
        {
            Destroy(gameObject);
        }
    }

    private void updateZOrder()
    {
        Vector3 pos = transform.localPosition;
        pos.z -= Time.deltaTime * speed;
        transform.localPosition = pos;
    }

    private void updateXOrder()
    {
        Vector3 pos = transform.localPosition;
        pos.x = new Random().Next(0, xPositionArr.Length);
        transform.localPosition = pos;
    }
}