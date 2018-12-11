using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour {
   
    public static int level;
    public static int contenedor;
    public enum CONTENEDOR { Vidrio, Plastico, Carton , Organic, }
    // Use this for initialization 
   public static CONTENEDOR contain;
      void Start () {

        level = 1; //SE ELIGE EN EL MENU!!

    }
	
	// Update is called once per frame
	void Update () {
       //Debug.Log(contain);
       switch(level)
        {
            case 1:
                contain = CONTENEDOR.Vidrio;
                SpawnObjects.spawnTime = 30; //SE PUEDE CAMBIAR SEGUN LA DIFICULTAD QUE QUERRAMOS METER!! TIEMPO DE SPAWN ENTRE OBJETOS
                break;
            case 2:
                contain = CONTENEDOR.Plastico;
                SpawnObjects.spawnTime = 50;
                break;
            case 3:
                contain = CONTENEDOR.Carton;
                SpawnObjects.spawnTime = 50;
                break;
        }
    }
}
