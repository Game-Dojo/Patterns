using UnityEngine;

namespace SimpleStateMachine
{
    public class StateMachine: MonoBehaviour
    {
        public enum States {Idle, Walk, Attack}
        private States _currentState = States.Idle;

        void Update()
        {
            switch(_currentState) 
            {
                case States.Idle:
                    IdleState();
                    break;
            }
        }

        void IdleState() { /* Implementation */ }

        public void SetState(States state)
        {
            _currentState = state;
        }
    }
}
