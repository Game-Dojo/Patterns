using UnityEngine;
using UnityEngine.UI;

namespace MVC
{
    public class ScoreView : MonoBehaviour
    {
        [SerializeField] private Text scoreText;

        public void UpdateView(int newScore)
        {
            scoreText.text = "Score: " + newScore;
        }
    }
}