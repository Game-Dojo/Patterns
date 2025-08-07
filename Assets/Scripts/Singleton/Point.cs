using System;
using UnityEngine;

namespace Singleton
{
    public class Point : MonoBehaviour
    {
        private GameManager _gameManager;

        private void Start()
        {
            _gameManager = GameManager.Instance;
        }

        private void OnMouseDown()
        {
            _gameManager.AddScore(1);
            print(_gameManager.GetScore);
        }
    }
}
