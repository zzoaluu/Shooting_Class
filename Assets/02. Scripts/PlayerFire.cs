using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    public GameObject bulletFactory;
    public GameObject gun;
    
    void Start()
    {
    }
    
    void Update() // 1�ʿ� 60�� �۵�
    {
        // �� ���� ������ 1�ʿ� 60�� üũ
        // ���࿡ OOO �ϸ� 
        if(Input.GetButtonDown("Fire1")) // ctrl �Ǵ� ���콺 ����Ű
        {
            // �̷��� ����. ��Ź��~
            GameObject bullet = Instantiate(bulletFactory);
            
            //  �� �ϳ��� ���� �Ⱥ��̴� �Ӽ�(����) �� (����־�ߵ� �׸�) �� ���忡�� �Ѿ� ����
            bullet.transform.position = gun.transform.position;
        }
    }
}