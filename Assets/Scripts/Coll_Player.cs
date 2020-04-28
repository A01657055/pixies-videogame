using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coll_Player : MonoBehaviour
{

//Variables globales declaradas antes del Start dentro de la clase
private bool hasPlate = false;

//0 es que no tiene comida
public int typeOfFood = 0;

public int time = 0;

void OnCollisionEntered(Collision Collision){
	string objCollision = Collision.transform.tag; //se puede usar name o tag
	Debug.Log(Collision.collider.tag);
	
	//Si el objeto con el que choca tiene el tag de Mesa y no tiene plato
	if(objCollision == "Mesa" && !hasPlate){
	
		hasPlate = true;
		
	}else if(objCollision == "Food" && hasPlate){
	 
		//Si el objeto tiene el tag de Food y tiene plato
		//Vas al objeto comida (como el cliente que te enseñe) y asignas el tipo de comida que tienes
		typeOfFood = Collision.gameObject.GetComponent<Comida_Coll>().tipoComida;
		
	}else if(objCollision == "Cliente" && typeOfFood!=0){ 
	
		//Si el objeto con el que choca tiene el tag de cliente y tienes comida
		//Comparas si tienes el tipo de comida que quería el cliente
		if(Collision.gameObject.GetComponent<Cliente>().tipoComida == typeOfFood){
			
			time += 10;
			
		}else{
		
			time -= 10;
	}
     }
  }

}
