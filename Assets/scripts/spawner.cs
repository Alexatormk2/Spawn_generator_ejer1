using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;

public class spawner : MonoBehaviour
{

public randomvalue npcdata;

    
    
int numeronpc = 0;
 
    
    float x = 0;
    float y = 0;
    float z = 0;

    // Start is called before the first frame update
    void Start()
    {

        Debug.Log("hola este es el vlaor de la variable" + numeronpc);
        
    }
public void spawn(){
         if(Input.GetKeyDown("space")){
numeronpc= Random.Range(npcdata.minr ,npcdata.maxr);

 for(int contador = 0;contador<=numeronpc;contador++){
            Instantiate(npcdata.cilinder, new Vector3(x, y, z), Quaternion.identity);

            
                z = z + 0.5f;
                x = x + 1;
            
              }
              Debug.Log("valor de la variable antes del reset" + numeronpc);
             
}
   
                


}
    // Update is called once per frame
    void Update()
    {

spawn();
           
          
    }
}
