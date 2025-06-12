// 네임스페이스 : 필요한 클래스를 꺼내서 사용할 수 있는 클래스의 사전(?)같은 역할
using UnityEngine;

// 클래스 이름 정의 
// Monobehaviour라는 부모 클래스를 상속받아서 부모가 제공해주는 기능 사용 - start(), update() 등
public class PlayerMove : MonoBehaviour 
{
    // 속성 : 명사
    // public : 공개형, private : 비공개형
    public float speed = 5;
    // private float speed = 5; => private은 Inspector에 공개 안됨

    // ───────────────────────────────────────────────────────────────────────

    // 메서드 : 동사
    // 라이프 사이클 : 인생주기 - 사람이 태어나서(1번만) : Start(), 살다가(지속적으로) : Update()
    // 그래서, Start()는 무슨 기능이야?? 
    // 게임이 시작될때 딱 1번만 호출
    void Start() 
    {
    }

    // Update()는 무슨 기능이야?? 
    // 지속적으로 계속계속 호출 
    // 1초에 60번, 30번...
    // 결과값 : 1초마다 우측으로 5m * 60 = 300m 이동 
    // 컴퓨터 성능에 따라서 1초에 OO번 불리우는지 결정
    void Update() 
    {
        // 사용자 입력
        float h = Input.GetAxis("Horizontal"); // ← →
        float v = Input.GetAxis("Vertical");   // ↑ ↓  
                
        // 방향
        Vector3 dir = Vector3.right * h + Vector3.up * v;
        // Vector3 dir = new Vector3(h, v, 0);

        // 게임오브젝트를 X축(오른쪽) 방향으로 이동시킨다.
        // speed에 의해서 내거 얼만큼 움직일지가 정해진다 => 결과값
        // transform.Translate(Vector3.right * speed * Time.deltaTime);
        
        transform.position = transform.position + dir * speed * Time.deltaTime;
        //  내 (다음)위치   =   내 (현재) 위치    + 어디로 얼만큼 갈지? 
    }
}
