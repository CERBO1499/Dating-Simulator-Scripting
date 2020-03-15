using System;
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
         private ParticleSystem parSys;
         private ParticleSystem.MainModule main;
         private AudioSource aud;
         

        [SerializeField] private Color[] colors;
        [SerializeField] private float delayPop;
        private Renderer rndColor;


        private void Awake()
        {
            parSys = GetComponentInChildren<ParticleSystem>();
            
            main = parSys.main;
            aud = GetComponent<AudioSource>();
        }

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

        IEnumerator popDelay()
        {
            StopCoroutine("popDelay");
            GetComponent<Renderer>().enabled = false;
            aud.Play();
            parSys.Play();
            yield return new WaitForSeconds(parSys.main.duration + parSys.main.startLifetime.constant+0.02f);
            gameObject.SetActive(false);
            
        }

        void WearBubble()
        {
            switch (_trait)
            {
                case Etrait.Filrt:
                    rndColor.material.color = colors[0];
                    main.startColor = colors[0];
                    break;
                case Etrait.Love:
                    rndColor.material.color = colors[1];
                    main.startColor = colors[1];

                    break;
                case Etrait.Intelligence:
                    rndColor.material.color = colors[2];
                    main.startColor = colors[2];

                    break;
                case Etrait.Intimacy:
                    rndColor.material.color = colors[3];
                    main.startColor = colors[3];

                    break;
                case Etrait.Afecction:
                    rndColor.material.color = colors[4];
                    main.startColor = colors[4];

                    break;
                case Etrait.Boorish:
                    rndColor.material.color = colors[5];
                    main.startColor = colors[5];

                    break;
            }

            Debug.Log(rndColor.material.color);
        }
        public void Pop()
        {
            StartCoroutine(popDelay());
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
