// 클래스를 꺼내오는 사전(?) 같은 역할 
using UnityEngine;
 
// 클래스 이름 정의 
// Monobehaviour : 부모 클래스 상속
public class PlayerMove : MonoBehaviour 
{
    // 속성 : 명사    
    public float speed = 5;
    // private float speed = 5;

    // ----------------------------------------------------------------------

    // 메서드 : 동사
    // 라이프 사이클??? : 인생주기?? - 사람이 태어나서(1번만). 살다가(지속적으로)

    // 무슨 기능이야?? 
    void Start() // 1번만 호출
    {

    }

    // 무슨 기능이야?? 
    // 지속적으로 계속계속 호출 
    // 1초 60번 작동, 30번...
    // - 1초 60번  
    // 저의 PC 결과값 : 1초마다 우측으로 300만큼 이동 
    
    
    // 컴퓨터 성능에 따라서 1초에 O번 불리우는지 결정
    void Update() 
    {
        // 사용자 입력
        float h = Input.GetAxis("Horizontal"); // ← →
        float v = Input.GetAxis("Vertical"); // ↑ ↓  
                
        // 방향
        Vector3 dir = Vector3.right * h + Vector3.up * v;
        // Vector3 dir = new Vector3(h, v, 0);

        // 게임오브젝트를 X축(오른쪽) 방향으로 이동시킨다.
        // speed에 의해서 내거 얼만큼 움직일지가 정해진다. : 결과값. 
        // transform.Translate(Vector3.right * speed * Time.deltaTime);
        
        transform.position = transform.position + dir * speed * Time.deltaTime;
        //  내 (다음)위치  =   내 (현재) 위치     방향    5   
    }
}
