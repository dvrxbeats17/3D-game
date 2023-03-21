using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] private TMP_Text count;

    private int _score = 0;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Hit")
        {
            _score++;
            Debug.Log($"You hit an onject {_score} times");
            collision.gameObject.tag = "Hit";
            SetScore();
        }
        else
        {
            DontDestroyOnLoad(count.gameObject);
        }
    }

    private void SetScore()
    {
        count.text = string.Format("Hits: " + _score);
    }
}
