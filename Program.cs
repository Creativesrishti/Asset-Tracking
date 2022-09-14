Console.WriteLine("Enter the list of assets and type q to exit");
List<Asset> assets = new List<Asset>();


while (true)
{
    Console.WriteLine("Enter the type of Asset you want to add(Computer/Phone)");
    string typeOfAsset = Console.ReadLine();

    Console.WriteLine("Enter Brand name");
    string brand = Console.ReadLine();

    Console.WriteLine("Enter Purchase Date");
    string purchasedate = Console.ReadLine();
 
    Console.WriteLine("Enter Price");
    string price = Console.ReadLine();

    Console.WriteLine("Model Name");
    string modelname = Console.ReadLine();

    if (typeOfAsset.ToLower().Trim() == "computer")
    {
        Computers comp = new Computers(brand, purchasedate, Convert.ToInt32(price), modelname);
        assets.Add(comp);
    }
    if (typeOfAsset.ToLower().Trim() == "phone")
    {
        Phones phone = new Phones(brand, purchasedate, Convert.ToInt32(price), modelname);
        assets.Add(phone);
    }
    if(assets.Count == 3)
    {
        break;
    }
}
foreach (Asset asset in assets)
{
    Console.WriteLine(asset.Brand.PadRight(10) + asset.PurchaseDate.PadRight(10)
        + asset.Price.ToString().PadRight(10) + asset.ModelName.ToString().PadRight(10));
}

Console.ReadLine();

class Asset   // base-parent-super class
{
    public string Brand { get; set; }
    public string PurchaseDate { get; set; }
    public int Price { get; set; }
    public string ModelName { get; set; }
}
class Computers : Asset // inherits from Asset
{
    public Computers(string brand, string purchasedate, int price, string modelname)
    {
        Brand = brand;
        PurchaseDate = purchasedate;
        Price = price;
        ModelName = modelname;

    }
}

class Phones: Asset
{
    public Phones(string brand, string purchasedate, int price, string modelname)
    {
        Brand = brand;
        PurchaseDate = purchasedate;
        Price = price;
        ModelName = modelname;
    }
}

