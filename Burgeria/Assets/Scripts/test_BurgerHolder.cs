using System;
using UnityEngine;

public class test_BurgerHolder : MonoBehaviour
{
    Burger burger;
    [SerializeField] private Ingredient broodOnderkantPrefab;
    [SerializeField] private Ingredient slaPrefab;
    [SerializeField] private Ingredient augurkPrefab;
    [SerializeField] private Ingredient kaasPrefab;
    [SerializeField] private Ingredient burgerPrefab;
    [SerializeField] private Ingredient broodBovenkantPrefab;


    [SerializeField] private float spawnPositiontY = -1f;
    [SerializeField] private float spawnPositiontZ = 0f;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        burger = new Burger();
        
        
        //brood bovenkant
        //Ingredient broodBovenkant = Instantiate(broodBovenkantPrefab, new Vector3(0, 4, 0), Quaternion.identity);

        //burger.AddIngredient(broodBovenkant);
        //burger.LogIngredients();


        ////augurk
        //Ingredient augurk = Instantiate(augurkPrefab, new Vector3(0, 3, 0), Quaternion.identity);



        //burger.AddIngredient(augurk);
        //burger.LogIngredients();

        ////sla
        //Ingredient sla = Instantiate(slaPrefab, new Vector3(0, 2, 0), Quaternion.identity);



        //burger.AddIngredient(sla);
        //burger.LogIngredients();

        ////kaas
        //Ingredient kaas = Instantiate(kaasPrefab, new Vector3(0, 1, 0), Quaternion.identity);

        //burger.AddIngredient(kaas);
        //burger.LogIngredients();


        ////burger
        //Ingredient Burger = Instantiate(burgerPrefab, new Vector3(0, 0, 0), Quaternion.identity);



        //burger.AddIngredient(Burger);
        //burger.LogIngredients();

        ////brood onderkant
        //Ingredient broodOnderkant = Instantiate(broodOnderkantPrefab, new Vector3(0, -1, 0), Quaternion.identity);

        //burger.AddIngredient(broodOnderkant);
        //burger.LogIngredients();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddOnderkant()
    {
        //    //brood bovenkant
        //    Ingredient broodBovenkant = Instantiate(broodBovenkantPrefab, new Vector3(0, 4, 0), Quaternion.identity);

        //    burger.AddIngredient(broodBovenkant);
        //    burger.LogIngredients();

        Ingredient burgerOnder;
        burgerOnder = Instantiate(broodOnderkantPrefab, new Vector3(0, spawnPositiontY, spawnPositiontZ), Quaternion.identity) as Ingredient;
        burgerOnder.transform.parent = transform;
        burger.AddIngredient(burgerOnder);
        spawnPositiontY += 1f;
        spawnPositiontZ -= 0.5f;
        print("Brood onderkant toegevoegd");
    }

    public void AddBovenkant()
    {
        //brood bovenkant
        Ingredient broodBovenkant = Instantiate(broodBovenkantPrefab, new Vector3(0, spawnPositiontY, spawnPositiontZ), Quaternion.identity);

        burger.AddIngredient(broodBovenkant);
        burger.LogIngredients();
        spawnPositiontY += 1f;
        spawnPositiontZ -= 0.5f; ;
    }

    public void AddBurger()
    {
        //burger
        Ingredient Burger = Instantiate(burgerPrefab, new Vector3(0, spawnPositiontY, spawnPositiontZ), Quaternion.identity);
        burger.AddIngredient(Burger);
        burger.LogIngredients();
        spawnPositiontY += 1f;
        spawnPositiontZ -= 0.5f;
    }
     public void AddKaas()
    {
        //kaas
        Ingredient kaas = Instantiate(kaasPrefab, new Vector3(0, spawnPositiontY, spawnPositiontZ), Quaternion.identity);
        burger.AddIngredient(kaas);
        burger.LogIngredients();
        spawnPositiontY += 1f;
        spawnPositiontZ -= 0.5f;
    }
     public void AddSla()
    {
        //sla
        Ingredient sla = Instantiate(slaPrefab, new Vector3(0, spawnPositiontY, spawnPositiontZ), Quaternion.identity);
        burger.AddIngredient(sla);
        burger.LogIngredients();
        spawnPositiontY += 1f;
        spawnPositiontZ -= 0.5f;
    }
     public void AddAugurk()
    {
        //augurk
        Ingredient augurk = Instantiate(augurkPrefab, new Vector3(0, spawnPositiontY, spawnPositiontZ), Quaternion.identity);
        burger.AddIngredient(augurk);
        burger.LogIngredients();
        spawnPositiontY += 1f;
        spawnPositiontZ -= 0.5f;
    }
}
