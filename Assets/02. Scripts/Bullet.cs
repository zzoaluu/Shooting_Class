using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10;

    void Start()
    {
        
    }
    
    void Update()
    {
        // ���� (�̷�) ��ġ =   ���� (����) ��ġ + XXX    
        transform.position = transform.position + Vector3.up * speed * Time.deltaTime;
    }
}
