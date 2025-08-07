using UnityEngine;

namespace Command
{
    public class MoveUpCommand : ICommand {
        private Player _player;
        public MoveUpCommand(Player p) { _player = p; }
        public void Execute() { _player.Move(Vector3.up); }
    }
}

