using UnityEngine;
using UnityEngine.UI;

namespace MVC
{
    public class ScoreController : MonoBehaviour
    {
        [SerializeField] private Button scoreButton;
        [SerializeField] private ScoreView view;

        private ScoreModel _model;

        void Start()
        {
            _model = new ScoreModel();
            _model.ScoreChanged += view.UpdateView;

            scoreButton.onClick.AddListener(OnScoreButtonClicked);
            view.UpdateView(_model.Score);
        }

        void OnScoreButtonClicked()
        {
            _model.AddScore(1);
        }
    }
}
