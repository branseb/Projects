using System;
using BinaryTree;
using Extensions;
using ResidentsDatabase;

var binaryTree = new BinaryTree<Resident, string>();
var lastID = "";
for (int i = 0; i < 10000; i++)
{
    var id = Guid.NewGuid().ToString().Split('-')[0];
    var resident = new Resident("Name", new DateOnly(), id);

    try
    {
        binaryTree.Add(resident.ID, resident);
        lastID = id;
    }
    catch
    {
        Console.WriteLine("ID already exists");
    }
}

binaryTree.Get(lastID).Log();