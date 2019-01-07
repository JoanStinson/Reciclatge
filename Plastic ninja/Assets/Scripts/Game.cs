using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Game : MonoBehaviour {
   
    public static int level;
    public static int contenedor;
    public enum CONTENEDOR { Vidrio, Plastico, Carton , Organic, General }
    public static int pointss;
    public static CONTENEDOR contain;
    public GameObject contenedorVerde;
    public GameObject contenedorAzul;
    public GameObject contenedorAmarillo;
    public GameObject contenedorGris;
    public GameObject contenedorMarron;
    private void Start () {
        pointss = 0; //SE ESCRIBE EN EL MENU XD
        if(Game.level == 1)
        {
              contenedorVerde.gameObject.SetActive(true);
              contenedorAzul.gameObject.SetActive(false);
              contenedorAmarillo.gameObject.SetActive(false);
              contenedorGris.gameObject.SetActive(false);
              contenedorMarron.gameObject.SetActive(false);
        }
        if (Game.level == 2)
        {
            contenedorVerde.gameObject.SetActive(false);
            contenedorAzul.gameObject.SetActive(false);
            contenedorAmarillo.gameObject.SetActive(true);
            contenedorGris.gameObject.SetActive(false);
            contenedorMarron.gameObject.SetActive(false);
        }
        if (Game.level == 3)
        {
            contenedorVerde.gameObject.SetActive(false);
            contenedorAzul.gameObject.SetActive(true);
            contenedorAmarillo.gameObject.SetActive(false);
            contenedorGris.gameObject.SetActive(false);
            contenedorMarron.gameObject.SetActive(false);
        }
        if (Game.level == 4)
        {
            contenedorVerde.gameObject.SetActive(false);
            contenedorAzul.gameObject.SetActive(false);
            contenedorAmarillo.gameObject.SetActive(false);
            contenedorGris.gameObject.SetActive(false);
            contenedorMarron.gameObject.SetActive(true);
        }
        if (Game.level == 5)
        {
            contenedorVerde.gameObject.SetActive(false);
            contenedorAzul.gameObject.SetActive(false);
            contenedorAmarillo.gameObject.SetActive(false);
            contenedorGris.gameObject.SetActive(true);
            contenedorMarron.gameObject.SetActive(false);
        }
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
            case 5:
                contain = CONTENEDOR.General;
                SpawnObjects.spawnTime = 1.6f;
                break;
        }
    }
}
