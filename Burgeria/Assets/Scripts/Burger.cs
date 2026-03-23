


using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class Burger
{
    private string burgerName;
    private string username;
    private List<Ingredient> burgerIngredients;

    public Burger()
    {
        burgerName = "Mik Burger";
        username = "Chom";
        burgerIngredients = new List<Ingredient>();
    }

    public void LogIngredients()
    {
        //Debug.Log("Burger: " + burgerName + " by " + username);
        foreach (Ingredient ingredient in burgerIngredients)
        {
            Debug.Log("Ingredient: " + ingredient.name);
        }
    }

    public void AddIngredient(Ingredient ingredient)
    {
        burgerIngredients.Add(ingredient);
    }

}