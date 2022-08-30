using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitManager : MonoBehaviour
{
    //ARRAY
    [SerializeField] GameObject[] fruits;

    //LISTA 
    [SerializeField] List<GameObject> fruitList;
    public List<GameObject> FruitList { get => fruitList; set => fruitList = value; }
    

    //DICCIONARIO
    private Dictionary<string, GameObject> fruitDictionary;
    public Dictionary<string, GameObject> FruitDictionary { get => fruitDictionary; set => fruitDictionary = value; }

    void Start()
    {
        ShowAllFruits();
        fruitList = new List<GameObject>();
        FruitDictionary = new Dictionary<string, GameObject>();
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) EnableAllFruits();

         if (Input.GetKeyDown(KeyCode.Alpha1)) EnableFruit(fruitDictionary["Orange"]);
        if (Input.GetKeyDown(KeyCode.Alpha2)) EnableFruit(fruitDictionary["Banana"]);
        if (Input.GetKeyDown(KeyCode.Alpha3)) EnableFruit(fruitDictionary["Strawberry"]);
    }

    //Recorre el Array
    void ShowAllFruits()
    {
        for (int i = 0; i < fruits.Length; i++)
        {
            Debug.Log("La fruta "+ i +" es una "+ fruits[i].name);
        }
    }

    void EnableAllFruits()
    {
        foreach (GameObject fruit in fruitList)
        {
            fruit.SetActive(true);
        }
    }

    void EnableFruit(GameObject fruit)
    {
        fruit.SetActive(true);
    }
}
