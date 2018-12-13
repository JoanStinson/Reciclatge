using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour {
   
    public static int level;
    public static int contenedor;
    public enum CONTENEDOR { Vidrio, Plastico, Carton , Organic, }
    public static int pointss;
    public static CONTENEDOR contain;

    private void Start () {
        level = 1; //SE ELIGE EN EL MENU!!
        pointss = 0; //SE ESCRIBE EN EL MENU XD
    }
	
	private void Update () {
       //Debug.Log(contain);

       switch(level) {

            case 1:
                contain = CONTENEDOR.Vidrio;
                SpawnObjects.spawnTime = 1f; //SE PUEDE CAMBIAR SEGUN LA DIFICULTAD QUE QUERRAMOS METER!! TIEMPO DE SPAWN ENTRE OBJETOS
                break;
            case 2:
                contain = CONTENEDOR.Plastico;
                SpawnObjects.spawnTime = 5f;
                break;
            case 3:
                contain = CONTENEDOR.Carton;
                SpawnObjects.spawnTime = 5f;
                break;
        }
    }
}
