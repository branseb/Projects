using System;
using System.Diagnostics;
using hladanie_značiek;
using BinaryTree;

var binaryTree = new BinaryTree<Car, int>();
var generator = new Random();
var posledne = 0;

for (int i = 0; i < 1001; i++)
{
    int cislo = generator.Next();
    binaryTree.Add(cislo, new Car(cislo, cislo + " Priezvisko"));
    if (i == 1000)
        posledne = cislo;
}

Console.WriteLine("all cars inserted");

var autoZoStromu = binaryTree.Get(posledne);
Console.WriteLine(autoZoStromu.ToString());

Console.ReadLine();
