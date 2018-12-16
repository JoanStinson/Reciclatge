using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Game : MonoBehaviour {
   
    public static int level;
    public static int contenedor;
    public enum CONTENEDOR { Vidrio, Plastico, Carton , Organic, }
    public static int pointss;
    public static CONTENEDOR contain;
    private void Start () {
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
                SpawnObjects.spawnTime = 1.2f;
                break;
            case 3:
                contain = CONTENEDOR.Carton;
                SpawnObjects.spawnTime = 1.4f;
                break;
            case 4:
                contain = CONTENEDOR.Organic;
                SpawnObjects.spawnTime = 1.6f;
                break;
        }
    }
}
