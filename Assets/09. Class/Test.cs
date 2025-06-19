 using UnityEngine;

public class Test : MonoBehaviour
{
    /*
    void Start() // 태어날때 1번
    {
        Debug.Log("나는 스타트");
    }

    void Update() // 매 프레임마다 출력
    {
        UnityEngine.Debug.Log("나는 업데이트");
    }
    */

    // 물리현상 감지하는게 아니라
    // 서로 닿았는지에 대한 확인만 처리한다. 
    private void OnTriggerEnter(Collider other)  
    {
        Debug.Log("온트리거엔터 충돌 감지됨: " + other.name);
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    Debug.Log("온콜리젼엔터 충돌 감지됨: " + collision.gameObject.name);
    //}    
}
