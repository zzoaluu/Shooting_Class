using UnityEngine;

public class TestCol : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("��Ʈ���ſ��� �浹 ������: " + other.name);
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    Debug.Log("���ݸ������� �浹 ������: " + collision.gameObject.name);        
    //}
}

