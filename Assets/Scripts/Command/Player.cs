using UnityEngine;

namespace Command
{
    public class Player : MonoBehaviour 
    {
        public void Move(Vector3 dir) {
            transform.position += dir;
        }
    }
}
