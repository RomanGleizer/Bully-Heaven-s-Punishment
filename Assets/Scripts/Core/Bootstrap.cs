using System.Linq;
using Core.Interfaces;
using UnityEngine;

namespace Core
{
    public class Bootstrap : MonoBehaviour
    {
        [SerializeField] private GameObject[] initializableObjects;

        private void Awake()
        {
            initializableObjects
                .Select(obj => obj.GetComponent<IInitializable>())
                .Where(initializable => initializable != null)
                .ToList()
                .ForEach(initializable => initializable.Initialize());
        }
    }
}