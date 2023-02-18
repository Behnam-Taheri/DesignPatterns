using DesignPattern.Observer;

Subject subject = new Subject();
var student = new Student();
var parent = new Parent();
var support = new Support();

subject.Add(student);
subject.Add(parent);
subject.Add(support);

subject.Score = 17;

subject.Remove(parent);

subject.Score = 7;

Console.WriteLine(student.ToString());
Console.WriteLine(parent.ToString());
Console.WriteLine(support.ToString());

Console.ReadKey();