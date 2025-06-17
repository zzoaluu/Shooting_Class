 using UnityEngine;

public class Test : MonoBehaviour
{

    void Start()
    {
        Debug.Log("나는 스타트");
    }

    void Update()
    {
        Debug.Log("나는 업데이트");
    }
    
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("온트리거엔터 충돌 감지됨: " + other.name);
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    Debug.Log("온콜리젼엔터 충돌 감지됨: " + collision.gameObject.name);        
    //}
}
