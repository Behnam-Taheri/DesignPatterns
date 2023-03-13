using DesignPattern.FluentBuilder;

QueryBuilder queryBuilder = new QueryBuilder();

var q1=queryBuilder.Select().From("Product").Where("id", "2").Build();


var q2 = queryBuilder.Select().From("Product").Build();

//var q3 = queryBuilder.Select().Build();

var q4 = queryBuilder.Select().From("Category").Where("id", "3").Build();

Console.ReadLine();