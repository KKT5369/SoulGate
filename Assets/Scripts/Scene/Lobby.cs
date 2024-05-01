using System;
using Managers;
using UnityEngine;

namespace Scene
{
    public class Lobby : MonoBehaviour
    {
        private void Start()
        {
            UIManager.Instance.Open<UILobby>();
        }
    }
}