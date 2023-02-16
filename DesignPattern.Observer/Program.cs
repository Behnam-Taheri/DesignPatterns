

using DesignPattern.Observer;

Subject subject = new Subject();
var student = new Student();
var parent = new Parent();
var support = new Support();

subject.Add(student);
subject.Add(parent);
subject.Add(support);

subject.Score = 17;

Console.ReadKey();