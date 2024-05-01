using UnityEngine;

namespace Managers
{
    public class ResourceLoadManager : Singleton<ResourceLoadManager>
    {
        public GameObject LoadUI<T>()
        {
            var path = typeof(T).Name;
            var go = Resources.Load<GameObject>($"UI/{path}");
            return go;
        }
    }
}