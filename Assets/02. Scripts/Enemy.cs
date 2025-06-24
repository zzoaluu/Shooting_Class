using UnityEngine;

// ź���ϴ� ���ʹ̵� �߿��� 30% ������ �÷��̾� �������� ��ġ ����źó�� ��¦ ������ Ʋ� ������ �Ѵ�.
public class Enemy : MonoBehaviour
{
    public float speed = 5;
    private Vector3 dir;

    // ����ȿ�� ������ �������� 
    public GameObject explosionFactory;


    // void Start()  // �¾�� �� ����� ��������. ����! 
    void OnEnable() // �� �ڽ��� Ȱ��ȭ�ɶ� - �����ض� �� OnDisable() : ���� ��Ȱ��ȭ�ɶ� 
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
        //ScoreManager.instance.Score = ScoreManager.instance.Score + 1;
        // (����)�������� ������Ʈ    =   (�б�)���������� �о�ͼ�   + 1    
        //            6             =                5            + 1  
        //ScoreManager.instance.Score += 1;
        ScoreManager.instance.Score++;

        // ������������������������������������������������������������������������������������������������������������
        // ����ȿ�� �׸�   <-  ����ȿ�� ���� 
        GameObject explosion = Instantiate(explosionFactory);
        // ����ȿ�� ��ġ
        explosion.transform.position = transform.position;
        // ������������������������������������������������������������������������������������������������������������


        // �Ѿ��̸� ��Ȱ��ȭ
        //   �浹��   ���ӿ�����Ʈ.�̸�. �����ϰ� �ִ�? "Bullet"
        if (collision.gameObject.name.Contains("Bullet"))
        {
            // ������ ��Ȳ : ���ʹ� �ڽ� - �Ѿ�
            // �Ѿ� - ��Ȱ��ȭ
            // SetActive(false) : ��Ȱ��ȭ
            // SetActive(true): Ȱ��ȭ 
            collision.gameObject.SetActive(false);
        }
        // �÷��̾��� ��� 
        else
        {
            // �÷��̾� - �ʴ� �ı��Ҳ�
            Destroy(collision.gameObject);
        }
            
        // ���ʹ� �� �ڽ� �� �ı��� �ƴ϶� ��Ȱ��ȭ! 
        // Destroy(gameObject);
        gameObject.SetActive(false);
    }
}
