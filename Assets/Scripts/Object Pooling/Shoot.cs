using UnityEngine;

namespace Object_Pooling
{
    public class Shoot : MonoBehaviour
    {
        [SerializeField] private ObjectPool pool;
        [SerializeField] private Transform bulletSpawn;
        public void PlayerShoot()
        {
            GameObject go = pool.GetPooledObject();
            if (!go) return;
            
            go.transform.position = bulletSpawn.position;
            go.SetActive(true);
        }
    }
}
