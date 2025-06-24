using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    // ��������
    public TMP_Text currentScoreUI;
    private int currentScore; 

    // �ְ�����
    public TMP_Text bestScoreUI;
    private int bestScore;  


    // ���� ������ ����� : ���������� - �̱���
    // �������� Ư¡ (1)������ ���� (2)���� 1���� ����
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
   
    // ���� : ������Ƽ(ĸ��ȭ)
    // �Ŵ��� �� ������(BTS)�� ���� 
    public int Score  // ��  0, 1, 2, 3...    
    {
        get // �б�
        {
            return currentScore;
        }
        set // ����
        {
            currentScore = value; // value = 0, 1, 2, 3... 
            currentScoreUI.text = "�������� : " + currentScore; // �������� ���� 

            // �ְ����� ���� 
            //     12            10
            if(currentScore > bestScore)
            {
                bestScore = currentScore;  // ����� : 10 �� 12 
                bestScoreUI.text = "�ְ����� : " + bestScore;  // 12 
            }
            
            // �ְ������� �� ��ǻ�� �ϵ��ũ�� ����
            PlayerPrefs.SetInt("BestScore", bestScore);
        }
    }

    void Start()
    {
        // �ְ����� �ʱ�ȭ
        // PlayerPrefs.SetInt("BestScore", 0);

        // ���� ���۽�, �ְ����� �ҷ�����
        bestScore = PlayerPrefs.GetInt("BestScore", 0);
        bestScoreUI.text = "�ְ����� : " + bestScore;
    }
}
