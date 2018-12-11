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

        level = 1;

    }
	
	// Update is called once per frame
	void Update () {
       //Debug.Log(contain);
        if (level == 1)
        {
            contain = CONTENEDOR.Vidrio;
            SpawnObjects.spawnTime = 30; //SE PUEDE CAMBIAR SEGUN LA DIFICULTAD QUE QUERRAMOS METER!! TIEMPO DE SPAWN ENTRE OBJETOS

        }
        else if (level == 2)
        {
            contain = CONTENEDOR.Plastico;
            SpawnObjects.spawnTime = 50;
        }
        else if (level == 3)
        {
            contain = CONTENEDOR.Carton;
            SpawnObjects.spawnTime = 50;
        }
    }
}
