﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{
  int i = 0;
  int counter = 0;

    // Start is called before the first frame update
    void Start(){

    }

    // Update is called once per frame
    void Update(){
      if(counter >= 5){
        if(i < 10){
          transform.RotateAround(transform.parent.position, new Vector3(0, 0, -1f), 10);
          if(i == 9){
            StartCoroutine("dest");
          }
          i++;
        }
      }
      else{
        counter++;
      }
    }

    IEnumerator dest(){
      yield return new WaitForSeconds(0.2f);
      Destroy(this.gameObject);
    }
}
