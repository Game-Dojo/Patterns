using UnityEngine;

namespace Object_Pooling
{
    public class ObjectPool : MonoBehaviour
    {
        [SerializeField] private GameObject prefab;
        [SerializeField] private int poolSize = 10;
        [SerializeField] private bool expandable = true;

        void Start()
        {
            for (int i = 0; i < poolSize; i++)
            {
                GameObject obj = Instantiate(prefab, transform);
                obj.SetActive(false);
            }
        }

        public GameObject GetPooledObject()
        {
            foreach (Transform child in transform)
            {
                if (!child.gameObject.activeInHierarchy)
                    return child.gameObject;
            }

            if (expandable)
            {
                GameObject obj = Instantiate(prefab, transform);
                obj.SetActive(false);
                return obj;
            }

            return null;
        }

    }
}
