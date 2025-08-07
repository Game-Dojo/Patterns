using UnityEngine;

namespace Singleton
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance { get; private set; }

        private int _gameScore = 0;
        
        void Awake()
        {
            if (Instance == null)
            { 
                Instance = this;
                DontDestroyOnLoad(gameObject);
            }else{
                Destroy(gameObject);
            }
        }

        public void AddScore(int score)
        {
            _gameScore += score;
        }
    }
}

