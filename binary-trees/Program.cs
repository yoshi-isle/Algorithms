using BinaryTrees.Models;
using BinaryTrees.Generators;
using System.Text.Json;

Node test = BinaryTreeGenerator.GenerateBinaryTree(100);
JsonSerializerOptions options = new()
{
    MaxDepth = 1000 //TODO - Temp solution to solve the nesting
};

var json = JsonSerializer.Serialize(test, options);
File.WriteAllText($"generated-trees/binarytree-{Guid.NewGuid()}.json", json);