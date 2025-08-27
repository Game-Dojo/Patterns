using System;
using UnityEngine;

namespace Object_Pooling
{
    public class Bullet : MonoBehaviour
    {
        [SerializeField] private TrailRenderer bulletTrail;
        
        private void OnEnable()
        {
            bulletTrail?.Clear();
            CancelInvoke();
            Invoke("Kill", 6.0f);
        }

        void Update()
        {
            transform.position += Vector3.right * (Time.deltaTime * 10f);
        }

        private void Kill()
        {
            gameObject.SetActive(false);
        }
    }
}
