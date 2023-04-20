using C__Shop_2;
//CATEGORIES
        //Category dress = new Category("Dress", "Something you wear");
        //Category furniture = new Category("Furniture", "Basic furnitures for every house");
        //Category tool = new Category("Tool", "You can use it to do things");
        //Category book = new Category("Book", "Can use it to read");
        //Category food = new Category("Food", "Something you eat");
Category beverage = new Category("Beverage", "something you drink");

//GENERAL PRODUCTS 
        //Product acquaLeteBottled = new Product("Acqua Lete", "It's a very good water", 1.00f, 15.00f, beverage);
        //Product product2 = new Product("Chair", "It's a chair", 25.00f, 22.00f, furniture);
        //Product product3 = new Product("Spoon", "It's a spoon", 2.00f, 22.00f, tool);
        //Product product4 = new Product("Expensive dress", "It's an expensive dress", 900.00f, 22.00f, dress);

//SPECIFIC PRODUCTS
BottleOfWater acquaLeteBigBottle = new BottleOfWater("Acqua Lete", "Just a bit of sodium", 1.00f, 17.00f, beverage, 1.5f, 7.2f,"A source" );

//CREATING LIST OF PRODUCTS (INVENTORIES)
        //List<Product> inventoryBeverages = new List<Product>();
        //List<Product> inventoryFoods = new List<Product>();
        //List<Product> inventoryTools = new List<Product>();
        //List<Product> inventoryFurnitures = new List<Product>();

//SHOPS
Shop test1 = new Shop("fake name", "fake city", "fake street", 1234);

//ADDING SINGLE PRODUCT TO LIST OF PRODUCTS OF SHOP NAMED test1
test1.AddSingleProductToProducts(acquaLeteBigBottle);

//CONCATENATE LIST TO SHOP LIST
        //.ConcatListToProducts(inventory);


//MAIN PROGRAM (TESTS)
foreach (Product anyProduct  in test1.products)
{

    string info = anyProduct.GetCategory().GetCategoryInfo();
    info += anyProduct.GetProductInfo();
    Console.WriteLine(info);
}

Console.WriteLine(acquaLeteBigBottle.GetProductInfo());
Console.WriteLine(acquaLeteBigBottle.GetCategory().GetCategoryInfo());
Console.WriteLine(acquaLeteBigBottle.GetIvaPrice());
acquaLeteBigBottle.Name = "New Name Acqua Lete";
Console.WriteLine(acquaLeteBigBottle.GetProductInfo());
Console.WriteLine(acquaLeteBigBottle.Name);
Console.WriteLine(acquaLeteBigBottle.Price);
Console.WriteLine(acquaLeteBigBottle.getCode());

//la bottiglia nasce chiusa
    //chiedo se la bottiglia è aperta
Console.WriteLine("Is the bottle open?");
Console.WriteLine(acquaLeteBigBottle.isBottleOpen());

        //apro la bottiglia
Console.WriteLine("Open the bottle");
acquaLeteBigBottle.openBottle();

        //chiedo se la bottiglia è aperta
Console.WriteLine("Is the bottle open?");
Console.WriteLine(acquaLeteBigBottle.isBottleOpen());

        //apro la bottiglia
Console.WriteLine("Open the bottle");
acquaLeteBigBottle.openBottle();

        //chiedo se la bottiglia è aperta
Console.WriteLine("Is the bottle open?");
Console.WriteLine(acquaLeteBigBottle.isBottleOpen());

//chiudo la bottiglia
Console.WriteLine("Close the bottle");
acquaLeteBigBottle.closeBottle();
    //chiedo se la bottiglia è aperta
Console.WriteLine("Is the bottle open?");
Console.WriteLine(acquaLeteBigBottle.isBottleOpen());