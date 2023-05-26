class paypal:TecnologiaApp
{
    int id;

    public paypal(int id)
    {
        this.id = id;
    }

    string smail;
    string password;

    public string Smail { get => smail; set => smail = value; }
    public string Password { get => password; set => password = value; }
}