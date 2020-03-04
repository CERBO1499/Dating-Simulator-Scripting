using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Random =UnityEngine.Random;




[System.Serializable]
public class SpawnProbability:MonoBehaviour
{
   [SerializeField] [Range(0, 1)]  float[] traits;

   


   public int EvaluateProbability()
   {
      float  totalWeigth = (int)traits.Sum(i=>i*100);
      float rNumber = Random.Range(0, totalWeigth);

      for (int i = 0; i < traits.Length; i++)
      {
         if (rNumber < traits[i] * 100)
         {
            return i;
         }

         rNumber -= traits[i];
      }

      return traits.Length;
   }
}
