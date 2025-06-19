using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10;

    void Start()
    {
        
    }
    
    void Update()
    {
        // 나의 (미래) 위치 =   나의 (현재) 위치 + XXX    
        transform.position = transform.position + Vector3.up * speed * Time.deltaTime;
    }
}
