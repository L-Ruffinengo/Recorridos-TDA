using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollission : MonoBehaviour
{
    [SerializeField] FruitManager fruitManager;
    void Start()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Fruit"))
        {
           //LISTA
            //Debug.Log("En colisión con fruta");
            other.gameObject.SetActive(false);
            fruitManager.FruitList.Add(other.gameObject);

            //DICCIONARIO
             if (!fruitManager.FruitDictionary.ContainsKey(other.gameObject.name))
            {
                fruitManager.FruitDictionary.Add(other.gameObject.name, other.gameObject);
                Debug.Log(fruitManager.FruitDictionary[other.gameObject.name]);
            }
        }

    }
}
