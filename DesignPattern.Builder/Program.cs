using DesignPattern.Builder.Models;

Console.WriteLine("Hello, World!");
//var maze = new Maze();

var countingMazeBuilder = new CountingMazeBuilder();
var complexMazeBuilder = new ComplexMazeBuilder();

var director = new DirectorComplexMaze(complexMazeBuilder);
//var x = director.BuildCountingMaze();
var y = director.BuildComplexMaze();

Console.ReadLine();