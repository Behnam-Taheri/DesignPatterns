
using DesignPattern.Observer.WithMarker.Models;
using System.Reflection;

var subject = new Subject();

Assembly.GetExecutingAssembly().GetTypes().Where(x => x.IsAssignableTo(typeof(IObserver)) && !x.IsInterface).ToList().ForEach(o => subject.Add((Activator.CreateInstance(o) as IObserver)!));




//var assembly = Assembly.GetExecutingAssembly();
//var observers = assembly.GetTypes().Where(x => x.IsAssignableTo(typeof(IObserver)) && !x.IsInterface).ToList();

//observers.ForEach(o => subject.Add((Activator.CreateInstance(o) as IObserver)!));


subject.Score = 17;

Console.ReadKey();