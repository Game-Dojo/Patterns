using TMPro;
using UnityEngine;

namespace MVC
{
    public class ScoreView : MonoBehaviour
    {
        [SerializeField] private TMP_Text scoreText;

        public void UpdateView(int newScore)
        {
            scoreText.text = newScore.ToString();
        }
    }
}