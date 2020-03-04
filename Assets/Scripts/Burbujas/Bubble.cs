using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

namespace Bubbles
{
    public class Bubble : MonoBehaviour
    {
        [SerializeField] private Etrait Trait;


        public void Pop()
        {
            gameObject.SetActive(false);
        }

        public void Die()
        {
            gameObject.SetActive(false);
        }

    }
}
