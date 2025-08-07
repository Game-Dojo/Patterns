using UnityEngine;

namespace Factory
{
    public enum EnemyType
    {
        Melee,
        Range
    }
    public static class EnemyFactory
    {
        public static Enemy CreateEnemy(EnemyType type)
        {
            switch(type) { 
                case EnemyType.Melee:
                    return new MeleeEnemy();
                    break;
                case EnemyType.Range:
                    return new RangeEnemy();
                    break;
                default:
                    Debug.LogError("Unknown enemy type: " + type);
                    return null;
            }
        }

    }
}
