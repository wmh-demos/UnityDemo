using UnityEngine;

public class CreateEnemyLogic : MonoBehaviour
{
    [Tooltip("创建Enemy间隔")]
    public float interval = 0.2f;

    public GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(CreateEnemyObject), 0f, interval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void CreateEnemyObject()
    {
        Instantiate(prefab, transform.localPosition, Quaternion.identity);
    }
}
