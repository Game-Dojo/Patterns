using UnityEngine;

namespace Command
{
    public class InputHandler : MonoBehaviour
    {
        private ICommand _moveUp;
        void Start() 
        {
            var player = FindAnyObjectByType<Player>();
            _moveUp = new MoveUpCommand(player);
        }
        
        void Update() 
        {
            if (Input.GetKeyDown(KeyCode.W))
                _moveUp.Execute();
        }
    }
}
