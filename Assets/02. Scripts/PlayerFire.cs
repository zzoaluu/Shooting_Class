using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    public GameObject bulletFactory;
    public GameObject gun;

    // ������Ʈ Ǯ : �Ѿ��� źâ �����
    public int poolSize = 10;
    private GameObject[] bulletObjectPool;

    void Start()
    {
        bulletObjectPool = new GameObject[poolSize];

        // ������ �����Ҷ� �ʿ��� �Ѿ˰����� �Ѳ����� �����. 
        for(int i = 0; i < poolSize; i++)
        {
            // ���忡�� �Ѿ��� ����� �迭(źâ)�� �ִ´�.
            GameObject bullet = Instantiate(bulletFactory);
            bulletObjectPool[i] = bullet;

            //źâ�� �Ѿ��� �ְ� ��Ȱ��ȭ ��Ų��.
            bulletObjectPool[i].SetActive(false);
        }
    }
    
    void Update() // 1�ʿ� 60�� �۵�
    {
        // �� ���� ������ 1�ʿ� 60�� üũ
        // ���࿡ OOO �ϸ� 
        if(Input.GetButtonDown("Fire1")) // ctrl �Ǵ� ���콺 ����Ű
        {
            /*
            // �̷��� ����. ��Ź��~
            GameObject bullet = Instantiate(bulletFactory);
            
            //  �� �ϳ��� ���� �Ⱥ��̴� �Ӽ�(����) �� (����־�ߵ� �׸�) �� ���忡�� �Ѿ� ����
            bullet.transform.position = gun.transform.position;
            */
            Fire();
        }
    }

    public void Fire()
    {
        for(int i = 0; i < poolSize; i++)
        {
            GameObject bullet = bulletObjectPool[i];

            // źâ���� ��Ȱ��ȭ�� �Ѿ��� �߰��ϸ�
            if(bullet.activeSelf == false)
            {
                // �Ѿ��� Ȱ��ȭ�ϰ� �߻���ġ�� ���´�
                bullet.SetActive(true);
                bullet.transform.position = gun.transform.position;

                // for�� ����
                break; 
            }
        }
    }
}