using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class InputHandler : MonoBehaviour
{
   public event Action <Vector2> OnClick;


   private void Update()
   {
      HandleInput();
   }

   void HandleInput()
   {
      if (Input.GetButtonDown("Fire1"))
      {
         OnClick?.Invoke(Input.mousePosition);
      }
   }
}
