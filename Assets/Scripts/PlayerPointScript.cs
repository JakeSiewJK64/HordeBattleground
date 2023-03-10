using TMPro;
using UnityEngine;

public class PlayerPointScript : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI pointsCounter;
    
    private float points;

    void Start()
    {
        points = 500;
    }

    private void Update()
    {
        pointsCounter.text = "Points: " + points.ToString();
    }

    public void IncrementPoints(float amount)
    {
        points += amount;
    }
    
    public void DeductPoints(float amount)
    {
        points -= amount;
    }

    public float GetPoints()
    {
        return points;
    }
}
