using System.Collections.Generic;
using UnityEngine;

namespace Managers
{
    public class UIManager : Singleton<UIManager>
    {
        private Dictionary<string, GameObject> _ui;

        public void Open<T>()
        {
            var uiName = typeof(T).Name;
            if (_ui.TryGetValue(uiName,out var ui))
            {
                ui.SetActive(true);
            }
            else
            {
                var uiPrefab = ResourceLoadManager.Instance.LoadUI<T>();
                var uiGo = Instantiate(uiPrefab);
                _ui.Add(uiName,uiGo); 
            }
        }

        public void Close<T>()
        {
            var uiName = typeof(T).Name;
            if (_ui.TryGetValue(uiName,out var ui))
            {
                ui.SetActive(false);
            }
        }
    }
}