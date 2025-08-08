using System;
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

namespace SimpleStateMachine
{
    public class PlayerStateMachine: MonoBehaviour
    {
        public enum States {Idle, Walk, Attack}
        [SerializeField] private States _currentState = States.Idle;

        private bool _idleOnce = false;
        private bool _isWalking = false;
        private bool _isEnemyInside = false;
        void Update()
        {
            switch(_currentState) 
            {
                case States.Idle:
                    if (_idleOnce) return;
                    IdleState();
                    break;
                case States.Walk:
                    if (_isWalking) return;
                    WalkState();
                    break;
                case States.Attack:
                    AttackState();
                    break;
            }
        }

        void IdleState()
        {
            _idleOnce = true;
            Invoke("ChangeToWalkState", 4.0f);
        }

        void ChangeToWalkState()
        {
            SetState(States.Walk);
        }

        void WalkState()
        {
            _isWalking = true;
            
            if (_isEnemyInside)
                SetState(States.Attack);
            else
            {
                StartCoroutine("WalkCoroutine");
            }
        }

        IEnumerator WalkCoroutine()
        {
            Vector3 randomPoint = Random.insideUnitSphere * 3.0f;
            randomPoint += transform.position;
            
            yield return new WaitUntil(() =>
            {
                Vector3 dir = (randomPoint - transform.position).normalized;
                transform.position += dir * (1.2f * Time.deltaTime);

                return Vector3.Distance(transform.position, randomPoint) < 0.2f;
            });
            
            _isWalking = false;
            _idleOnce = false;
            SetState(States.Idle);
        }

        void AttackState()
        {
            
        }

        public void SetState(States state)
        {
            _currentState = state;
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            _isEnemyInside = true;
        }
        
        private void OnTriggerExit2D(Collider2D other)
        {
            _isEnemyInside = false;
        }

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(transform.position, 3.0f);
        }
    }
}
