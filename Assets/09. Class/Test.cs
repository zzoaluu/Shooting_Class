 using UnityEngine;

public class Test : MonoBehaviour
{
    /*
    void Start() // �¾�� 1��
    {
        Debug.Log("���� ��ŸƮ");
    }

    void Update() // �� �����Ӹ��� ���
    {
        UnityEngine.Debug.Log("���� ������Ʈ");
    }
    */

    // �������� �����ϴ°� �ƴ϶�
    // ���� ��Ҵ����� ���� Ȯ�θ� ó���Ѵ�. 
    private void OnTriggerEnter(Collider other)  
    {
        Debug.Log("��Ʈ���ſ��� �浹 ������: " + other.name);
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    Debug.Log("���ݸ������� �浹 ������: " + collision.gameObject.name);
    //}    
}
