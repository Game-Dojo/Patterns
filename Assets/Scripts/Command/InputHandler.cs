using UnityEngine;

namespace Command
{
    public class InputHandler : MonoBehaviour
    {
        private ICommand _moveUp;
        private ICommand _moveDown;
        
        void Start() 
        {
            var player = FindAnyObjectByType<Player>();
            _moveUp = new MoveUpCommand(player);
            _moveDown = new MoveDownCommand(player);
        }
        
        void Update() 
        {
            if (Input.GetKeyDown(KeyCode.W))
                _moveUp.Execute();
            else if (Input.GetKeyDown(KeyCode.S))
                _moveDown.Execute();
        }
    }
}
