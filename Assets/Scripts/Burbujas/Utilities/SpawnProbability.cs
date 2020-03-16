using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Random =UnityEngine.Random;




[System.Serializable]
public class SpawnProbability:MonoBehaviour
{
   [SerializeField] [Range(0, 1)]  float[] traits;

   public void NormalizedMeigths()
   {
      
      
      float diference = traits.Sum()-1f;

      if (Total > 1 )
      {
         for (int i = 0; i < traits.Length; i++)
         {
            traits[i] -= diference /(float) traits.Length;
         }
      }

      if (Total < 1)
      {
         for (int i = 0; i < traits.Length; i++)
         {
            traits[i] += diference /(float) traits.Length;
         }
      }
      
   }

   public float Total => traits.Sum();

   public int EvaluateProbability()
   {
      float  totalWeigth = traits.Sum();
      float rNumber = Random.Range(0, totalWeigth);

      for (int i = 0; i < traits.Length; i++)
      {
         rNumber -= traits[i];
         if (rNumber <= 0)
         {
            return i;
         }

        
      }

      return traits.Length;
   }
}
