using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private int health;
    private int score;

    
    [SerializeField] private Button IncreaseHPButton;
    [SerializeField] private Button DecreaseHPButton;
    [SerializeField] private Button IncreaseScoreButton;
    [SerializeField] private Button DecreaseScoreButton;


    public UnityAction<int> OnHealthChanged;
    public UnityAction<int> OnScoreChanged;

    private void Start()
    {
        health = 100;
        score = 0;
        OnHealthChanged?.Invoke(health);
        OnScoreChanged?.Invoke(score);
    }

    public void IncreaseHealth()
    {
        health += 10;
        Mathf.Clamp(health, 0, 100);
        OnHealthChanged?.Invoke(health);
    }

    public void DecreaseHealth()
    {
        health -= 10;
        Mathf.Clamp(health, 0, 100);
        OnHealthChanged?.Invoke(health);
    }

    public void IncreaseScore()
    {
        score++;
        OnScoreChanged?.Invoke(score);
    }

    public void DecreaseScore()
    {
        score--;
        OnScoreChanged?.Invoke(score);
    }


}
