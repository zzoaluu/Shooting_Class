// Ŭ������ �������� ����(?) ���� ���� 
using UnityEngine;
 
// Ŭ���� �̸� ���� 
// Monobehaviour : �θ� Ŭ���� ���
public class PlayerMove : MonoBehaviour 
{
    // �Ӽ� : ���    
    public float speed = 5;
    // private float speed = 5;

    // ----------------------------------------------------------------------

    // �޼��� : ����
    // ������ ����Ŭ??? : �λ��ֱ�?? - ����� �¾��(1����). ��ٰ�(����������)

    // ���� ����̾�?? 
    void Start() // 1���� ȣ��
    {

    }

    // ���� ����̾�?? 
    // ���������� ��Ӱ�� ȣ�� 
    // 1�� 60�� �۵�, 30��...
    // - 1�� 60��  
    // ���� PC ����� : 1�ʸ��� �������� 300��ŭ �̵� 
    
    
    // ��ǻ�� ���ɿ� ���� 1�ʿ� O�� �Ҹ������ ����
    void Update() 
    {
        // ����� �Է�
        float h = Input.GetAxis("Horizontal"); // �� ��
        float v = Input.GetAxis("Vertical"); // �� ��  
                
        // ����
        Vector3 dir = Vector3.right * h + Vector3.up * v;
        // Vector3 dir = new Vector3(h, v, 0);

        // ���ӿ�����Ʈ�� X��(������) �������� �̵���Ų��.
        // speed�� ���ؼ� ���� ��ŭ ���������� ��������. : �����. 
        // transform.Translate(Vector3.right * speed * Time.deltaTime);
        
        transform.position = transform.position + dir * speed * Time.deltaTime;
        //  �� (����)��ġ  =   �� (����) ��ġ     ����    5   
    }
}
