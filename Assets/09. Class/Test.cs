 using UnityEngine;

public class Test : MonoBehaviour
{

    void Start()
    {
        Debug.Log("���� ��ŸƮ");
    }

    void Update()
    {
        Debug.Log("���� ������Ʈ");
    }
    
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("��Ʈ���ſ��� �浹 ������: " + other.name);
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    Debug.Log("���ݸ������� �浹 ������: " + collision.gameObject.name);        
    //}
}
