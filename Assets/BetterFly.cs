using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class BetterFly : MonoBehaviour
{
   public float fallMultiplier = 2.5f;
   public float flyBoostMultiplier = 2f;

   Rigidbody rb;

   private void Awake()
   {
      rb = GetComponent<Rigidbody>();
   }
   private void Update()
   {
      if (rb.velocity.y < 0)
      {
         rb.velocity += Vector3.up * Physics.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
      }
      else if (rb.velocity.y > 0 && !Input.GetButtonDown("Jump"))
      {
         rb.velocity += Vector3.up * Physics.gravity.y * (flyBoostMultiplier - 1) * Time.deltaTime;
      }
   }
}
