using System;
using System.Collections;
using System.Collections.Generic;
using Bubbles;
using UnityEngine;
[RequireComponent(typeof(InputHandler))]
public class PlayerController : MonoBehaviour
{
    private InputHandler _inputHandler;

    [SerializeField] private LayerMask bubbleMask;
    private void Awake()
    {
        _inputHandler = GetComponent<InputHandler>();
        Bind();
    }

    private void OnDestroy()
    {
        UnBind();
    }

    void Bind()
    {
        _inputHandler.OnClick += SelectBubble;
    }

    void UnBind()
    {
        _inputHandler.OnClick -= SelectBubble;
    }

    void SelectBubble(Vector2 screenPos)
    {
        Ray ry = Camera.main.ScreenPointToRay(screenPos);
        RaycastHit hit;

        if (Physics.Raycast(ry, out hit,Mathf.Infinity, bubbleMask))
        {

            Bubble bQuery = hit.collider.GetComponent<Bubble>();

            if (bQuery != null)
            {
                bQuery.Pop();
            }
        }

    }
}
