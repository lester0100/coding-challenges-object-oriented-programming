using _3_inheritance_cat_types;

HouseCat cat1 = new HouseCat(name: "Orange", color: "Orange", age: 5, breed: "No breed");
HouseCat cat2 = new HouseCat(name: "Gusion", color: "Gray", age: 1, breed: "Persian");
StrayCat cat3 = new StrayCat(name: "Jawhead", color: "Panda", age: 3, breed: "No breed", territory: "First street");
StrayCat cat4 = new StrayCat(name: "Oreo", color: "Dark brown", age: 6, breed: "Siamese", territory: "Third street");
RescueCat cat5 = new RescueCat(name: "Coffee", color: "Dark brown", age: 4, breed: "Siamese", shelter:  "Animal Society", isVaccinated: true);
RescueCat cat6 = new RescueCat(name: "Mythic", color: "Panda", age: 7, breed: "No breed", shelter: "Cat Foundation", isVaccinated: false);

Console.WriteLine("Cat Profiles");

cat1.DisplayProfile();

cat2.DisplayProfile();

cat3.DisplayProfile();
cat3.Fight();

cat4.DisplayProfile();

cat5.DisplayProfile();

cat6.DisplayProfile();