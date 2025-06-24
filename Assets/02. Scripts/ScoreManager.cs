using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    // 현재점수
    public TMP_Text currentScoreUI;
    private int currentScore; 

    // 최고점수
    public TMP_Text bestScoreUI;
    private int bestScore;  


    // 점수 관리자 만들기 : 디자인패턴 - 싱글톤
    // 관리자의 특징 (1)접근이 쉽다 (2)오직 1개만 존재
    public static ScoreManager instance;
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
   
    // 점수 : 프로퍼티(캡슐화)
    // 매니저 ↔ 연예인(BTS)의 관계 
    public int Score  // ←  0, 1, 2, 3...    
    {
        get // 읽기
        {
            return currentScore;
        }
        set // 쓰기
        {
            currentScore = value; // value = 0, 1, 2, 3... 
            currentScoreUI.text = "현재점수 : " + currentScore; // 현재점수 갱신 

            // 최고점수 갱신 
            //     12            10
            if(currentScore > bestScore)
            {
                bestScore = currentScore;  // 덮어쓰기 : 10 ← 12 
                bestScoreUI.text = "최고점수 : " + bestScore;  // 12 
            }
            
            // 최고점수를 내 컴퓨터 하드디스크에 저장
            PlayerPrefs.SetInt("BestScore", bestScore);
        }
    }

    void Start()
    {
        // 최고점수 초기화
        // PlayerPrefs.SetInt("BestScore", 0);

        // 게임 시작시, 최고점수 불러오기
        bestScore = PlayerPrefs.GetInt("BestScore", 0);
        bestScoreUI.text = "최고점수 : " + bestScore;
    }
}
