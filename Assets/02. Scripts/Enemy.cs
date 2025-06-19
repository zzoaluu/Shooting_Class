using UnityEngine;

// ź���ϴ� ���ʹ̵� �߿��� 30% ������ �÷��̾� �������� ��ġ ����źó�� ��¦ ������ Ʋ� ������ �Ѵ�.
public class Enemy : MonoBehaviour
{
    public float speed = 5;
    private Vector3 dir;

    // ����ȿ�� ������ �������� 
    public GameObject explosionFactory;


    void Start()  // �¾�� �� ����� ��������. ����! 
    {
        int ranValue = Random.Range(0, 10);
        if(ranValue < 3) // 0, 1, 2
        {
            // �׸�(player) �� player�� ã�Ƽ�
            GameObject player = GameObject.Find("Player");
            
            //    �׸�(player) �� ��ġ��     -  �� �ڽ��� ��ġ��
            dir = player.transform.position - transform.position;
            
            // 1�� ũ��� ������ش�.
            dir.Normalize();

            //  ���� (�̷�) ��ġ�� = ���� (����) ��ġ�� + ��ȭ�ϴ� ��
            // transform.position = transform.position + dir * speed * Time.deltaTime;
            transform.position += dir * speed * Time.deltaTime;

        }
        else // 3 ~ 10
        {
            dir = Vector3.down;
        }
    }

    void Update() // �� ���ڴ�� ���
    {
        // Vector3 dir = Vector3.down;
        transform.position = transform.position + dir * speed * Time.deltaTime; 
    }

    private void OnCollisionEnter(Collision collision)
    {
        // ����ȿ�� �׸�   <-  ����ȿ�� ���� 
        GameObject explosion = Instantiate(explosionFactory);
        // ��ġ
        explosion.transform.position = transform.position;

        Destroy(collision.gameObject);
        Destroy(gameObject);
    }
}
