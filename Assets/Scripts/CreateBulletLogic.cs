using UnityEngine;

public class CreateBulletLogic : MonoBehaviour
{
    [Tooltip("创建子弹间隔")]
    public float interval = 0.2f;
    [Tooltip("单次点击移动位置")]
    public float moveStep = 0.2f;
    [Tooltip("左侧偏移最大位置")]
    public float maxLeftPosition = -5f;
    [Tooltip("右侧偏移最大位置")]
    public float maxRightPosition = 5f;
    public GameObject prefab;

    private
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(CreateBullet), 0, interval);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.localPosition;
        if (Input.GetKey(KeyCode.A))
        {
            if (pos.x > maxLeftPosition)
            {
                pos.x -= moveStep;
                transform.localPosition = pos;
            }
        }

        if (Input.GetKey(KeyCode.D))
        {
            if (pos.x < maxRightPosition)
            {
                pos.x += moveStep;
                transform.localPosition = pos;
            }
        }
    }

    private void CreateBullet()
    {
        Instantiate(prefab, transform.localPosition, Quaternion.identity);
    }
}