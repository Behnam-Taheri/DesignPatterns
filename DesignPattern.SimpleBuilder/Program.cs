using DesignPattern.SimpleBuilder;

QueryBuilder queryBuilder = new QueryBuilder();

//queryBuilder.Select();
//queryBuilder.From("Product");
//queryBuilder.Where("color", "Red");
//var query = queryBuilder.Build();


var query = queryBuilder.Select().From("Product").Where("color", "Red").Build();
Console.WriteLine(query);

