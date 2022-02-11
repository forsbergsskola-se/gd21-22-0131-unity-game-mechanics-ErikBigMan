using System;
using System.Collections;
using System.Collections.Generic;
//using UnityEditorInternal;
using UnityEngine;

public class BetterFly : MonoBehaviour
{
   
   public float fallMultiplier = 2.5f;
   public float flyBoostMultiplier = 2f;
   //private fly fly;
      
   Rigidbody rb;

   private void Awake()
   {
      rb = GetComponent<Rigidbody>();
      //fly = GetComponent<fly>();
   }
   
   
   public void Update()
   {
      if (rb.velocity.y < 0)
      {
         rb.velocity += Vector3.up * Physics.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
      }
      else if (rb.velocity.y > 0 && !Input.GetButtonDown("Jump"))
      {
         rb.velocity += Vector3.up * Physics.gravity.y * (flyBoostMultiplier - 1) * Time.deltaTime;
      }
      
      /*var isgrounded = Physics.Raycast(transform.position, Vector3.down, fly.Grounded);

      if (Input.GetButton("Jump") && fly.boost < 0|| Input.GetButtonDown("HorizontalLeft") && fly.boost < 0|| Input.GetButtonDown("HorizontalRight") && fly.boost < 0)
      {
         fly.movmentscript(); enabled = false;
      }
      if (isgrounded)
      { 
         fly.boost = Mathf.Clamp(fly.boost+Time.deltaTime/fly.rechargeDuration, 1, 1);
         if (fly.boost > 0)
         {
            fly.movmentscript(); enabled = true;
         }
      }*/
   }
}
