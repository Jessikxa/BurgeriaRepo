using UnityEngine;

public class Ingredient : MonoBehaviour
{
    public string ingredientName;


  
    void Start()
    {
        ingredientName = gameObject.name;
    }

    
    void Update()
    {
        
    }

    public Ingredient()
    {

    }

    //functie die door alle ingredienten loopt.

}
