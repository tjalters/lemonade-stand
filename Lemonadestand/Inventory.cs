﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonadestand
{
    public class Inventory
    {
        public Ingredients ingredients;
        public Store store;
        public int storedLemons;
        public int number;
        public int amountLemonsPerPitcher;
        public int amountCupsSugarPerPitcher;
        public int amountOfIceCubesPerPitcher;
        public int numberOfCups;
        public decimal amountToSubtract;
        List<Lemon> lemon;
        public List<Cups> cups;
        List<Sugar> sugar;
        List<Ice> ice;



        public Inventory()
        {
            ingredients = new Ingredients();
            //store = new Store();


            lemon = new List<Lemon>();
            cups = new List<Cups>();
            sugar = new List<Sugar>();
            ice = new List<Ice>();
            //create list of each ingredient
            //to get recipe = player.inventory.ingredients
            //create list that stores each ingredient
            //Display- Ex: "you have 50 lemons, 45 cups of sugar, and 30 cups left"

            //List<Lemon> lemon = new List<Lemon>();
            //lemon.Add(0);
            //lemon.Remove(0);

            //foreach (int number in numbers)
            //{
            // Console.WriteLine(number);
            //}

        }

        //public double TotalLemonsInInventory(int storedLemons, int numberOfLemons)
        //{
        //lemons = storedLemons;
        //addedLemons = numberofLemons;
        //result = lemons + addedLemons;
        //return result;

        //}


        public void AddLemonsToInventory(int numberOfLemons)
        {
            for (int i = 0; i < numberOfLemons; i++)
            {
                numberOfLemons = storedLemons;
               // storedLemons.Add();

            }
        }
        public void AddCupsToInventory(int numberOfCups)
        {
            for (int i = 0; i < numberOfCups; i++)
            {
                List<Cups> cups = new List<Cups>();
            }
        }
        public void AddCupsSugarToInventory(int cupsOfSugar)
        {
            for (int i = 0; i < cupsOfSugar; i++)
            {
                
            }
        }
        public void RemoveLemonsFromInventory(int numberOfLemons)
        {
            for (int i = 0; i > numberOfLemons; i++)
            {
                lemon.RemoveAt(0);
            }
        }
        public void RemoveCupsFromInventory(int numberOfCups)
        {
            for (int i = 0; i > numberOfCups; i++)
            {
                cups.RemoveAt(0);
            }
        }
        public void RemoveCupsSugarFromInventory(int cupsOfSugar)
        {
            for (int i = 0; i > cupsOfSugar; i++)
            {
                sugar.RemoveAt(0);
            }
        }



    }
}
