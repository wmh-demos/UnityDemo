using System.Collections.Generic;
using UnityEngine;

public class CreateBulletLogic : MonoBehaviour
{
    public GameObject prefab;

    private List<GameObject> _bulletList = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            GameObject bullet = Instantiate(prefab, transform);
            _bulletList.Add(bullet);
        }

        Invoke(nameof(destroyBullets), 3);
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void destroyBullets()
    {
        _bulletList.ForEach(Destroy);
    }
}