using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    public GameObject bulletFactory;
    public GameObject gun;
    
    void Start()
    {
    }

    // ex) 1�ʿ� 60�� �۵��Ѵٸ�
    void Update()
    {
        // �� ���� ������ 1�ʿ� 60�� üũ
        // [ if�� ] ���࿡ OOO �ϸ� xxx �ϰڴ�
        if (Input.GetButtonDown("Fire1")) // ���࿡ ctrl �Ǵ� ���콺 ��Ű�� �����ٸ�
        {
            // ~ �̷��� �ϰڴ�.
            GameObject bullet = Instantiate(bulletFactory);
            // ���� �Ⱥ��̴� �� �ϳ��� �Ӽ�(����) bullet �� (��� �־�ߵ� �׸�) �� ���忡�� �Ѿ� ����
            bullet.transform.position = gun.transform.position;
            // bullet�� ��ġ = ���� ��ġ (���� �߻�Ǿ� �ϴϱ�)
        }
    }
}
