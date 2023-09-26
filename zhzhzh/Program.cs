using System;

class Laptop
{
    public string merk;
    public string tipe;
    public Vga vga;
    public Processor processor;

    public void LaptopDinyalakan()
    {
        Console.WriteLine("Laptop " + merk + " bertipe " + tipe + " menyala");
    }
    public void LaptopDimatikan()
    {
        Console.WriteLine("Laptop " + merk + " bertipe " + tipe + " mati");
    }
    public void BermainGame()
    {
        Console.WriteLine("Laptop " + merk + " bertipe " + tipe + " Sedang bermain game");
    }
    public void Ngoding()
    {
        Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
    }
}

class Asus : Laptop
{
    public Asus()
    {
        merk = "Asus";
    }
}

class ROG : Asus
{
    public ROG()
    {
        tipe = "ROG";
    }
}

class Vivobook : Asus
{
    public Vivobook()
    {
        tipe = "Vivobook";
    }
    public void Ngoding()
    {}
}
class Acer : Laptop
{
    public Acer()
    {
        merk = "Acer";
    }
}

class Swift : Acer
{
    public Swift()
    {
        tipe = "Swift";
    }
}

class Predator : Acer
{
    public Predator()
    {
        tipe = "Predator";
    }
    public void BermainGame()
    {
        Console.WriteLine("Laptop " + merk + " bertipe " + tipe + " Sedang bermain game");
    }

}

class Lenovo : Laptop
{
    public Lenovo()
    {
        merk = "Lenovo";
    }
}

class Ideapad : Lenovo
{
    public Ideapad()
    {
        tipe = "Ideapad";
    }
}

class Legion : Lenovo
{
    public Legion()
    {
        tipe = "Legion";
    }
}

class Processor
{
    public string merk;
    public string tipe;
}

class Intel : Processor
{
    public Intel()
    {
        merk = "Intel";
    }
}

class Corei3 : Intel
{
    public Corei3()
    {
        tipe = "Core i3";
    }
}

class Corei5 : Intel
{
    public Corei5()
    {
        tipe = "Core i5";
    }
}

class Corei7 : Intel
{
    public Corei7()
    {
        tipe = "Core i7";
    }
}
class AMD : Processor
{
    public AMD()
    {
        merk = "AMD";
    }
}

class Ryzen : AMD
{
    public Ryzen()
    {
        tipe = "Ryzen";
    }
}

class Athlon : AMD
{
    public Athlon()
    {
        tipe = "Athlon";
    }

}
class Vga
{
    public string merk;
}

class Nvidia : Vga
{
    public Nvidia()
    {
        merk = "Nvidia";
    }
}

class Amd : Vga
{
    public Amd()
    {
        merk = "Amd";
    }
}
class Utama
{
    public static void Main(string[] args)
    {
        Laptop laptop1 = new Vivobook();
        laptop1.processor = new Corei5();
        laptop1.vga = new Nvidia();
        laptop1.Ngoding();
        Console.WriteLine($"Spesifikasi Laptop {laptop1.merk} {laptop1.tipe}:");
        Console.WriteLine($"- VGA: {laptop1.vga.merk}");
        Console.WriteLine($"- Processor: {laptop1.processor.merk} {laptop1.processor.tipe}");


        Laptop laptop2 = new Ideapad();
        laptop2.processor = new Ryzen();
        laptop2.vga = new Amd();
        laptop2.LaptopDinyalakan();
        laptop2.LaptopDimatikan();


        Predator predator= new Predator();
        predator.processor = new Corei7();
        predator.vga = new Amd();
        predator.BermainGame();

    }
}