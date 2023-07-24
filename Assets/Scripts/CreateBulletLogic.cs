using UnityEngine;

public class CreateBulletLogic : MonoBehaviour
{
    public float interval = 0.2f;
    public GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(CreateBullet), 0, interval);
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void CreateBullet()
    {
        Instantiate(prefab, transform);
    }
}