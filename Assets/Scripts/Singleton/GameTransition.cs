using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Singleton
{
    public class GameTransition : MonoBehaviour
    {
        private Animator _animator;
        
        private void Awake()
        {
            _animator = GetComponent<Animator>();
        }

        public void SetToggleFade(bool value)
        {
            if (!value)
            {
                _animator.SetTrigger("Fade");
            }

            StartCoroutine("Transition");
        }

        private IEnumerator Transition()
        {
            yield return new WaitForSeconds(1.0f);
            SceneManager.LoadScene("SingletonScene");
        }
    }
}
