using System;
using Core.Interfaces;
using UnityEngine;

namespace Characters.Player
{
    [RequireComponent(typeof(Rigidbody))]
    public class PlayerController : MonoBehaviour, IInitializable
    {
        public void Initialize()
        {
            throw new NotImplementedException();
        }
    }
}
