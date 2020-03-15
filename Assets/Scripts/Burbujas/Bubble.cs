using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

namespace Bubbles
{
    public class Bubble : MonoBehaviour
    {
         private Etrait _trait;
         private float speed;

        [SerializeField] private Color[] colors;
        private Renderer rndColor;

        public Etrait Trait
        {
            get => _trait;
        }

        public void Begin(Etrait _eTrait,float _speed)
        {
            _trait = _eTrait ;
            speed = _speed;
            rndColor = GetComponent<Renderer>();
            WearBubble();
        }

        void WearBubble()
        {
            switch (_trait)
            {
                case Etrait.Filrt:
                    rndColor.material.color = colors[0];
                    break;
                case Etrait.Love:
                    rndColor.material.color = colors[1];
                    break;
                case Etrait.Intelligence:
                    rndColor.material.color = colors[2];
                    break;
                case Etrait.Intimacy:
                    rndColor.material.color = colors[3];
                    break;
                case Etrait.Afecction:
                    rndColor.material.color = colors[4];
                    break;
                case Etrait.Boorish:
                    rndColor.material.color = colors[5];
                    break;
            }

            Debug.Log(rndColor.material.color);
        }
        public void Pop()
        {
            gameObject.SetActive(false);
        }

        public void Die()
        {
            
            gameObject.SetActive(false);
        }
       
        private void FixedUpdate()
        {
            Move();
        }

        void Move()
        {
            transform.Translate(Vector3.down*speed);
        }

    }
}
