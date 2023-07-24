using UnityEngine;

public class BuiletLogic : MonoBehaviour
{
    public float speed = 5;
    public float duration = 5;

    // Start is called before the first frame update
    void Start()
    {
        Invoke(nameof(DestroySelf), duration);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.localPosition;
        pos.z += Time.deltaTime * speed;
        transform.localPosition = pos;
    }

    private void DestroySelf()
    {
        Destroy(gameObject);
    }
}