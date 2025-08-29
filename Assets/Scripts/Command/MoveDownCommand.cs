using UnityEngine;

namespace Command
{
    public class MoveDownCommand : ICommand {
        private Player _player;
        public MoveDownCommand(Player p) { _player = p; }
        
        public void Execute() { _player.Move(Vector3.down); }
    }
}

