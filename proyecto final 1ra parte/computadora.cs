class computadora
{
    public string asus { set; get; }
    public string hp {set;get;}
    public string acer {set;get;}
    public string dell {set;get;}
    public int numero { set; get; }




    public computadora(String acer,int numero, String asus, String hp,String dell) :base()
    {
        this.hp = hp;
        this.asus = asus;
        this.dell = dell;
        this.acer = acer;
        this.numero  = numero ;
    }
    public void imprimir()
    {
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("    elija la marca de la computadora que desea comprar ");
        Console.WriteLine("");
        Console.WriteLine("acer " + acer);
        Console.WriteLine("");
        Console.WriteLine("numero de unidades a comprar  " + numero);
        Console.WriteLine("");
        Console.WriteLine("dell "+ dell);
        Console.WriteLine("");
        Console.WriteLine("hp" + hp);
        Console.WriteLine("");
        Console.WriteLine("asus " + asus);
        Console.WriteLine("");
    
        Console.WriteLine("");
        Console.WriteLine("--------------------------------------------");
    }
}