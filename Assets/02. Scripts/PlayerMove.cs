// ���ӽ����̽� : �ʿ��� Ŭ������ ������ ����� �� �ִ� Ŭ������ ����(?)���� ����
using UnityEngine;

// Ŭ���� �̸� ���� 
// Monobehaviour��� �θ� Ŭ������ ��ӹ޾Ƽ� �θ� �������ִ� ��� ��� - start(), update() ��
public class PlayerMove : MonoBehaviour 
{
    // �Ӽ� : ���
    // public : ������, private : �������
    public float speed = 5;
    // private float speed = 5; => private�� Inspector�� ���� �ȵ�

    // ����������������������������������������������������������������������������������������������������������������������������������������������

    // �޼��� : ����
    // ������ ����Ŭ : �λ��ֱ� - ����� �¾��(1����) : Start(), ��ٰ�(����������) : Update()
    // �׷���, Start()�� ���� ����̾�?? 
    // ������ ���۵ɶ� �� 1���� ȣ��
    void Start() 
    {
    }

    // Update()�� ���� ����̾�?? 
    // ���������� ��Ӱ�� ȣ�� 
    // 1�ʿ� 60��, 30��...
    // ����� : 1�ʸ��� �������� 5m * 60 = 300m �̵� 
    // ��ǻ�� ���ɿ� ���� 1�ʿ� OO�� �Ҹ������ ����
    void Update() 
    {
        // ����� �Է�
        float h = Input.GetAxis("Horizontal"); // �� ��
        float v = Input.GetAxis("Vertical");   // �� ��  
                
        // ����
        Vector3 dir = Vector3.right * h + Vector3.up * v;
        // Vector3 dir = new Vector3(h, v, 0);

        // ���ӿ�����Ʈ�� X��(������) �������� �̵���Ų��.
        // speed�� ���ؼ� ���� ��ŭ ���������� �������� => �����
        // transform.Translate(Vector3.right * speed * Time.deltaTime);
        
        transform.position = transform.position + dir * speed * Time.deltaTime;
        //  �� (����)��ġ   =   �� (����) ��ġ    + ���� ��ŭ ����? 
    }
}
