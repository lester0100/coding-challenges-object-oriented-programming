using _3_inheritance_my_cat_family_album;

HouseCat cat1 = new HouseCat(name: "Orange", color: "Orange", age: 5, breed: "No breed");
HouseCat cat2 = new HouseCat(name: "Gusion", color: "Gray", age: 1, breed: "Persian");
StrayCat cat3 = new StrayCat(name: "Jawhead", color: "Panda", age: 3, breed: "No breed", territory: "First street");
StrayCat cat4 = new StrayCat(name: "Oreo", color: "Dark brown", age: 6, breed: "Siamese", territory: "Third street");
RescueCat cat5 = new RescueCat(name: "Coffee", color: "Dark brown", age: 4, breed: "Siamese", shelter:  "Animal Society", isVaccinated: true);
RescueCat cat6 = new RescueCat(name: "Mythic", color: "Panda", age: 7, breed: "No breed", shelter: "Cat Foundation", isVaccinated: false);

cat1.HouseCatProfile();
Console.WriteLine();
cat2.HouseCatProfile();
Console.WriteLine();

cat3.StrayCatProfile();
cat3.Fight();
Console.WriteLine();
cat4.StrayCatProfile();
Console.WriteLine();

cat5.RescueCatProfile();
Console.WriteLine();
cat6.RescueCatProfile();