using UnityEngine;

namespace Factory
{
    public class GameManager : MonoBehaviour
    {
        private void Start()
        {
            Enemy enemy1 = EnemyFactory.CreateEnemy(EnemyType.Melee);
            enemy1?.Attack();
            
            Enemy enemy2 = EnemyFactory.CreateEnemy(EnemyType.Range);
            enemy2?.Attack();
        }
    }
}
