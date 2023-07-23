using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLogic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.localPosition;
        float speed = 2f;
        pos.x += Time.deltaTime * speed;
        if (pos.x >= 5f)
        {
            pos.x -= 5f;
        }

        transform.localPosition = pos;
    }
}
